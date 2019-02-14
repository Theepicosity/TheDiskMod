using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class SlimePop : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Pop");
			Tooltip.SetDefault("Makes you feel slimy");
		}
		public override void SetDefaults()
		{
			item.maxStack = 30;
			item.useTurn = true;
			item.width = 14;
			item.height = 24;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 2;
			item.consumable = true;
			item.value = 1250;
			item.rare = 1;
			item.healLife = 80;
			item.potion = true;
			item.UseSound = SoundID.Item2;
			item.buffType = 137;
			item.buffTime = 3600;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 3);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
