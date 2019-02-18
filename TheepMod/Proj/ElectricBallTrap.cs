using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace TheepMod.Proj
{
    public class ElectricBallTrap : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("ElectricBallTrap");
	}
    public override void SetDefaults()
        {
			projectile.width = 4;
			projectile.height = 4;
			projectile.penetrate = 1;
			projectile.maxPenetrate = 1;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = true;
			projectile.trap = true;
        }
	public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 20, 0f, 0f, 100, new Color(0, 5, 10), 1f);
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
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(144, 360, false);
        }
    }
}
