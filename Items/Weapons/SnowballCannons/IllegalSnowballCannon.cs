using SnowballFight.Items.Weapons.SolidifiedSnowballs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.Items.Weapons.SnowballCannons
{
    public class IllegalSnowballCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is an improved version of the snowball cannon");
        }

        public override void SetDefaults()
        {
            item.damage = 13;
            item.crit = 1;
            item.width = 50;
            item.height = 26;

            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = Item.sellPrice(gold: 6);
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.noMelee = true;

            item.shoot = 1;
            item.shootSpeed = 15;
            item.ranged = true;
            item.useAmmo = ModContent.ItemType<SolidifiedSnowball>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SnowballCannon, 1);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.Obsidian, 5);
            recipe.AddIngredient(ItemID.SnowCloudBlock, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}