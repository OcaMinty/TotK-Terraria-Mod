using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class FireKeeseEyeballSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Hellbat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireKeeseEyeball>(), 1));
            }

            if (npc.type == NPCID.Lavabat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireKeeseEyeball>(), 1));
            }
        }
    }
}