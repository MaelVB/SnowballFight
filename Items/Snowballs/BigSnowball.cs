using SnowballFight.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Snowballs
{
    public class BigSnowball : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A small but faster snowball");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.knockBack = 6.5f;
            
            item.width = 30;
            item.height = 30;

            item.ranged = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;

            item.value = 0;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;

            item.shoot = ModContent.ProjectileType<BigSnowballProjectile>();
            item.shootSpeed = 5f;
            item.consumable = true;
            item.maxStack = 999;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.ammo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Snowball, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}