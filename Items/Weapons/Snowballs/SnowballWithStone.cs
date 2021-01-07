using SnowballFight.Projectiles.Snowballs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Weapons.Snowballs
{
    public class SnowballWithStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A snowball with a stone");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.knockBack = 6.0f;
            
            item.width = 20;
            item.height = 20;

            item.ranged = true;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;

            item.value = 0;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;

            item.shoot = ModContent.ProjectileType<SnowballWithStoneProjectile>();
            item.shootSpeed = 8f;
            item.consumable = true;
            item.maxStack = 999;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.ammo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Snowball, 2);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}