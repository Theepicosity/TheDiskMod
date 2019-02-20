using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class AirPellet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("To be used with the Airgun");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 0f;
			item.value = 6;
			item.rare = 0;
			item.shoot = mod.ProjectileType("AirPelletProj");
			item.ammo = item.type;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}