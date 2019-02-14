using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Buffs
{
	public class ShineBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Shine");
			Description.SetDefault("The Shine will fight for you.");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
		}
	}
}
