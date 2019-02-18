using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Buffs
{
	public class KinokoBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Glowing Mushroom");
			Description.SetDefault("The glowing mushroom will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TheepPlayer modPlayer = player.GetModPlayer<TheepPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("KinokoProj")] > 0)
			{
				modPlayer.fungusMinion = true;
			}
			if (!modPlayer.fungusMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}