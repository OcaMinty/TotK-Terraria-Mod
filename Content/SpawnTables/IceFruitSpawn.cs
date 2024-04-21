using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class IceFruitSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.IceSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 3));
            }
            if (npc.type == NPCID.IceBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 1));
            }
            if (npc.type == NPCID.SpikedIceSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 4));
            }
            if (npc.type == NPCID.IceElemental)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 5));
            }
            if (npc.type == NPCID.IceMimic)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 6));
            }
            if (npc.type == NPCID.IceTortoise)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 3));
            }
            if (npc.type == NPCID.IcyMerman)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 5));
            }
            if (npc.type == NPCID.IceGolem)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 10));
            }
            if (npc.type == NPCID.MisterStabby)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 5));
            }
            if (npc.type == NPCID.SnowBalla)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 5));
            }
            if (npc.type == NPCID.SnowmanGangsta)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 5));
            }
            if (npc.type == NPCID.ElfArcher)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 3));
            }
            if (npc.type == NPCID.ElfCopter)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 4));
            }
            if (npc.type == NPCID.Flocko)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 6));
            }
            if (npc.type == NPCID.Yeti)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 10));
            }
            if (npc.type == NPCID.Everscream)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 25));
            }
            if (npc.type == NPCID.IceQueen)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceFruit>(), 85));
            }
        }
    }
}