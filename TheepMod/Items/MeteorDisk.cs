using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class MeteorDisk : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("To be used with the Disk Gun");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 14;
			item.height = 14;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 0f;
			item.value = 0;
			item.rare = 1;
			item.shoot = mod.ProjectileType("MetDiskProj");
			item.ammo = mod.ItemType("Disk");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar);
			recipe.AddIngredient(mod.ItemType("Disk"), 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}