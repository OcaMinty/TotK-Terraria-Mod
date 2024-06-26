﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace totk.Content.Buffs.Whips
{
    public class WhipDebuff : ModBuff
    {
        public static readonly int TagDamage = 5;

        public override void SetStaticDefaults()
        {
            // This allows the debuff to be inflicted on NPCs that would otherwise be immune to all debuffs.
            // Other mods may check it for different purposes.
            BuffID.Sets.IsATagBuff[Type] = true;
        }
    }

    public class WhipAdvancedDebuff : ModBuff
    {
        public static readonly int TagDamagePercent = 30;
        public static readonly float TagDamageMultiplier = TagDamagePercent / 100f;

        public override void SetStaticDefaults()
        {
            BuffID.Sets.IsATagBuff[Type] = true;
        }
    }

    public class WhipDebuffNPC : GlobalNPC
    {
        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref NPC.HitModifiers modifiers)
        {
            // Only player attacks should benefit from this buff, hence the NPC and trap checks.
            if (projectile.npcProj || projectile.trap || !projectile.IsMinionOrSentryRelated)
                return;


            // SummonTagDamageMultiplier scales down tag damage for some specific minion and sentry projectiles for balance purposes.
            var projTagMultiplier = ProjectileID.Sets.SummonTagDamageMultiplier[projectile.type];
            if (npc.HasBuff<WhipDebuff>())
            {
                // Apply a flat bonus to every hit
                modifiers.FlatBonusDamage += WhipDebuff.TagDamage * projTagMultiplier;
            }

            // if you have a lot of buffs in your mod, it might be faster to loop over the NPC.buffType and buffTime arrays once, and track the buffs you find, rather than calling HasBuff many times
            if (npc.HasBuff<WhipAdvancedDebuff>())
            {
                // Apply the scaling bonus to the next hit, and then remove the buff, like the vanilla firecracker
                modifiers.ScalingBonusDamage += WhipAdvancedDebuff.TagDamageMultiplier * projTagMultiplier;
                npc.RequestBuffRemoval(ModContent.BuffType<WhipAdvancedDebuff>());
            }
        }
    }
}