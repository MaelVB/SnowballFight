using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Gloves
{
    public class SnowballGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a snowball glove");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.crit = -2;
            item.width = 28;
            item.height = 26;

            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.shoot = 1;
            item.shootSpeed = 4;
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

        /**
        * My item has the noUseGraphic property because I don't want it to be displayed.
        * But because of this property I can't call the method MeleeEffects.
        * So, in order to have an effect when I use my item, I call the OnConsummeAmmo method.
        */
        public override void OnConsumeAmmo(Player player) {
            const int NUM_DUSTS = 5;
            float posX = player.position.X;
            float posY = player.position.Y;
            for (int i = 0; i < NUM_DUSTS; i++)
            {
                Dust.NewDust(new Vector2(posX, posY), item.width, item.height, 192, 0f, 0f, 50, new Color(255,255,255));
                posX--;
                posY--;
            }
		}
    }
}