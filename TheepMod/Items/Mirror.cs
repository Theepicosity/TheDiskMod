using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class Mirror : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hand Mirror");
			Tooltip.SetDefault("'This one isn't made of magic'");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 14;
			item.material = true;
			item.maxStack = 99;
			item.value = 8000;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(75, 5);
			recipe.AddTile(16);
			recipe.SetResult(50);
			recipe.AddRecipe();
		}
	}
}