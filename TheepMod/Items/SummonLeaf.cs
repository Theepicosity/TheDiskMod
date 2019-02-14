using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class SummonLeaf : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Motivational Leaf");
			Tooltip.SetDefault("20% increased minion damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 40000;
			item.rare = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.minionDamage += 0.2f;
		}
	}
}