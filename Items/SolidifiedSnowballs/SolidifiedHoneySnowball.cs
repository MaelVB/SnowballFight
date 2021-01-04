using SnowballFight.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.SolidifiedSnowballs
{
    public class SolidifiedHoneySnowball : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A solidified snowball. Ammo for the snowball cannon and snowball launcher.");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.knockBack = 7f;
            
            item.width = 16;
            item.height = 16;

            item.ranged = true;

            item.value = 0;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;

			item.shoot = ModContent.ProjectileType<Projectiles.SolidifiedSnowballs.SolidifiedHoneySnowballProjectile>();
            item.shootSpeed = 12f;
            item.maxStack = 999;
			item.consumable = true;

            item.ammo = ModContent.ItemType<SolidifiedSnowball>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SolidifiedSnowball>(), 3);
            recipe.AddIngredient(ItemID.HoneyBlock, 1);
            recipe.AddIngredient(ItemID.CrispyHoneyBlock, 1);
            recipe.AddTile(TileID.Solidifier);
            recipe.AddTile(TileID.HoneyDispenser);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}