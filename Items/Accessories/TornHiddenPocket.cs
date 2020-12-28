using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Accessories
{
    public class TornHiddenPocket : ModItem
    {
        public override void SetStaticDefaults() {
			Tooltip.SetDefault("Allow two projectiles to be thrown with the snowball gloves");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 22;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 30);
			item.rare = ItemRarityID.Blue;
		}
    }
}