using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheepMod.NPCs
{

	public class JumpingCactus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jumping Cactus");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 18;
			npc.damage = 55;
			npc.defense = 3;
			npc.lifeMax = 120;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 350f;
			npc.aiStyle = 1;
			npc.alpha = 50;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			banner = npc.type;
			bannerItem = mod.ItemType("JumpingCactusBanner");
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 10 : 70;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 0f, 0f, 70, new Color(0,255,67), 1f);
			}
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(NPC.downedBoss1)
				return SpawnCondition.OverworldDayDesert.Chance * 0.7f;
			else
				return 0f;
		}
		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemID.Cactus, Main.rand.Next(3,6));
		}
	}
}
