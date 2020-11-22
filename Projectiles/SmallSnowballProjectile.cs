using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Projectiles
{
    public class SmallSnowballProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A small but faster snowball");
        }

        public override void SetDefaults()
        {
            projectile.damage = 4;
            projectile.width = 10;
            projectile.height = 10;

            projectile.aiStyle = 2;
            projectile.ranged = true;
            projectile.friendly = true;
            projectile.knockBack = 3f;
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