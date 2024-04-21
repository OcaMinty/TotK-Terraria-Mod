using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using System.Security.Cryptography.X509Certificates;
using totk.Content.Rarities;
using totk.Content.Buffs;
using totk.Content.Items.Materials;
using totk.Content.Tiles;
using totk.Content.Items.Weapons.Stick.Wooden;

namespace totk.Content.Items.Weapons.Stick.Light
{
    public class WoodenLightShardStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Wooden Light Shard Stick");
            // Tooltip.SetDefault("A Wooden Stick fused with a Shard of Light."); // The (English) text shown below your weapon's name.

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.useStyle = ItemUseStyleID.Swing; // The useStyle of the Item.
            Item.useTime = 20; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
            Item.useAnimation = 20; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
            Item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button.

            Item.DamageType = DamageClass.Melee; // Whether your item is part of the melee class.
            Item.damage = 14; // The damage your item deals.
            Item.knockBack = 7; // The force of knockback of the weapon. Maximum is 20
            Item.crit = 5; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.

            Item.value = Item.buyPrice(copper: 0); // The value of the weapon in copper coins.
            Item.UseSound = SoundID.Item1; // The sound when the weapon is being used.
            Item.rare = ModContent.RarityType<FusedRarity>();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                // Emit dusts when the sword is swung
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Sand);
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.CursedTorch);
            }
        }
        public override void AddRecipes()
        {
            CreateRecipe()
               .AddIngredient(ModContent.ItemType<WoodenStick>(), 1)
               .AddIngredient(ModContent.ItemType<ShardofLight>(), 1)
               .Register();
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            player.statLife += 5;
        }
    }
}