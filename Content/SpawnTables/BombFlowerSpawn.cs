using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class BombFlowerSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BlueSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 1));
            }

            if (npc.type == NPCID.GreenSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 1));
            }

            if (npc.type == NPCID.Zombie)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 2));
            }

            if (npc.type == NPCID.KingSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 100));
            }

            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 100));
            }

            if (npc.type == NPCID.PirateDeadeye)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 5));
            }

            if (npc.type == NPCID.YellowSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 1));
            }

            if (npc.type == NPCID.RedSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 1));
            }

            if (npc.type == NPCID.PurpleSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 1));
            }

            if (npc.type == NPCID.Pinky)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 50));
            }

            if (npc.type == NPCID.DemonEye)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 2));
            }

            if (npc.type == NPCID.BigMimicCorruption)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 25));
            }

            if (npc.type == NPCID.BigMimicCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 25));
            }

            if (npc.type == NPCID.Mimic)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 10));
            }

            if (npc.type == NPCID.Clown)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 8));
            }

            if (npc.type == NPCID.DD2KoboldWalkerT2)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 5));
            }

            if (npc.type == NPCID.DD2KoboldWalkerT3)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 10));
            }

            if (npc.type == NPCID.DD2KoboldFlyerT2)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 10));
            }

            if (npc.type == NPCID.DD2KoboldFlyerT3)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 15));
            }

            if (npc.type == NPCID.Psycho)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 5));
            }

            if (npc.type == NPCID.Nailhead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BombFlower>(), 5));
            }
        }
    }
}