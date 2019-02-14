using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class SpeedFeather : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Archery Feather");
			Tooltip.SetDefault("10% increased ranged damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.1f;
		}
	}
}