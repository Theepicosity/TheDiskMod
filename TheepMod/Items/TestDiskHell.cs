using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class TestDiskHell : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flame Ripper");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = 30000;
			item.rare = 3;
			item.UseSound = SoundID.Item10;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 28f;
			item.useAmmo = mod.ItemType("Disk");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TestDisk"), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
