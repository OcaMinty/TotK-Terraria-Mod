using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;
using totk.Content.Tiles;

namespace totk.Content.Items.Materials
{
    public class FireKeeseEyeball : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 28;
            Item.useAnimation = 40;
            Item.useTime = 40;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = Item.buyPrice(0, 0, 0, 40);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 9999;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Zonaite>(), 10)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
        }
    }
}