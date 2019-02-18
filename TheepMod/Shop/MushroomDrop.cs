using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheepMod.Shop
{
    public class MushroomDrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(10) == 0)
            {
                if (npc.type == 258)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Shinkin"));
                }
                else if (npc.type == 259)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Shinkin"));
                }
                else if (npc.type == 257)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Shinkin"));
                }
            }
            if (Main.rand.Next(15) == 0)
            {
                if (npc.type == 254)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Shinkin"));
                }
                else if (npc.type == 255)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Shinkin"));
                }
            }
            if (Main.rand.Next(1) == 0)
            {
                if (npc.type == 256)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MushroomStick"), Main.rand.Next(1, 5));
                }
            }
        }
    }
}