using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class MuddleBudSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.GiantBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.LightMummy)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 10));
            }
            if (npc.type == NPCID.Clown)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 8));
            }
            if (npc.type == NPCID.BrainScrambler)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 8));
            }
            if (npc.type == NPCID.BrainofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 75));
            }
            if (npc.type == NPCID.Creeper)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 5));
            }
            if (npc.type == NPCID.DesertGhoulHallow)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MuddleBud>(), 8));
            }
        }
    }
}