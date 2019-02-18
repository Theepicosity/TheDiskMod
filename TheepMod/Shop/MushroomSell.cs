using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheepMod.Shop
{
    public class MushroomSell : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Truffle:
					if(!Main.dayTime)
					{
                    shop.item[nextSlot].SetDefaults(mod.ItemType("MushroomStick")); 
                    nextSlot++;
					}
 
                break;
            }
        }
    }
}