using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Projectiles.Snowballs
{
    public class BigSnowballProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A big but slower snowball");
        }

        public override void SetDefaults()
        {
            projectile.damage = 20;
            projectile.knockBack = 6.5f;
            
            projectile.width = 30;
            projectile.height = 30;

            projectile.aiStyle = 2;
            projectile.ranged = true;
            projectile.friendly = true;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Item51, projectile.position);

            const int NUM_DUSTS = 20;
            float posX = projectile.position.X;
            float posY = projectile.position.Y;
            for (int i = 0; i < NUM_DUSTS; i++)
            {
                // 51, 76, 192
                Dust.NewDust(new Vector2(posX, posY), projectile.width, projectile.height, 192);
                posX--;
                posY--;
            }

            return true;
        }
    }
}