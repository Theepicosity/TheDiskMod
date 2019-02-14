using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Buffs
{
	public class Blocky : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Bouncy");
			Description.SetDefault("Jumping height is increased");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.jumpSpeedBoost += 2.8f;
		}
	}
}
