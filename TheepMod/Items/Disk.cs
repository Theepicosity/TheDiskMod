using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class Disk : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("To be used with the Disk Gun");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.ranged = true;
			item.width = 14;
			item.height = 14;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 0f;
			item.value = 0;
			item.rare = 0;
			item.shoot = mod.ProjectileType("TestDiskProj");
			item.ammo = item.type;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}