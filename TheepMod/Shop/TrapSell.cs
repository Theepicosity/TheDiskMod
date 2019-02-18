using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheepMod.Shop
{
    public class TrapSell : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Cyborg:
					if(NPC.downedMartians)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("TrapPart")); 
                        nextSlot++;
                    }
 
                    break;
            }
        }
    }
}