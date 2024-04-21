using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class ZonaiteSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Hellbat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 3));
            }
            if (npc.type == NPCID.LavaSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 3));
            }
            if (npc.type == NPCID.FireImp)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 5));
            }
            if (npc.type == NPCID.Demon)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 10));
            }
            if (npc.type == NPCID.VoodooDemon)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 10));
            }
            if (npc.type == NPCID.Lavabat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 10));
            }
            if (npc.type == NPCID.RedDevil)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 15));
            }
            if (npc.type == NPCID.HellButterfly)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 1));
            }
            if (npc.type == NPCID.Lavafly)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 1));
            }
            if (npc.type == NPCID.MagmaSnail)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zonaite>(), 1));
            }
        }
    }
}