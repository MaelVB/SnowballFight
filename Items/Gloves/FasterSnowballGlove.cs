using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Gloves
{
    public class FasterSnowballGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a snowball glove");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.crit = 0;
            item.width = 28;
            item.height = 26;

            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 65000;
            item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.shoot = 1;
            item.shootSpeed = 8;
            item.ranged = true;
            item.useAmmo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SnowballGlove>(), 1);
            recipe.AddIngredient(ItemID.SkeletronHand, 1);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void OnConsumeAmmo(Player player) {
            const int NUM_DUSTS = 10;
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