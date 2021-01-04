using SnowballFight.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.SolidifiedSnowballs
{
    public class SolidifiedSnowball : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A solidified snowball. Ammo for the snowball cannon and snowball launcher.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.knockBack = 6f;
            
            item.width = 16;
            item.height = 16;

            item.ranged = true;

            item.value = 0;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;

			item.shoot = ModContent.ProjectileType<Projectiles.SolidifiedSnowballs.SolidifiedSnowballProjectile>();
            item.shootSpeed = 10.5f;
            item.maxStack = 999;
			item.consumable = true;

            item.ammo = item.type;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Snowball, 1);
            recipe.AddIngredient(ItemID.Gel, 1);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}