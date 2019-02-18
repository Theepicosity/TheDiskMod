using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod
{
	public class TheepPlayer : ModPlayer
	{
		public bool fungusMinion;
		public override void ResetEffects()
		{
			fungusMinion = false;
		}
	}
}
