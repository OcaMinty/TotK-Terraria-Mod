using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using totk.Content.Projectiles.Consumables;
using totk.Content.Tiles;

namespace totk.Content.Items.Materials
{
    public class MuddleBud : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<MuddleBudProjectile>();
            Item.width = 8;
            Item.height = 28;
            Item.consumable = true;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 40;
            Item.useTime = 40;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = Item.buyPrice(0, 0, 1, 50);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 9999;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Zonaite>(), 30)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
        }
    }
}