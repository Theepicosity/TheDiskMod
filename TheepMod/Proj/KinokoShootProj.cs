using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
	public class KinokoShootProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.MinionShot[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.alpha = 255;
			projectile.penetrate = 1;
			projectile.friendly = true;
			projectile.ignoreWater = false;
			projectile.tileCollide = true;
		}

		public override void AI()
		{
			if (projectile.localAI[0] == 0f)
			{
				Main.PlaySound(SoundID.Item20, projectile.position);
				projectile.localAI[0] = 1f;
			}
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 22, 0f, 0f, 100, new Color(0, 150, 255), 1.5f);
			Main.dust[dust].velocity *= 0.1f;
			if (projectile.velocity == Vector2.Zero)
			{
				Main.dust[dust].velocity.Y -= 1f;
				Main.dust[dust].scale = 1.2f;
			}
			else
			{
				Main.dust[dust].velocity += projectile.velocity * 0.2f;
			}
			Main.dust[dust].noGravity = true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate = -1;
			projectile.maxPenetrate = -1;
			projectile.tileCollide = false;
			projectile.position += projectile.velocity;
			projectile.velocity = Vector2.Zero;
			projectile.timeLeft = 180;
			return false;
		}
	}
}