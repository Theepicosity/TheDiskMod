using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheepMod.Mounts
{
	public class HotAirBalloonMount : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = mod.DustType("Sparkle");
			mountData.buff = mod.BuffType("HotAirBalloonBuff");
			mountData.heightBoost = 20;
			mountData.fallDamage = 0.1f;
			mountData.runSpeed = 5f;
			mountData.dashSpeed = 5f;
			mountData.flightTimeMax = 1000;
			mountData.fatigueMax = 5;
			mountData.jumpHeight = 5;
			mountData.acceleration = 0.02f;
			mountData.jumpSpeed = 4f;
			mountData.blockExtraJumps = false;
			mountData.totalFrames = 6;
			mountData.constantJump = true;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 2;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 0;
			mountData.bodyFrame = 3;
			mountData.yOffset = -12;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 2;
			mountData.standingFrameDelay = 24;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 0;
			mountData.runningFrameDelay = 0;
			mountData.runningFrameStart = 2;
			mountData.flyingFrameCount = 2;
			mountData.flyingFrameDelay = 24;
			mountData.flyingFrameStart = 3;
			mountData.inAirFrameCount = 2;
			mountData.inAirFrameDelay = 24;
			mountData.inAirFrameStart = 3;
			mountData.idleFrameCount = 2;
			mountData.idleFrameDelay = 24;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode != 2)
			{
				mountData.textureWidth = mountData.backTexture.Width;
				mountData.textureHeight = mountData.backTexture.Height;
			}
		}
		public override void UpdateEffects(Player player)
		{
			Rectangle rect = player.getRect();
			int dustIndex = Dust.NewDust(new Vector2(rect.X+4, rect.Y-8), rect.Width-8, rect.Height-32, mod.DustType("Sparkle"));
			Dust dust = Main.dust[dustIndex];
			dust.noGravity = false;
		}
	}
}