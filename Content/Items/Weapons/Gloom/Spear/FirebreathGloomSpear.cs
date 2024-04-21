﻿using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using totk.Content.Items.Materials;
using totk.Content.Tiles;
using totk.Content.Rarities;
using totk.Content.Projectiles.Spears.Gloom;

namespace totk.Content.Items.Weapons.Gloom.Spear
{
    public class FirebreathGloomSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Fire-breath Gloom Spear");
            // Tooltip.SetDefault("A Gloom Spear fused with a Fire-breath Lizalfos Horn");

            ItemID.Sets.SkipsInitialUseSound[Item.type] = true; // This skips use animation-tied sound playback, so that we're able to make it be tied to use time instead in the UseItem() hook.
            ItemID.Sets.Spears[Item.type] = true; // This allows the game to recognize our new item as a spear.
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            // Use Properties
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.useAnimation = 10; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useTime = 35; // The length of the item's use time in ticks (60 ticks == 1 second.)
            Item.UseSound = SoundID.Item1; // The sound that this item plays when used.
            Item.autoReuse = true; // Allows the player to hold click to automatically use the item again. Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

            // Weapon Properties
            Item.damage = 175;
            Item.knockBack = 1f;
            Item.noUseGraphic = true; // When true, the item's sprite will not be visible while the item is in use. This is true because the spear projectile is what's shown so we do not want to show the spear sprite as well.
            Item.DamageType = DamageClass.Melee;
            Item.noMelee = true; // Allows the item's animation to do damage. This is important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.

            // Projectile Properties
            Item.shootSpeed = 5f; // The speed of the projectile measured in pixels per frame.
            Item.shoot = ModContent.ProjectileType<FirebreathGloomSpearProjectile>(); // The projectile that is fired from this weapon
            Item.value = Item.buyPrice(0, 0, 0, 0);

            Item.rare = ModContent.RarityType<FusedRarity>();
        }

        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }

        public override bool? UseItem(Player player)
        {
            // Because we're skipping sound playback on use animation start, we have to play it ourselves whenever the item is actually used.
            if (!Main.dedServ && Item.UseSound.HasValue)
            {
                SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
            }

            return null;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
               .AddIngredient(ModContent.ItemType<GloomSpear>(), 1)
               .AddIngredient(ModContent.ItemType<FireLizalfosHorn>(), 1)
               .Register();
        }
    }
}