using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class PuffshroomSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Antlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.WalkingAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.GiantFlyingAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.GiantWalkingAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.LarvaeAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.GiantWormHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 1));
            }
            if (npc.type == NPCID.SandSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 3));
            }
            if (npc.type == NPCID.TombCrawlerHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.DesertBeast)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 10));
            }
            if (npc.type == NPCID.DiggerHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 1));
            }
        }
    }
}