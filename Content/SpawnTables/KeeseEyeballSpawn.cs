using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class KeeseEyeballSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.DemonEye)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.WanderingEye)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.BloodSquid)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 4));
            }

            if (npc.type == NPCID.Drippler)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 4));
            }

            if (npc.type == NPCID.EyeballFlyingFish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.Deerclops)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.EaterofWorldsHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 36));
            }

            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.Retinazer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.Spazmatism)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.WallofFleshEye)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.Creeper)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.ServantofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.ServantofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.BigMimicCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.SeekerHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.SeekerBody)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.CaveBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.GiantBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeeseEyeball>(), 1));
            }
        }
    }
}