﻿using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using totk.Content.Items.Materials;
using totk.Content.Rarities;
using totk.Content.Projectiles.Arrows;

namespace totk.Content.Items.Arrows
{
    public class DazzleFruitArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Dazzle Fruit Arrow");
            // Tooltip.SetDefault("A Wooden Arrow fused with a Dazzle Fruit.");
        }

        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 20;
            Item.height = 40;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1.5f;
            Item.value = 10;
            Item.rare = ModContent.RarityType<FusedRarity>();
            Item.shoot = ModContent.ProjectileType<DazzleFruitArrowProjectile>();
            Item.shootSpeed = 18f;
            Item.ammo = AmmoID.Arrow;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 1)
                .AddIngredient(ModContent.ItemType<DazzleFruit>(), 1)
                .Register();
        }
    }
}