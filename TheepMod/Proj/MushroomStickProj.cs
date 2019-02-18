using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.Proj
{
    public class MushroomStickProj : ModProjectile
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("MushroomStickProj");
	}
    public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.StickyGlowstick);
			projectile.tileCollide = true;
			projectile.light = 0f;
        }
		public virtual void CreateDust()
		{
			Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 1.2f, 1.2f, 1.2f);
		}
		public override void Kill(int timeLeft)
		{
			if (projectile.owner == Main.myPlayer)
			{
				int item =
				Main.rand.Next(3) == 0
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
