using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Weapons.Gloves
{
    public class FasterSnowballGlove : SnowballGloves
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a snowball glove");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.crit = 0;
            item.width = 28;
            item.height = 26;

            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = Item.sellPrice(silver: 130);
            item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.shoot = 1;
            item.shootSpeed = 8;
            item.ranged = true;
            item.useAmmo = AmmoID.Snowball;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SnowballGlove>(), 1);
            recipe.AddIngredient(ItemID.SkeletronHand, 1);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override int DustsNumber()
        {
            return 10;
        }
    }
}