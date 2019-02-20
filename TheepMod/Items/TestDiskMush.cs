using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class TestDiskMush : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroomite Shredder");
		}
		public override void SetDefaults()
		{
			item.damage = 48;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = 50000;
			item.rare = 8;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 32f;
			item.useAmmo = mod.ItemType("Disk");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TestDiskHell"), 1);
			recipe.AddIngredient(1552, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
