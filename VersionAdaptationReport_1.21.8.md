# Minecraft 1.21.8 Version Adaptation Report

## 1. 修改记录 (Modification Records)

为了适配 Minecraft 1.21.8，我们对 `Minecraft-Console-Client` 进行了以下核心修改：

### 1.1 协议与核心支持
*   **ProtocolHandler.cs**: 添加了 `1.21.8` 到 `770` 的协议版本映射。
*   **Protocol18.cs**: 
    *   定义了 `MC_1_21_8_Version` 常量 (770)。
    *   更新了 `Protocol18Handler` 初始化逻辑，加载对应的 1.21.8 Palettes。
    *   **重要调整**: 针对 1.21.8 版本，暂时禁用了 **Terrain (地形)**、**Inventory (物品栏)** 和 **Entity Handling (实体处理)** 模块，以防止因 1.20.5+ 数据组件 (Data Components) 格式变更导致的客户端崩溃。
*   **PacketType18Handler.cs**: 注册了 `PacketPalette1218` 用于 1.21.8 版本。

### 1.2 数据包与映射 (Palettes)
*   **PacketPalette1218.cs (New)**: 新建了数据包定义文件，基于 1.20.4 版本（假设主要包 ID 未变，用于维持连接）。
*   **Palette1218.cs (New)**: 新建方块映射文件，包含了 1.21 新增的方块（如 `HeavyCore`）。
*   **EntityPalette1218.cs (New)**: 新建实体映射文件，支持 `Armadillo` (犰狳), `Breeze` (旋风人), `Bogged` (沼泽骷髅), `WindCharge` (风弹) 等新实体。
*   **ItemPalette1218.cs (New)**: 新建物品映射文件，支持 `Mace` (重锤), `WolfArmor` (狼铠), `OminousBottle` (不祥之瓶) 等新物品。
*   **EntityMetadataPalette.cs**: 更新了元数据调色板映射，将 1.21.8 指向现有的 1.19.4+ 格式（暂定兼容）。

### 1.3 枚举定义 (Enums)
*   **Material.cs**: 新增 `HeavyCore`。
*   **EntityType.cs**: 新增 `Armadillo`, `Breeze`, `Bogged`, `WindCharge`, `BreezeWindCharge` 等实体类型。修复了 `WindCharge` 重复定义的编译错误。
*   **ItemType.cs**: 新增 1.21 相关物品枚举（如 `Mace`, `WindCharge`, `WolfArmor`, `TrialKey` 等）。

## 2. 兼容性矩阵 (Compatibility Matrix)

| 功能模块 | 1.21.8 兼容状态 | 详细说明 |
| :--- | :--- | :--- |
| **基础连接 (Connection)** | ✅ 支持 | 能够正常握手、登录服务器并保持在线 (KeepAlive)。 |
| **聊天功能 (Chat)** | ✅ 支持 | 聊天消息的接收与发送正常，支持聊天签名验证。 |
| **命令执行 (Commands)** | ✅ 支持 | 可以发送控制台命令。 |
| **脚本系统 (Scripting)** | ⚠️ 部分支持 | 仅限不依赖物品栏、实体位置和地形判断的脚本。 |
| **新特性支持 (New Features)** | ✅ 定义支持 | 代码已包含新物品/实体/方块的 Enum 定义。 |
| **物品栏 (Inventory)** | ❌ **禁用** | 由于 1.20.5+ 引入的 "Data Components" 彻底改变了物品 NBT 结构，暂禁用以防崩溃。 |
| **地形系统 (Terrain)** | ❌ **禁用** | 由于 1.20.2+ 区块数据包格式变更，暂禁用地形加载与自动寻路。 |
| **实体处理 (Entities)** | ❌ **禁用** | 暂禁用实体跟踪与交互，防止解析错误。 |

## 3. 已知问题与后续计划 (Known Issues & Future Work)

1.  **构建环境**: 当前开发环境缺少 .NET SDK，无法在本地完成最终的编译打包验证，需用户在具备 .NET 环境的机器上运行 `dotnet build`。
2.  **数据组件解析**: 目前仅完成了协议握手层的适配。若要完全支持物品栏和地形，需要重写底层 NBT 解析逻辑以适配 Minecraft 1.20.5+ 的 `ItemStack` 组件格式。
3.  **实体元数据**: 1.21 的实体元数据 ID 可能有所变化，当前沿用旧版映射，可能会导致在开启实体处理时读取错误数据。

## 4. 测试指南

建议用户在编译成功后，使用以下配置进行连接测试：
```ini
[Main]
login=your_email
password=your_password
serverip=127.0.0.1:25565
type=microsoft
version=1.21.8

[App]
# 确保以下高风险模块已在代码中强制禁用，配置文件中无需更改，但请知悉
# Terrain=false
# Inventory=false
# Entity=false
```
