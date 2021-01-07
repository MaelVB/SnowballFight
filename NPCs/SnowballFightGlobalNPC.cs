using SnowballFight.Items.Accessories;
using SnowballFight.Items.Weapons.SolidifiedSnowballs;
using SnowballFight.Items.Weapons.SnowballCannons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowballFight.NPCs
{
	public class SnowballFightGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot) {
			if (type == NPCID.Clothier) {
				/* This is the way I've found to update the shop of my NPC according to the biome (the player zone) */
				NPC npc = new NPC();
				int k = 0;
				while (npc.type != NPCID.Clothier) {
					npc = Main.npc[k];
					k++;
				}
				// TODO : tests between this method...
				if(Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRockLayerHeight) {
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<TornHiddenPocket>());
					nextSlot++;
				}
			} else if (type == NPCID.ArmsDealer && (Main.LocalPlayer.HasItem(ItemID.SnowballCannon) || Main.LocalPlayer.HasItem(ModContent.ItemType<IllegalSnowballCannon>()))) {
				NPC npc = new NPC();
				int k = 0;
				while (npc.type != NPCID.ArmsDealer) {
					npc = Main.npc[k];
					k++;
				}
				// ...and this
				if(Main.LocalPlayer.ZoneSnow) {
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<SolidifiedSnowball>());
					nextSlot++;
				}
			} else if (type == NPCID.SkeletonMerchant && Main.bloodMoon) {
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<TornHiddenPocket>());
				nextSlot++;
			}
		}
	}
}
