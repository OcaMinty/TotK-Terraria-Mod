/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Content;

namespace ExampleMod.Content.NPCs
{
    // Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
    public class Keese : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Keese");

            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.CaveBat];
            // When making the sprite for this make sure it matches to vanilla.
        }

        public override void SetDefaults()
        {
            NPC.width = 18;
            NPC.height = 40;
            NPC.damage = 13;
            NPC.defense = 6;
            NPC.lifeMax = 16;
            NPC.HitSound = SoundID.NPCHit1;
            // NPC.DeathSound = SoundID.i forgot; 
            // Whicher sound ID is bat death. They should really name these.
            NPC.value = 60f;
            NPC.knockBackResist = 0.5f;
            NPC.aiStyle = 14;

            AIType = NPCID.CaveBat; 
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            // for drops:
            // npcLoot.Add(ItemDropRule.Common(ItemID.itemname, 100));
            // npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<itemname>(), 100));
            // 1% chance to drop [item]
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.2f; // Spawn with 1/5th the chance of a regular zombie.
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
        }
    }
}*/