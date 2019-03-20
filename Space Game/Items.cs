using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Items
    {
        int Creds = GAME.Created.Creds;

        string ItemName;
        string ItemDescription;
        int ItemQuantity;

        string EarthLoot = "Politicians";
        string PlutoLoot = "Space dogs";      
        string PlanetXLoot = "Chemical X";       
        string AlphaCentariLoot = "Light Year Smoothies";
        

        public string[] TradingItems = { "Politicians", "Space dogs", "Chemical X", "Light Year Smoothies" };
        public int[] LootQTY = { 0, 0, 0, 0 };
        int[] TradingPrices = { 100, 50, 250, 1000 };
        string[] ShipUpgrades = { "Engine", "Cargohold", "Sensors", "Weapons Systems",  };
        
        public int Buy(int PM)
        {
            int i = PM;
            int quantity;
            int totalCost;
           
            Console.WriteLine("Welcome traveller! We currently sell " + TradingItems[i] + ".");
            Console.WriteLine($"So {TradingItems[i]} will cost you  {TradingPrices[i]}.");
            Console.WriteLine("How many do you wish to buy?");
            quantity = Convert.ToInt32(Console.ReadLine());
            totalCost = quantity * TradingPrices[i];

            Console.WriteLine($"That will cost you {totalCost}. Are you sure? Y/N");
            string input = Console.ReadLine();
            input = input.ToUpper();

            if (totalCost > Creds)
            {
                Console.WriteLine("Whoa! You do not have enough creds my friend. Come back when you have the creds.");
                Console.ReadKey();
                
                return 0;
            }

            if (input == "Y")
            {
                Console.WriteLine($"You have purchased {quantity} {TradingItems[i]}.");
                Console.ReadKey();
                LootQTY[i] += quantity;
                return totalCost;
            }
            else
            {
                Console.WriteLine("Perhaps next time then friend.");
                Console.ReadKey();
                return 0;
            }
            
        }

        /*public int Sell()
        {
            Console.WriteLine("Welcome Traveller! What are you looking to sell?");
            Console.ReadKey();
        }*/
    }
}
