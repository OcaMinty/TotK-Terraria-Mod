using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;
using totk.Content.Items.Accessories;
using totk.Content.Items.Arrows;

namespace totk.Content.SpawnTables
{
    public class AncientArrowSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.CultistBoss)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientArrow>(), 20));
            }
        }
    }
}