using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace totk.Content.Projectiles.Arrows
{
    public class AncientArrowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ancient Arrow");
        }

        public override void SetDefaults()
        {
            Projectile.width = 20;
            Projectile.height = 40;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;

            AIType = ProjectileID.WoodenArrowFriendly;
        }

        public override void AI()
        {
            // The projectile is in the midst of exploding during the last 3 updates.
            if (Projectile.owner == Main.myPlayer && Projectile.timeLeft <= 3)
            {

            }
            else
            {
                // Smoke and fuse dust spawn. The position is calculated to spawn the dust directly on the fuse.
                if (Main.rand.NextBool())
                {
                    Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.BlueTorch, 0f, 0f, 100, default, 1f);

                    dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.CursedTorch, 0f, 0f, 100, default, 1f);
                    dust.scale = 1f + Main.rand.Next(5) * 0.1f;
                    dust.noGravity = true;
                    dust.position = Projectile.Center;
                }
            }
        }
        public override void Kill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item20, Projectile.position);

            for (int i = 0; i < 20; i++)
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.BlueTorch, 0f, 0f, 100, default, 3f);
                dust.noGravity = true;
                dust.velocity *= 3f;
                dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.BlueTorch, 0f, 0f, 100, default, 2f);
                dust.noGravity = true;
                dust.velocity *= 1.5f;
            }
        }
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            if(target.boss == false)
            {
                for (int i = 0; i < 80; i++)
                {
                    Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.BlueTorch, 0f, 0f, 100, default, 3f);
                    dust.noGravity = true;
                    dust.velocity *= 10f;
                    dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.BlueTorch, 0f, 0f, 100, default, 2f);
                    dust.noGravity = true;
                    dust.velocity *= 5f;
                    dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.CursedTorch, 0f, 0f, 100, default, 1f);
                    dust.noGravity = true;
                    dust.velocity *= 1.5f;
                }

                target.aiStyle = 0;
                target.color = Color.Cyan;
                target.active = false;
            }
        }
    }
}