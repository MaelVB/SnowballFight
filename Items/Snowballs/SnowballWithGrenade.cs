using SnowballFight.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Snowballs
{
    public class SnowballWithGrenade : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A snowball with a stone");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.knockBack = 8.0f;

            item.width = 20;
            item.height = 20;

            item.ranged = true;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;

            item.value = 75;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;

            item.shoot = ModContent.ProjectileType<SnowballWithGrenadeProjectile>();
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
            recipe.AddIngredient(ItemID.Grenade, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}