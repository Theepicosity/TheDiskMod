using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class Basket : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Basket");
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
			item.createTile = mod.TileType("BasketTile");
			item.useTurn = true;
			item.autoReuse = true;
			item.consumable = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1727, 20);
			recipe.AddTile(86);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
