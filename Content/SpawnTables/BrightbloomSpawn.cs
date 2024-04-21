using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class BrightbloomSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BlueJellyfish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.SporeBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 1));
            }
            if (npc.type == NPCID.SporeSkeleton)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 3));
            }
            if (npc.type == NPCID.ZombieMushroom)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 3));
            }
            if (npc.type == NPCID.ZombieMushroomHat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrightbloomSeed>(), 3));
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
        }
    }
}