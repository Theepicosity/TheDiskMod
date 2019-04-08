using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheepMod.NPCs
{

	public class BridgeTroll : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bridge Troll");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 32;
			npc.defense = 25;
			npc.lifeMax = 145;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 120f;
			npc.aiStyle = 3;
			npc.knockBackResist = 0.5f;
			aiType = 254;
			animationType = NPCID.Zombie;
			banner = npc.type;
			bannerItem = mod.ItemType("BridgeTrollBanner");
		}
		
		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 10 : 70;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 5);
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(NPC.downedBoss1)
				return SpawnCondition.Sky.Chance * 1f;
			else
				return 0f;
		}
	}
}