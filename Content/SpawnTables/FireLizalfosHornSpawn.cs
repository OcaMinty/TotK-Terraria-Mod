using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class FireLizalfosHornSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.LavaSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.HellArmoredBones)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.Lavabat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.RedDevil)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarCorite)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarCrawltipedeBody)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarCrawltipedeHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarCrawltipedeTail)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarDrakomire)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarDrakomireRider)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarSolenian)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
            if (npc.type == NPCID.SolarSroller)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireLizalfosHorn>(), 1));
            }
        }
    }
}