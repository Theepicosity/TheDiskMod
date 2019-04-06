using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Buffs
{
	public class HotAirBalloonBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hot Air Balloon");
			Description.SetDefault("You are in a balloon!");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
		}
	}
}