using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using totk.Content.Items.Weapons.Stick.Thick;
using totk.Content.Items.Materials;
using totk.Content.Projectiles.Whips;
using totk.Content.Rarities;

namespace totk.Content.Items.Weapons.Stick.Whips
{
    public class ThickStickWhip : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // Tooltip.SetDefault("A Thick Stick fused with a Lizalfos Tail."); // The (English) text shown below your weapon's name.
        }

        public override void SetDefaults()
        {
            // This method quickly sets the whip's properties.
            // Mouse over to see its parameters.
            Item.DefaultToWhip(ModContent.ProjectileType<ThickStickWhipProjectile>(), 20, 2, 4);

            Item.shootSpeed = 4;
            Item.rare = ModContent.RarityType<FusedRarity>();
            Item.damage = 11;

            Item.channel = true;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<ThickStick>(), 1)
                .AddIngredient(ModContent.ItemType<LizalfosTail>(), 1)
                .Register();
        }

        // Makes the whip receive melee prefixes
        public override bool MeleePrefix()
        {
            return true;
        }
    }
}