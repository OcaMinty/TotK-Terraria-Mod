using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Security.Cryptography;
using totk.Content.Items.Materials;

namespace totk.Content.SpawnTables
{
    public class IceKeeseEyeballSpawn : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.IceBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceKeeseEyeball>(), 1));
            }
        }
    }
}