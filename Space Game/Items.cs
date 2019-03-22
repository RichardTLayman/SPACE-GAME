using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Items
    {
        public static readonly string[] TradingItems = { "Politicians", "Space dogs", "Chemical X", "Light Year Smoothies", "Adamantium" };
        public static readonly int[] TradingPrices = { 100, 50, 250, 1000, 5000};

        public int[] LootQTY = { 0, 0, 0, 0, 0 };
        //string[] ShipUpgrades = { "Engine", "Cargohold", "Sensors", "Weapons Systems", };
 
        public int Buy(Player player, Ship ship)
        {
            int quantity;
            int totalCost;

            Console.Clear();
            GAME.HUD(player, ship);

            Console.WriteLine();
            Console.WriteLine("Welcome traveller! We currently sell " + player.planet.itemForSale + ".");
            Console.WriteLine($"{player.planet.itemForSale} will cost you {player.planet.itemPrice} per item.");
            Console.WriteLine("How many do you wish to buy?");
            quantity = Convert.ToInt32(Console.ReadLine());
            totalCost = quantity * player.planet.itemPrice;

            Console.WriteLine($"That will cost you {totalCost}. Are you sure? Y/N");
            string input = Console.ReadLine();
            input = input.ToUpper();

            if (totalCost > player.Creds)
            {
                Console.WriteLine("Whoa! You do not have enough creds my friend. Come back when you have the creds.");
                Console.ReadKey();

                return 0;
            }

            if (input == "Y")
            {
                Console.WriteLine($"You have purchased {quantity} {player.planet.itemForSale}.");
                Console.ReadKey();
                LootQTY[player.planet.itemIndex] += quantity;
                return totalCost;
            }
            else
            {
                Console.WriteLine("Perhaps next time then friend.");
                Console.ReadKey();
                return 0;
            }

        }

        public int Sell(Player player, Ship ship)
        {
            int TotalGain = 0;

            var planet = player.planet;

            Console.Clear();
            GAME.HUD(player, ship);

            Console.WriteLine();
            Console.WriteLine("Welcome Traveller! What are you looking to sell?");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                     Your Current Inventory ");
            Console.ResetColor();

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(" Politicians <> Space dogs <> Chemical X <> Light Year Smoothies <> Adamantium");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"      {LootQTY[0]}              {LootQTY[1]}             {LootQTY[2]}                 {LootQTY[3]}                 {LootQTY[4]}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("               I will buy the items for this much: ");
            Console.ResetColor();

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(" Politicians <> Space dogs <> Chemical X <> Light Year Smoothies <> Adamantium");
            Console.WriteLine("-------------------------------------------------------------------------");




            Console.WriteLine($"      {planet.loot[0]}            {planet.loot[1]}           {planet.loot[2]}              {planet.loot[3]}              {planet.loot[4]}");
            Console.WriteLine();

            Console.WriteLine(" To SELL:\n Politicians: Press 1.\n Space dogs: Press 2.\n Chemical X: Press 3.\n Light Year Smoothies: Press 4.\n Adamantium: Press 5.\n To GO BACK: Press 6.");

            int input = int.Parse(Console.ReadLine());
            int CredsBack = 0;

            if (input <= planet.loot.Length)
            {
                var index = input - 1;

                Console.WriteLine($"How many {TradingItems[index]} do you wish to sell?");
                int SellQTY = Convert.ToInt32(Console.ReadLine());

                if (SellQTY > LootQTY[index])
                {
                    Console.WriteLine($"HEY! What do you think you are doing? You do not have enough {Items.TradingItems[index]}s to sell. Care to try again?");
                    Console.ReadKey();
                    return 0;
                }

                CredsBack = SellQTY * planet.loot[index];
                Console.WriteLine($"You want to sell {SellQTY} {Items.TradingItems[index]}s for {CredsBack} Creds. Are you sure? Y/N");
                string YN = Console.ReadLine();
                YN = YN.ToUpper();

                if (YN == "Y")
                {
                    Console.Clear();
                    GAME.HUD(player, ship);
                    Console.WriteLine();
                    Console.WriteLine($"You sold {SellQTY} {Items.TradingItems[index]}s for {CredsBack} creds.");
                    Console.WriteLine();
                    Console.WriteLine("Pleasure doing business with you.");
                    Console.ReadKey();
                    LootQTY[index] = LootQTY[index] - SellQTY;
                    return CredsBack;
                }
                else
                {
                    Console.WriteLine("It seems you changed your mind.");
                    Console.ReadKey();
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Please input a proper slection!");
                Console.ReadKey();
                //Sell(player);
            }

            Console.ReadKey();
            return TotalGain;
        }

        public void Mechanic(Ship ship, Player player)
        {
            int WarpEngineCost = 50000 * ship.WarpSpeed;
            int WeaponCost = 25000 * ship.WarpSpeed;
            int SensorCost = 25000 * ship.Sensors;

            Console.Clear();
            GAME.HUD(player, ship);

            Console.WriteLine("Looking for an upgrade? You came to the right place.");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($" Level {ship.WarpSpeed} Warp Engines     Level {ship.Weapons} Weapon Systems     Level {ship.Sensors} Sensor Array");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" For Warp Engines: Press 1.\n For Sensors: Press 2.\n For Weapon Systems: Press 3.");
            Console.WriteLine();
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("A better Warp Engine will let you travel to places faster.");
                    if (ship.WarpSpeed < 9)
                {
                    Console.WriteLine($"It will cost you {WarpEngineCost} Creds to upgrade to Level {ship.WarpSpeed + 1}.");
                    Console.WriteLine("Do you wish to upgrade? Y/N?");
                    string YN = Console.ReadLine();
                    YN = YN.ToUpper();

                    if (YN == "Y")
                    {
                        Console.Clear();
                        GAME.HUD(player, ship);

                        player.Creds -= WarpEngineCost;
                        ship.WarpSpeed += ship.WarpSpeed;
                        
                        Console.WriteLine($"You have upgraded your Warp Engines to Level {ship.WarpSpeed}.");

                    }
                    else
                    {
                        Console.WriteLine("It seems you changed your mind.");
                        Console.ReadKey();
                        
                    }

                }
            }
            else if (input == "2")
            {

            }
            else if (input == "3")
            {

            }
            else
            {
                Console.WriteLine(" Please input a proper selection!");
                Console.ReadKey();
                Mechanic(ship, player);
            }
        }
    }
}
