// Max life reduction version.

using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System.Security.Cryptography.X509Certificates;
using System;
using totk.Content.Items.Accessories;

namespace totk.Content.Buffs
{
    public class Gloom : ModBuff
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Gloom");
            // Description.SetDefault("Your maximum life is draining...");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GloomDebuffPlayer>().GloomDebuff = true;
        }
    }

    public class GloomDebuffPlayer : ModPlayer
    {
        public bool GloomDebuff;
        int Restore = 0;

        public override void ResetEffects()
        {
            GloomDebuff = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (!Player.GetModPlayer<GloomLimit>().HasGloomLimit)
            {
                
                if (GloomDebuff)
                {
                    if (Player.lifeRegen > 0)
                        Player.lifeRegen = 0;

                    Player.lifeRegenTime = 0;

                    if (Player.statLifeMax > 20)
                    {
                        Player.statLifeMax -= 1;
                        Restore += 1;
                    }
                    else
                    {
                        Player.statLifeMax = Restore + 20;
                        Player.KillMe(PlayerDeathReason.ByCustomReason(Player.name + " was stripped of all remaining life via their unwise use of Gloom."), 5000, 1);
                        Restore = 0;
                    }
                }
            } else
            {

            }
        }
    }
}