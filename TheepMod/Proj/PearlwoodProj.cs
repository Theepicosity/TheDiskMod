using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class PearlwoodProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("PearlwoodProj");
	}
    public override void SetDefaults()
        {
			projectile.width = 8;
			projectile.height = 8;
			projectile.penetrate = 2;
			projectile.maxPenetrate = 2;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.magic = true;
        }
		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 22, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 0, default(Color), 1.0f);
			Main.dust[dust].noGravity = true;
		}
    }
}
