using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class AidanWeapon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aidan's Airgun");
			Tooltip.SetDefault("Hand made heirloom, only 9 years of crafting experience!");
			Tooltip.SetDefault("'Great for impersonating Aidan!'");
			Tooltip.SetDefault("Hand made heirloom, only 9 years of crafting experience!"
				+ "\n'Great for impersonating Aidan!'");
		}
		public override void SetDefaults()
		{
			item.damage = 67;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 120000;
			item.rare = 5;
			item.UseSound = SoundID.Item63;
			item.maxStack = 1;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 18f;
			item.useAmmo = mod.ItemType("AirPellet");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(549, 10);
			recipe.AddRecipeGroup("Wood", 10);
			recipe.AddRecipeGroup("IronBar", 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
