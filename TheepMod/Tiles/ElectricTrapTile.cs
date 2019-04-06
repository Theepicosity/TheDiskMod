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
			int style = frameX / 18;
			string item;
			switch (style)
			{
				case 0:
					item = "ElectricTrap";
					break;
				case 1:
					item = "ElectricTrap2";
					break;
				default:
					return;
			}
			Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
		}

		public override void HitWire(int i, int j)
		{
			int y = j;
			int x = i;

			Wiring.SkipWire(x, y);
			int spawnX = x * 16;
			int spawnY = y * 16;
				int style = Main.tile[i, j].frameX / 18;
				string type;
				switch (style)
				{
					case 0:
						if (Wiring.CheckMech(x, y, 90) && NPC.MechSpawn((float)spawnX, (float)spawnY, mod.ProjectileType("ElectricBallTrap")))
						{
							Projectile.NewProjectile((float)spawnX+8, (float)spawnY + 8, 0f, -3f, mod.ProjectileType("ElectricBallTrap"), 130, 0);
						}
						break;
					case 1:
						if (Wiring.CheckMech(x, y, 90) && NPC.MechSpawn((float)spawnX, (float)spawnY, mod.ProjectileType("ElectricBrainTrap")))
						{
							Projectile.NewProjectile((float)spawnX+8, (float)spawnY + 8, 0f, -4f, mod.ProjectileType("ElectricBrainTrap"), 5, 0);
						}
						break;
					default:
						return;
				}
		}
	}
}