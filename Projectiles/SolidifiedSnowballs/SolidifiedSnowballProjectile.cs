using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Projectiles.SolidifiedSnowballs
{
    public class SolidifiedSnowballProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A small but faster snowball");
        }

        public override void SetDefaults()
        {
            projectile.damage = 9;
            projectile.knockBack = 6f;
            
            projectile.width = 16;
            projectile.height = 16;

            projectile.aiStyle = 2;
            projectile.ranged = true;
            projectile.friendly = true;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Item51, projectile.position);

            const int NUM_DUSTS = 5;
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