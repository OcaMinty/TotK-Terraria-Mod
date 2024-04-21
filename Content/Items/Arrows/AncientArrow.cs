using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using totk.Content.Items.Materials;
using totk.Content.Rarities;
using totk.Content.Projectiles.Arrows;

namespace totk.Content.Items.Arrows
{
    public class AncientArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ancient Arrow");
            // Tooltip.SetDefault("A powerful arrow capable of vaporizing your foes.");
        }

        public override void SetDefaults()
        {
            Item.damage = 1000;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 20;
            Item.height = 40;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1.5f;
            Item.value = 10;
            Item.shoot = ModContent.ProjectileType<AncientArrowProjectile>();
            Item.shootSpeed = 18f;
            Item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ModContent.ItemType<AncientArrow>(), 1)
                .AddIngredient(ModContent.ItemType<Zonaite>(), 1000)
                .Register();
        }
    }
}