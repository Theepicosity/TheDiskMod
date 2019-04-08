using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class DisposableSpark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Disposable Spark");
			Tooltip.SetDefault("Provides light");
		}
		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 24;
			item.height = 28;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.value = 300;
			item.maxStack = 99;
			item.rare = 1;
			item.UseSound = SoundID.Item4;
			item.autoReuse = false;
			item.consumable = true;
			item.shoot = mod.ProjectileType<Proj.DispSparkProj>();
			item.shootSpeed = 0f;
		}
		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			wetTorch = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(183, 2);
			recipe.AddIngredient(23, 10);
			recipe.AddTile(77);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}
