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

        int[] EarthLoot = { 50, 150, 500, 5000 };
        int[] PlutoLoot = { 150, 25, 1000, 3500 };      
        int[] PlanetXLoot = { 500, 250, 125, 2500 };       
        int[] AlphaCentariLoot = { 1000, 500, 750, 500 };
        

        public string[] TradingItems = { "Politicians", "Space dogs", "Chemical X", "Light Year Smoothies" };
        public int[] LootQTY = { 0, 0, 0, 0 };
        int[] TradingPrices = { 100, 50, 250, 1000 };
        string[] ShipUpgrades = { "Engine", "Cargohold", "Sensors", "Weapons Systems",  };
        
        public int Buy(int PM)
        {
            int i = PM;
            int quantity;
            int totalCost;

            Console.Clear();
            GAME.HUD();

            Console.WriteLine();
            Console.WriteLine("Welcome traveller! We currently sell " + TradingItems[i] + ".");
            Console.WriteLine($"{TradingItems[i]} will cost you {TradingPrices[i]} per item.");
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

        public int Sell(int PM)
        {

            int i = PM;
            int quantity;
            int TotalGain = 0;

            Console.Clear();
            GAME.HUD();

            Console.WriteLine();
            Console.WriteLine("Welcome Traveller! What are you looking to sell?");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                     Your Current Inventory ");
            Console.ResetColor();

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(" Politicians <> Space dogs <> Chemical X <> Light Year Smoothies");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"      {LootQTY[0]}              {LootQTY[1]}             {LootQTY[2]}                 {LootQTY[3]}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("               I will buy the items for this much: ");
            Console.ResetColor();

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(" Politicians <> Space dogs <> Chemical X <> Light Year Smoothies");
            Console.WriteLine("---------------------------------------------------------------");
            
            

            if (PM == 0)
            {
                Console.WriteLine($"      {EarthLoot[0]}            {EarthLoot[1]}           {EarthLoot[2]}              {EarthLoot[3]}");
                Console.WriteLine();
            }
            else if (PM == 1)
            {
                Console.WriteLine($"      {PlutoLoot[0]}            {PlutoLoot[1]}           {PlutoLoot[2]}              {PlutoLoot[3]}");
                Console.WriteLine();
            }
            else if (PM == 2)
            {
                Console.WriteLine(PlanetXLoot);
            }
            else if (PM == 3)
            {
                Console.WriteLine(AlphaCentariLoot);
            }

            Console.WriteLine(" To SELL Politicians: Press 1.\n Space dogs: Press 2.\n Chemical X: Press 3.\n Light Year Smoothies: Press 4.\n To GO BACK: Press 5.");

            string input = Console.ReadLine();




            Console.ReadKey();
            return TotalGain;
        }
    }
}
