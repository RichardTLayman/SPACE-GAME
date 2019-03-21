using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Planet
    {


        public string PlanetName;

        public string itemForSale;
        public int itemPrice;
        public int itemIndex;

        public double x;
        public double y;

        public int[] loot;

        public Planet(string name, int PM, double x, double y, int[] loot)
        {
            PlanetName = name;

            itemForSale = Items.TradingItems[PM];
            itemPrice = Items.TradingPrices[PM];
            itemIndex = PM;

            this.x = x;
            this.y = y;
            this.loot = loot;

        }


    }
}
