using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class DazzleFruitSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BlueJellyfish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.UndeadMiner)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.AnglerFish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.Pixie)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 3));
            }
            if (npc.type == NPCID.Ghost)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 2));
            }
            if (npc.type == NPCID.GraniteFlyer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 5));
            }
            if (npc.type == NPCID.IceSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.SpikedIceSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.GreenJellyfish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.PinkJellyfish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.VoodooDemon)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 10));
            }
            if (npc.type == NPCID.Derpling)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 6));
            }
            if (npc.type == NPCID.IchorSticker)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 10));
            }
            if (npc.type == NPCID.IlluminantBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 5));
            }
            if (npc.type == NPCID.IlluminantSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 5));
            }
            if (npc.type == NPCID.LightMummy)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 5));
            }
        }
    }
}