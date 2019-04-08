using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class StarDiskProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("StarDiskProj");
	}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
				for (int k = 0; k < 30; k++)
				{
					int dust = Dust.NewDust(projectile.position, projectile.width, 2, 15, 1f, 1f, 0, default(Color), 2.5f);
					Main.dust[dust].noGravity = true;
				}
			}
			else
			{
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y;
				}
				Main.PlaySound(SoundID.Item10, projectile.position);
				for (int k = 0; k < 5; k++)
				{
					int dust = Dust.NewDust(projectile.position, projectile.width, 2, 15, 1f, 1f, 20, default(Color), 1.5f);
					Main.dust[dust].noGravity = true;
				}
			}
			return false;
		}

    public override void SetDefaults()
        {
			projectile.width = 2;
			projectile.height = 8;
			projectile.penetrate = 8;
			projectile.maxPenetrate = 8;
			projectile.aiStyle = 1;
			projectile.light = 0.2f;
			projectile.friendly = true;
			projectile.ranged = true;
        }
		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 15, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f, 50, default(Color), 1f);
			Main.dust[dust].noGravity = true;
		}
    }
}
