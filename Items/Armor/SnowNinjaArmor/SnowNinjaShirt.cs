using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SnowballFight.Items.Armor.SnowNinjaArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class SnowNinjaShirt : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Snow Ninja Shirt");
			Tooltip.SetDefault("For Snowball Gloves stuff"
				+ "\n3% increased ranged crit chance"
				+ "\nIncreases your max number of minions by 1");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player) {
			player.rangedCrit += 3;
			player.maxMinions += 1;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EskimoCoat, 1);
			recipe.AddIngredient(ItemID.NinjaShirt, 1);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			// recipe.AddIngredient(ItemID.FlinxFur, 8);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EskimoCoat, 1);
			recipe.AddIngredient(ItemID.NinjaShirt, 1);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			// recipe.AddIngredient(ItemID.FlinxFur, 8);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}