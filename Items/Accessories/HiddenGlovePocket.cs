using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Accessories
{
    public class HiddenGlovePocket : ModItem
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

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<SnowballFightPlayer>().gloveAccessories.Add("HiddenGlovePocket");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<TornHiddenPocket>(), 1);
			recipe.AddIngredient(ItemID.Vine, 1);
			recipe.AddIngredient(ItemID.GreenThread, 1);
            recipe.AddIngredient(ItemID.Silk, 1);
			// recipe.AddIngredient(ItemID.FlinxFur, 2); // WAITING FOR TMODLOADER UPDATE FOR 1.4.1
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}