using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace TheepMod.Proj
{
	//ported from my tAPI mod because I'm lazy
	public class KinokoProj : HoverShooter
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 3;
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.Homing[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting
		}

		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.width = 22;
			projectile.height = 24;
			projectile.friendly = true;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			inertia = 20f;
			shoot = mod.ProjectileType("KinokoShootProj");
			shootSpeed = 5f;
		}

		public override void CheckActive()
		{
			Player player = Main.player[projectile.owner];
			TheepPlayer modPlayer = player.GetModPlayer<TheepPlayer>(mod);
			if (player.dead)
			{
				modPlayer.fungusMinion = false;
			}
			if (modPlayer.fungusMinion)
			{
				projectile.timeLeft = 2;
			}
		}

		public override void CreateDust()
		{
			Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
		}

		public override void SelectFrame()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter >= 8)
			{
				projectile.frameCounter = 0;
				projectile.frame = (projectile.frame);
			}
		}
	}
}