using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class Quilt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Quilt");
			Tooltip.SetDefault("Allows you to fly for a short period of time");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 40000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 30;
		}
		
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 1f;
			acceleration *= 1f;
		}
	}
}