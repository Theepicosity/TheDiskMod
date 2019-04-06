using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class ElectricTrap2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Electric Mind Trap");
		}
		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 12;
			item.height = 12;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.value = 10000;
			item.maxStack = 999;
			item.rare = 0;
			item.createTile = mod.TileType("ElectricTrapTile");
			item.placeStyle = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.consumable = true;
			item.mech = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TrapPart"), 1);
			recipe.AddIngredient(2860, 100);
			recipe.AddIngredient(530, 20);
			recipe.AddTile(283);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
