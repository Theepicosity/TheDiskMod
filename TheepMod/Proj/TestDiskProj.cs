using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class TestDiskProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("DiskProj");
	}
    public override void SetDefaults()
        {
			projectile.width = 2;
			projectile.height = 8;
			projectile.penetrate = 3;
			projectile.maxPenetrate = 3;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
        }
    }
}
