using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheepMod.Shop
{
    public class FeatherSell : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:
                    if (Main.player[Main.myPlayer].ZoneDesert)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("SpeedFeather")); 
                        nextSlot++;
                    }
 
                    break;
            }
        }
    }
}