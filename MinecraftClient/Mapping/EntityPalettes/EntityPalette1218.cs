using System.Collections.Generic;

namespace MinecraftClient.Mapping.EntityPalettes
{
    public class EntityPalette1218 : EntityPalette
    {
        private static readonly Dictionary<int, EntityType> mappings = new();

        static EntityPalette1218()
        {
            mappings[0] = EntityType.Allay;
            mappings[1] = EntityType.AreaEffectCloud;
            mappings[2] = EntityType.Armadillo;
            mappings[3] = EntityType.ArmorStand;
            mappings[4] = EntityType.Arrow;
            mappings[5] = EntityType.Axolotl;
            mappings[6] = EntityType.Bat;
            mappings[7] = EntityType.Bee;
            mappings[8] = EntityType.Blaze;
            mappings[9] = EntityType.BlockDisplay;
            mappings[10] = EntityType.Boat;
            mappings[11] = EntityType.Bogged;
            mappings[12] = EntityType.Breeze;
            mappings[13] = EntityType.BreezeWindCharge;
            mappings[14] = EntityType.Camel;
            mappings[15] = EntityType.Cat;
            mappings[16] = EntityType.CaveSpider;
            mappings[17] = EntityType.ChestBoat;
            mappings[18] = EntityType.ChestMinecart;
            mappings[19] = EntityType.Chicken;
            mappings[20] = EntityType.Cod;
            mappings[21] = EntityType.CommandBlockMinecart;
            mappings[22] = EntityType.Cow;
            mappings[23] = EntityType.Creeper;
            mappings[24] = EntityType.Dolphin;
            mappings[25] = EntityType.Donkey;
            mappings[26] = EntityType.DragonFireball;
            mappings[27] = EntityType.Drowned;
            mappings[28] = EntityType.Egg;
            mappings[29] = EntityType.ElderGuardian;
            mappings[30] = EntityType.EndCrystal;
            mappings[31] = EntityType.EnderDragon;
            mappings[32] = EntityType.EnderPearl;
            mappings[33] = EntityType.Enderman;
            mappings[34] = EntityType.Endermite;
            mappings[35] = EntityType.Evoker;
            mappings[36] = EntityType.EvokerFangs;
            mappings[37] = EntityType.ExperienceBottle;
            mappings[38] = EntityType.ExperienceOrb;
            mappings[39] = EntityType.EyeOfEnder;
            mappings[40] = EntityType.FallingBlock;
            mappings[41] = EntityType.Fireball;
            mappings[42] = EntityType.FireworkRocket;
            mappings[43] = EntityType.FishingBobber;
            mappings[44] = EntityType.Fox;
            mappings[45] = EntityType.Frog;
            mappings[46] = EntityType.FurnaceMinecart;
            mappings[47] = EntityType.Ghast;
            mappings[48] = EntityType.Giant;
            mappings[49] = EntityType.GlowItemFrame;
            mappings[50] = EntityType.GlowSquid;
            mappings[51] = EntityType.Goat;
            mappings[52] = EntityType.Guardian;
            mappings[53] = EntityType.Hoglin;
            mappings[54] = EntityType.HopperMinecart;
            mappings[55] = EntityType.Horse;
            mappings[56] = EntityType.Husk;
            mappings[57] = EntityType.Illusioner;
            mappings[58] = EntityType.Interaction;
            mappings[59] = EntityType.IronGolem;
            mappings[60] = EntityType.Item;
            mappings[61] = EntityType.ItemDisplay;
            mappings[62] = EntityType.ItemFrame;
            mappings[63] = EntityType.LeashKnot;
            mappings[64] = EntityType.LightningBolt;
            mappings[65] = EntityType.Llama;
            mappings[66] = EntityType.LlamaSpit;
            mappings[67] = EntityType.MagmaCube;
            mappings[68] = EntityType.Marker;
            mappings[69] = EntityType.Minecart;
            mappings[70] = EntityType.Mooshroom;
            mappings[71] = EntityType.Mule;
            mappings[72] = EntityType.Ocelot;
            mappings[73] = EntityType.OminousItemSpawner;
            mappings[74] = EntityType.Painting;
            mappings[75] = EntityType.Panda;
            mappings[76] = EntityType.Parrot;
            mappings[77] = EntityType.Phantom;
            mappings[78] = EntityType.Pig;
            mappings[79] = EntityType.Piglin;
            mappings[80] = EntityType.PiglinBrute;
            mappings[81] = EntityType.Pillager;
            mappings[82] = EntityType.PolarBear;
            mappings[83] = EntityType.Potion;
            mappings[84] = EntityType.Pufferfish;
            mappings[85] = EntityType.Rabbit;
            mappings[86] = EntityType.Ravager;
            mappings[87] = EntityType.Salmon;
            mappings[88] = EntityType.Sheep;
            mappings[89] = EntityType.Shulker;
            mappings[90] = EntityType.ShulkerBullet;
            mappings[91] = EntityType.Silverfish;
            mappings[92] = EntityType.Skeleton;
            mappings[93] = EntityType.SkeletonHorse;
            mappings[94] = EntityType.Slime;
            mappings[95] = EntityType.SmallFireball;
            mappings[96] = EntityType.Sniffer;
            mappings[97] = EntityType.SnowGolem;
            mappings[98] = EntityType.Snowball;
            mappings[99] = EntityType.SpawnerMinecart;
            mappings[100] = EntityType.SpectralArrow;
            mappings[101] = EntityType.Spider;
            mappings[102] = EntityType.Squid;
            mappings[103] = EntityType.Stray;
            mappings[104] = EntityType.Strider;
            mappings[105] = EntityType.Tadpole;
            mappings[106] = EntityType.TextDisplay;
            mappings[107] = EntityType.Tnt;
            mappings[108] = EntityType.TntMinecart;
            mappings[109] = EntityType.TraderLlama;
            mappings[110] = EntityType.Trident;
            mappings[111] = EntityType.TropicalFish;
            mappings[112] = EntityType.Turtle;
            mappings[113] = EntityType.Vex;
            mappings[114] = EntityType.Villager;
            mappings[115] = EntityType.Vindicator;
            mappings[116] = EntityType.WanderingTrader;
            mappings[117] = EntityType.Warden;
            mappings[118] = EntityType.WindCharge;
            mappings[119] = EntityType.Witch;
            mappings[120] = EntityType.Wither;
            mappings[121] = EntityType.WitherSkeleton;
            mappings[122] = EntityType.WitherSkull;
            mappings[123] = EntityType.Wolf;
            mappings[124] = EntityType.Zoglin;
            mappings[125] = EntityType.Zombie;
            mappings[126] = EntityType.ZombieHorse;
            mappings[127] = EntityType.ZombieVillager;
            mappings[128] = EntityType.ZombifiedPiglin;
            mappings[129] = EntityType.Player;
            mappings[130] = EntityType.FishingBobber;
        }

        protected override Dictionary<int, EntityType> GetDict()
        {
            return mappings;
        }
    }
}
