using Microsoft.Xna.Framework;
using System;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using System.Collections.Generic;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;

namespace TheepMod.Tiles
{
	public class ElectricTrapTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileFrameImportant[Type] = true;
			drop = mod.ItemType("ElectricTrap");
			disableSmartCursor = true;
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("ElectricTrap"));
		}
		public override void HitWire(int i, int j)
		{
			int y = j;
			int x = i;

			Wiring.SkipWire(x, y);
			int spawnX = x * 16;
			int spawnY = y * 16;
			if (Wiring.CheckMech(x, y, 90) && NPC.MechSpawn((float)spawnX, (float)spawnY, mod.ProjectileType("ElectricBallTrap")))
			{
				Projectile.NewProjectile((float)spawnX+8, (float)spawnY + 8, 0f, -3f, mod.ProjectileType("ElectricBallTrap"), 50, 0);
			}
		}
	}
}