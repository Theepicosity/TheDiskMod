using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class TestDisk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Disk Gun");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.material = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = 3000;
			item.rare = 1;
			item.UseSound = SoundID.Item10;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = mod.ItemType("Disk");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 10);
			recipe.AddIngredient(324, 1);
			recipe.AddRecipeGroup("IronBar", 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
