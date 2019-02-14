using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class CombustionTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of Spontaneous Combustion");
			Tooltip.SetDefault("Instantly sets all enemies around you on fire");
		}
		public override void SetDefaults()
		{
			item.damage = 4;
			item.noMelee = true;
			item.magic = true;
			item.width = 24;
			item.height = 28;
			item.useTime = 30;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.knockBack = 0;
			item.mana = 50;
			item.value = 100000;
			item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType<Proj.CombustionProj>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(547, 20);
			recipe.AddIngredient(531, 1);
			recipe.AddTile(101);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
