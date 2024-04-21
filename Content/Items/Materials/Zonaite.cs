using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;
using totk.Content.Tiles;

namespace totk.Content.Items.Materials
{
    public class Zonaite : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 28;
            Item.consumable = true;
            Item.useAnimation = 40;
            Item.useTime = 40;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = Item.buyPrice(0, 0, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 99999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(3)
                .AddIngredient(ItemID.CopperOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(4)
                .AddIngredient(ItemID.TinOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(5)
                .AddIngredient(ItemID.IronOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(8)
                .AddIngredient(ItemID.LeadOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(8)
                .AddIngredient(ItemID.SilverOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(12)
                .AddIngredient(ItemID.TungstenOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(15)
                .AddIngredient(ItemID.GoldOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(23)
                .AddIngredient(ItemID.PlatinumOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(50)
                .AddIngredient(ItemID.DemoniteOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(65)
                .AddIngredient(ItemID.CrimtaneOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(25)
                .AddIngredient(ItemID.CobaltOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(45)
                .AddIngredient(ItemID.PalladiumOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(55)
                .AddIngredient(ItemID.MythrilOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(65)
                .AddIngredient(ItemID.OrichalcumOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(75)
                .AddIngredient(ItemID.AdamantiteOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(85)
                .AddIngredient(ItemID.TitaniumOre)
                .AddTile(TileID.Furnaces)
                .Register();
            CreateRecipe(75)
                .AddIngredient(ItemID.ChlorophyteOre)
                .AddTile(TileID.Furnaces)
                .Register();



            CreateRecipe(6)
                .AddIngredient(ItemID.CopperOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(8)
                .AddIngredient(ItemID.TinOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(10)
                .AddIngredient(ItemID.IronOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(16)
                .AddIngredient(ItemID.LeadOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(16)
                .AddIngredient(ItemID.SilverOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(24)
                .AddIngredient(ItemID.TungstenOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(30)
                .AddIngredient(ItemID.GoldOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(46)
                .AddIngredient(ItemID.PlatinumOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(100)
                .AddIngredient(ItemID.DemoniteOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(130)
                .AddIngredient(ItemID.CrimtaneOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(50)
                .AddIngredient(ItemID.CobaltOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(90)
                .AddIngredient(ItemID.PalladiumOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(110)
                .AddIngredient(ItemID.MythrilOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(130)
                .AddIngredient(ItemID.OrichalcumOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(150)
                .AddIngredient(ItemID.AdamantiteOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(170)
                .AddIngredient(ItemID.TitaniumOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
            CreateRecipe(150)
                .AddIngredient(ItemID.ChlorophyteOre)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
        }
    }
}