using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class PearlwoodWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pearlwood Wand");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.noMelee = true;
			item.magic = true;
			item.width = 24;
			item.height = 28;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 0;
			item.mana = 5;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item9;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType<Proj.PearlwoodProj>();
			item.shootSpeed = 8f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(502, 5);
			recipe.AddIngredient(621, 12);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
