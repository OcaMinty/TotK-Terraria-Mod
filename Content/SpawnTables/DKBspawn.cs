using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Bows;
using totk.Content.Items.Accessories;

namespace totk.Content.SpawnTables
{
    public class DKBspawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Golem)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DemonKingsBow>(), 1));
            }
        }
    }
}