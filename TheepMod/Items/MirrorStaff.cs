using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class MirrorStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shine Mirror");
			Tooltip.SetDefault("Gaze into the mirror and shine");
		}

		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 24;
			item.height = 28;
			item.useTime = 44;
			item.useAnimation = 44;
			item.useStyle = 5;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item6;
			item.autoReuse = false;
			item.buffType = 11;
			item.buffTime = 18000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Mirror"), 1);
			recipe.AddIngredient(298, 1);
			recipe.AddTile(125);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}