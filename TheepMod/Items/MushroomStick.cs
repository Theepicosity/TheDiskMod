using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TheepMod.Items
{
	public class MushroomStick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroom Glowstick");
			Tooltip.SetDefault("Works when wet");
		}
		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 12;
			item.height = 12;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.holdStyle = 1;
			item.value = 30;
			item.maxStack = 99;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.consumable = true;
			item.shoot = mod.ProjectileType<Proj.MushroomStickProj>();
			item.shootSpeed = 6f;
		}
		public override void HoldItem(Player player)
		{
			Vector2 position = GetLightPosition(player) - new Vector2(20f, 20f);
			if (Main.rand.Next(1) == 0)
			{
				Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 1.2f, 1.2f, 1.2f);
			}
		}
		private Vector2 GetLightPosition(Player player)
		{
			Vector2 position = Main.screenPosition;
			position.X += Main.mouseX;
			position.Y += player.gravDir == 1 ? Main.mouseY : Main.screenHeight - Main.mouseY;
			return position;
		}
		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			glowstick = true;
		}
	}
}
