using SnowballFight.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Snowballs
{
    public class SmallSnowball : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A smaller but lighter snowball");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.knockBack = 3f;
            
            item.width = 10;
            item.height = 10;

            item.ranged = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;

            item.value = 0;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;

            item.shoot = ModContent.ProjectileType<SmallSnowballProjectile>();
            item.shootSpeed = 15f;
            item.consumable = true;
            item.maxStack = 999;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.ammo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Snowball, 1);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}