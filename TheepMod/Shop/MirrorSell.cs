using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheepMod.Shop
{
    public class MirrorSell : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Stylist:
                    shop.item[nextSlot].SetDefaults(mod.ItemType("Mirror")); 
                    nextSlot++;
 
                    break;
            }
            switch (type)
            {
                case NPCID.Demolitionist:
                    shop.item[nextSlot].SetDefaults(mod.ItemType("DisposableSpark")); 
                    nextSlot++;
 
                    break;
            }
        }
    }
}