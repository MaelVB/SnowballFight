using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SnowballFight.Items.Armor.SnowNinjaArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SnowNinjaPants : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Snow Ninja Pants");
			Tooltip.SetDefault("For Snowball Gloves stuff"
				+ "\n3% increased ranged crit chance"
				+ "\n15% increased movement speed");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.rangedCrit += 3;
			player.moveSpeed += 0.15f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EskimoPants, 1);
			recipe.AddIngredient(ItemID.NinjaPants, 1);
			recipe.AddIngredient(ItemID.Silk, 6);
			// recipe.AddIngredient(ItemID.FlinxFur, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}