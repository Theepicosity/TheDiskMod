using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class HotAirBalloon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Vessel");
			Tooltip.SetDefault("Summons a rideable hot air balloon mount.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 60000;
			item.rare = 8;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = mod.MountType("HotAirBalloonMount");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Basket"), 1);
			recipe.AddIngredient(mod.ItemType("Quilt"), 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}