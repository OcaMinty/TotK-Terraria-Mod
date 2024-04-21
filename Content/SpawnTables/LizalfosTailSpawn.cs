using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class LizalfosTailSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.FlyingAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.Crimera)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.FireImp)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.GiantFlyingAntlion)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.Hornet)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.Salamander)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.Shark)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.VoodooDemon)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.FlyingSnake)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.GiantTortoise)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.IceTortoise)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.Lihzahrd)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.MossHornet)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.PigronCorruption)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.PigronCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.PigronHallow)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
            if (npc.type == NPCID.RedDevil)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LizalfosTail>(), 1));
            }
        }
    }
}