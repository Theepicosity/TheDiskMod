using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Theepmod.Shop
{
	public class QuiltCrate : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "crate" && arg == 3206)
			{
				if (Main.rand.Next(6) == 0) {
					player.QuickSpawnItem(mod.ItemType("Quilt"));
				}
			}
		}
	}
}