using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class TrapPart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Advanced Trap Component");
			Tooltip.SetDefault("Used for crafting advanced traps");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.material = true;
			item.maxStack = 999;
			item.value = 20000;
			item.rare = 1;
		}
	}
}