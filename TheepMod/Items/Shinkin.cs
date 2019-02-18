using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Items
{
	public class Shinkin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shinkin Staff");
			Tooltip.SetDefault("Summons a glowing mushroom to fight for you.");
		}
		public override void SetDefaults()
		{
			item.damage = 14;
			item.summon = true;
			item.mana = 10;
			item.width = 24;
			item.height = 16;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("KinokoProj");
			item.shootSpeed = 1f;
			item.buffType = mod.BuffType("KinokoBuff");	//The buff added to player after used the item
			item.buffTime = 3600;				//The duration of the buff, here is 60 seconds
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}
		
		public override bool UseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}
	}
}