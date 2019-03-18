using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Items
    {
        string ItemName;
        string ItemDescription;
        int ItemQuantity;

        //string[] ShipEngine = { "Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7", "Level 8", "Level 9", };
        string[] TradingItems = { " Earth loot, Pluto Loot, Planet X Loot, Alpha Centuri Loot" };
        string[] ShipUpgrades = { "Engine", "Cargohold", "Sensors", "Weapons Systems",  };
        Items NewItem = new Items();
    }
}
