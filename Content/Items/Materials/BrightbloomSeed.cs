using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using totk.Content.Tiles;

namespace totk.Content.Items.Materials
{
    public class BrightbloomSeed : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Tooltip.SetDefault("Woah! It glows!");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.WaterTorches[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.flame = true;
            Item.noWet = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Brightbloom>();
            Item.width = 10;
            Item.height = 12;
            Item.value = 50;
            Item.value = Item.buyPrice(0, 0, 0, 10);
        }

        public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
        {
            itemGroup = ContentSamples.CreativeHelper.ItemGroup.Torches;
        }

        public override void PostUpdate()
        {
            if (!Item.wet)
            {
                Lighting.AddLight(Item.Center, 1f, 1f, 1f);
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Zonaite>(), 3)
                .AddTile(ModContent.TileType<Construct>())
                .Register();
        }
    }
}