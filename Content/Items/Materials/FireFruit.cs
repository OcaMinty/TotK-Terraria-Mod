﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using totk.Content.Projectiles.Consumables;
using totk.Content.Tiles;

namespace totk.Content.Items.Materials
{
    public class FireFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<FireFruitProjectile>();
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
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Burning, 600);
            target.AddBuff(BuffID.OnFire, 600);
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