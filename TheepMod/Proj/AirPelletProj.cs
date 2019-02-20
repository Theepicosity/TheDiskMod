using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class AirPelletProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("Air Pellet");
	}
    public override void SetDefaults()
        {
			projectile.width = 2;
			projectile.height = 4;
			projectile.penetrate = 1;
			projectile.maxPenetrate = 1;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
        }
    }
}
