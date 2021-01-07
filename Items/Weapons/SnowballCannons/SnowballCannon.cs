using SnowballFight.Items.Weapons.SolidifiedSnowballs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.SnowballCannons
{
    public class SnowballCannon : GlobalItem
    {
		public override void SetDefaults(Item item) {
			/* What you can't throw by hand because it slips or sticks, your snowball cannon can.
			However, it cannot use unsolidified snowballs, otherwise they will disintegrate. That makes sense. */
			if (item.type == ItemID.SnowballCannon) {
				item.useAmmo = ModContent.ItemType<SolidifiedSnowball>();
			}
		}
    }
}