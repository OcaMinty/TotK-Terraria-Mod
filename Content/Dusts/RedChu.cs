using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace totk.Content.Dusts
{
    public class RedChu : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.frame = new Rectangle(0, 0, 100, 100);
            // If our texture had 3 different dust on top of each other (a 30x90 pixel image), we might do this:
            // dust.frame = new Rectangle(0, Main.rand.Next(3) * 30, 30, 30);
            dust.scale = 0f;
        }

        public override bool Update(Dust dust)
        {
            // Move the dust based on its velocity and reduce its size to then remove it, as the 'return false;' at the end will prevent vanilla logic.
            dust.position += dust.velocity * 4f;
            float light = 0.35f * dust.scale;

            Lighting.AddLight(dust.position, light, light, light);

            dust.scale += 0.5f;
            if (dust.scale > 4f)
            {
                dust.active = false;
            }

            return false;
        }
    }
}