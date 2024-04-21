using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using totk.Content.Items.Materials;
using totk.Content.Rarities;
using totk.Content.Projectiles.Arrows;

namespace totk.Content.Items.Arrows
{
    public class BombFlowerArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Bomb Flower Arrow");
            // Tooltip.SetDefault("A Wooden Arrow fused with a Bomb Flower.\nIt mysteriously still functions, even though it rolls through the skies.");
        }

        public override void SetDefaults()
        {
            Item.damage = 110;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 20;
            Item.height = 40;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1.5f;
            Item.value = 10;
            Item.rare = ModContent.RarityType<FusedRarity>();
            Item.shoot = ModContent.ProjectileType<BombFlowerArrowProjectile>();
            Item.shootSpeed = 18f;
            Item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 1)
                .AddIngredient(ModContent.ItemType<BombFlower>(), 1)
                .Register();
        }
    }
}