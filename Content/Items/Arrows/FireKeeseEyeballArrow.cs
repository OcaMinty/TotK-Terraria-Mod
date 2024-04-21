using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using totk.Content.Items.Materials;
using totk.Content.Rarities;
using totk.Content.Projectiles.Arrows;

namespace totk.Content.Items.Arrows
{
    public class FireKeeseEyeballArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Fire Keese Eyeball Arrow");
            // Tooltip.SetDefault("A Wooden Arrow fused with a Fire Keese Eyeball.");
        }

        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 20;
            Item.height = 40;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 10;
            Item.rare = ModContent.RarityType<FusedRarity>();
            Item.shoot = ModContent.ProjectileType<FireKeeseEyeballArrowProjectile>();
            Item.shootSpeed = 18f;
            Item.ammo = AmmoID.Arrow;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 1)
                .AddIngredient(ModContent.ItemType<FireKeeseEyeball>(), 1)
                .Register();
        }
    }
}