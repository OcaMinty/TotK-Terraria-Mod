using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using totk.Content.Projectiles.Consumables;
using totk.Content.Tiles;

namespace totk.Content.Items.Materials
{
    public class ShardofLight : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Shard of Light");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<ShardofLightProjectile>();
            Item.width = 8;
            Item.height = 28;
            Item.consumable = true;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 40;
            Item.useTime = 40;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = Item.buyPrice(2, 0, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 99;
        }
        public override void OnConsumeItem(Player player)
        {
            player.statLife += 5;
        }
    }
}