﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using System.Security.Cryptography.X509Certificates;
using totk.Content.Rarities;
using totk.Content.Buffs;
using Microsoft.Xna.Framework.Graphics;
using totk.Content.Items.Weapons.Stick.Long;

namespace totk.Content.Items.Weapons.Stick.Thick
{
    public class ThickStickLongStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Thick Stick Long Stick");
            // Tooltip.SetDefault("A Thick Stick fused with a Long Stick."); // The (English) text shown below your weapon's name.

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 140;
            Item.height = 140;
            Item.useStyle = ItemUseStyleID.Swing; // The useStyle of the Item.
            Item.useTime = 40; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
            Item.useAnimation = 23; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
            Item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button.

            Item.DamageType = DamageClass.Melee; // Whether your item is part of the melee class.
            Item.damage = 15; // The damage your item deals.
            Item.knockBack = 12; // The force of knockback of the weapon. Maximum is 20
            Item.crit = 4; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.

            Item.value = Item.buyPrice(gold: 0); // The value of the weapon in copper coins.
            Item.UseSound = SoundID.Item1; // The sound when the weapon is being used
            Item.rare = ModContent.RarityType<FusedRarity>();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                // Emit dusts when the sword is swung
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Sand);
            }
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<ThickStick>(), 1)
                .AddIngredient(ModContent.ItemType<LongStick>(), 1)
                .Register();
        }
    }
}