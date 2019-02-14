using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheepMod.Shop
{
    public class LeafSell : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.WitchDoctor:
                    if (Main.player[Main.myPlayer].ZoneJungle)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("SummonLeaf")); 
                        nextSlot++;
                    }
 
                    break;
            }
        }
    }
}