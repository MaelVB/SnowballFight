using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SnowballFight.Items.Armor.SnowOutlawArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class SnowOutlawHood : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Snow Ninja Hood");
			Tooltip.SetDefault("For Snowball Gloves stuff"
				+ "\n3% increased ranged crit chance");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player) {
			player.rangedCrit += 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<SnowOutlawLongcoat>() && legs.type == ModContent.ItemType<SnowOutlawPants>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "2% increased Snowball gloves ranged crit chance"
				+ "\nIncreases Snowball minion damage by 5%"
				+ "\n10% increased movement speed when in Snow or Ice Biome";
			player.rangedCrit += 2; // Put condition to increase only snowball gloves
			if (player.ZoneSnow) player.moveSpeed += 0.10f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EskimoHood, 1);
			recipe.AddIngredient(ItemID.NinjaHood, 1);
			recipe.AddIngredient(ItemID.Silk, 8);
			// recipe.AddIngredient(ItemID.FlinxFur, 6);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}