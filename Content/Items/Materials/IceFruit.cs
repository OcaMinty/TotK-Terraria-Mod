using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;
using totk.Content.Tiles;
using totk.Content.Projectiles.Consumables;

namespace totk.Content.Items.Materials
{
    public class IceFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<IceFruitProjectile>();
            Item.width = 8;
            Item.height = 28;
            Item.consumable = true;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 40;
            Item.useTime = 40;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = Item.buyPrice(0, 0, 0, 20);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 9999;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Zonaite>(), 5)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
        }
    }
}