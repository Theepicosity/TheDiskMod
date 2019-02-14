using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class DispSparkProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("DispSparkProj");
	}
    public override void SetDefaults()
        {
			projectile.width = 6;
			projectile.height = 6;
			projectile.aiStyle = 0;
			projectile.friendly = false;
			projectile.light = 1;
			projectile.timeLeft = 1800;
        }
		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 1f, 1f, 0, default(Color), 1.0f);
			Main.dust[dust].noGravity = true;
		}
		public override void Kill(int timeLeft)
		{
			if (projectile.owner == Main.myPlayer)
			{
				int item =
				Main.rand.Next(1) == 0
					? Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType<Items.DisposableSpark>())
					: 0;
				if (Main.netMode == 1 && item >= 0)
				{
					NetMessage.SendData(MessageID.SyncItem, -1, -1, null, item, 1f);
				}
			}
		}

    }
}
