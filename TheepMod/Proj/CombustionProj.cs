using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Achievements;

namespace TheepMod.Proj
{
	class CombustionProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 15;
			projectile.height = 15;
			projectile.friendly = true;
			projectile.penetrate = -1;
			drawOffsetX = 5;
			drawOriginOffsetY = 5;
			projectile.timeLeft = 1;
		}

		public override void AI()
		{
			projectile.tileCollide = false;
			projectile.alpha = 255;
			projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
			projectile.width = 750;
			projectile.height = 750;
			projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
			projectile.damage = 4;
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 10 * 60);
		}
	}
}
