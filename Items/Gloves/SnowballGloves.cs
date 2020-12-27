using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Gloves
{
    public class SnowballGloves : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a snowball glove");
        }

        public virtual int DustsNumber()
        {
            return 5;
        }
        
        /**
        * My item has the noUseGraphic property because I don't want it to be displayed.
        * But because of this property I can't call the method MeleeEffects.
        * So, in order to have an effect when I use my item, I call the Shoot method.
        */
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int dustsNumber = this.DustsNumber();
            float posX = player.position.X;
            float posY = player.position.Y;
            for (int i = 0; i < dustsNumber; i++)
            {
                Dust.NewDust(new Vector2(posX, posY), item.width, item.height, 192, 0f, 0f, 50, new Color(255,255,255));
                posX--;
                posY--;
            }

            if (player.GetModPlayer<SnowballFightPlayer>().gloveAccessories.Contains("HiddenGlovePocket"))
            {
                int numberProjectiles = 1;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX*0.8f, speedY*0.8f).RotatedByRandom(MathHelper.ToRadians(15));
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }

            return true;
		}
    }
}