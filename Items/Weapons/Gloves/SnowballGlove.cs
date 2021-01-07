using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Weapons.Gloves
{
    public class SnowballGlove : SnowballGloves
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a snowball glove");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.crit = -2;
            item.width = 28;
            item.height = 26;

            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = Item.sellPrice(silver: 20);
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.shoot = 1;
            item.shootSpeed = 4;
            item.ranged = true;
            item.useAmmo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AleThrowingGlove, 1);
            // recipe.AddIngredient(ItemID.FlinxFur, 5); // WAITING FOR TMODLOADER UPDATE FOR 1.4.1
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}