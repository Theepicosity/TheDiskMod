using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace TheepMod.Proj
{
    public class ElectricBrainTrap : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("Electric Mind");
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
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(80, 600, false);
			target.AddBuff(31, 600, false);
			target.AddBuff(36, 600, false);
        }
    }
}
