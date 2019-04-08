using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class MetDiskProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("MetDiskProj");
	}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
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
			}
			return false;
		}

    public override void SetDefaults()
        {
			projectile.width = 2;
			projectile.height = 8;
			projectile.penetrate = 5;
			projectile.maxPenetrate = 5;
			projectile.aiStyle = 1;
			projectile.light = 0.2f;
			projectile.friendly = true;
			projectile.ranged = true;
        }
    }
}
