using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items
{
    public class SnowballGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a snowball glove.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.width = 24;
            item.height = 26;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.shoot = 1;
            item.shootSpeed = 8;
            item.ranged = true;
            item.useAmmo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AleThrowingGlove, 1);
            // recipe.AddIngredient(ItemID.FlinxFur, 5); // WAITING FOR TMODLOADER UPDATE FOR 1.4.1
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory (Player player)
        {

        }
    }
}