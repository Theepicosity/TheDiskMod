using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class BouncySlimePop : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bouncy Slime Pop");
			Tooltip.SetDefault("Makes you feel bouncy!");
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
			item.rare = 2;
			item.healLife = 80;
			item.healMana = 80;
			item.potion = true;
			item.UseSound = SoundID.Item2;
			item.buffType = mod.BuffType("Blocky");
			item.buffTime = 3600;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkGel, 3);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
