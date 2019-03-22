using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class GAME
    {
        public Player Created = new Player();
        public Ship MyShip = new Ship();
        Calculations Calc = new Calculations();
        public static Items Shopping = new Items();

        static bool Run = true;
        static bool BadMoneyEnd = false;
        static bool GoodMoneyEnd = false;
        static bool AgedOut = false;
        
        // This is where all the magic will happen.
        public void StartGame()
        {
            GameTitle();
            CharacterCreation();
            HUD(Created, MyShip);

            while (Run == true)
            {
                MainSelection();
            }
            EndGame();
        }

        void GameTitle()
        {
            string Title = @" 

 _______  _______  _______  _______  _______    _______  _______  _______  _______ 
(  ____ \(  ____ )(  ___  )(  ____ \(  ____ \  (  ____ \(  ___  )(       )(  ____ \
| (    \/| (    )|| (   ) || (    \/| (    \/  | (    \/| (   ) || () () || (    \/
| (_____ | (____)|| (___) || |      | (__      | |      | (___) || || || || (__    
(_____  )|  _____)|  ___  || |      |  __)     | | ____ |  ___  || |(_)| ||  __)   
      ) || (      | (   ) || |      | (        | | \_  )| (   ) || |   | || (      
/\____) || )      | )   ( || (____/\| (____/\  | (___) || )   ( || )   ( || (____/\
\_______)|/       |/     \|(_______/(_______/  (_______)|/     \||/     \|(_______/
                                                                                   

";
            Console.Title = "SPACE GAME";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }

        void CharacterCreation()
        {
            Console.WriteLine("Please name your character:");
            Created.CharName = Console.ReadLine();
            Console.WriteLine("Please name your ship:");
            MyShip.ShipName = Console.ReadLine();
            Console.Clear();
        }

        public static void HUD(Player player, Ship ship)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  ------------------------------------------------------------------------");
            Console.WriteLine("| Name: " + player.CharName + " <> Ship: " + ship.ShipName + " <> Location: " + player.planet.PlanetName + " <> Age: " + player.CharAge + " <> Creds: " + player.Creds + " |");
            Console.WriteLine("  ------------------------------------------------------------------------");
            Console.ResetColor();
        }

        void Shop()
        {
            Console.Clear();
            HUD(Created, MyShip);

            Console.WriteLine("Welcome to the shop!\n Do you wish to Buy or Sell?");
            Console.WriteLine(" To BUY: Press 1.\n To SELL: Press 2.\n MECHANIC: Press 3.");

            string input = Console.ReadLine();

            if (input == "1" || input == "2" || input == "3")
            {
                switch (input)
                {
                    case "1":

                        Created.Creds -= Shopping.Buy(Created, MyShip);
                        break;

                    case "2":

                        Created.Creds += Shopping.Sell(Created, MyShip);
                        break;

                    case "3":

                        Shopping.Mechanic(MyShip, Created);
                        break;

                    default:

                        break;
                }
            }

            MainSelection();
        }

        void Travel()
        {
            Console.Clear();
            HUD(Created, MyShip);

            Planet CurrentPlanet = Created.planet;
            double CurrentX = Created.x;
            double CurrentY = Created.y;
            
            double x = 0;
            double y = 0;

            Console.WriteLine(" Please select the planet you which to travel to:");
            Console.WriteLine(" For Earth: Press 1.\n For Pluto: Press 2.\n For Planet X: Press 3.\n For Alpha Centari 3: Press 4.\n For Gliese 7: Press 5.\n To GO BACK: Press 6.");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                Created.planet = PlanetHolder.Earth;
                x = PlanetHolder.Earth.x;
                y = PlanetHolder.Earth.y;
            }
            else if ( input == "2")
            {
                Created.planet = PlanetHolder.Pluto;
                x = PlanetHolder.Pluto.x;
                y = PlanetHolder.Pluto.y;
            }
            else if (input == "3")
            {
                Created.planet = PlanetHolder.PlanetX;
                x = PlanetHolder.PlanetX.x;
                y = PlanetHolder.PlanetX.y;
            }
            else if (input == "4")
            {
                Created.planet = PlanetHolder.AlphaCentari3;
                x = PlanetHolder.AlphaCentari3.x;
                y = PlanetHolder.AlphaCentari3.y;
            }
            else if (input == "5")
            {
                Created.planet = PlanetHolder.Gliese7;
                x = PlanetHolder.Gliese7.x;
                y = PlanetHolder.Gliese7.y;
            }
            else if (input == "6")
            {
                Console.WriteLine("It seems you have changed your mind!");
                Console.ReadKey();
                MainSelection();
            }
            else
            {
                Console.WriteLine("Please input a proper slection!");
                Console.ReadKey();
                Travel();
            }

            if (CurrentPlanet == Created.planet)
            {
                Console.WriteLine("You are already at this planet. Please choose again!");
                Console.ReadKey();
                Travel();
            }

            Console.WriteLine("You wish to travel from " + CurrentPlanet.PlanetName + " to " + Created.planet.PlanetName + ".");
            Double Distance = Calc.MeasureDistance(Created.x, x, Created.y, y);
            Double Aged = Calc.MeasuredTime(Distance, (Calc.WarpSpeed(MyShip.WarpSpeed)), MyShip);
            Console.WriteLine();

            Console.WriteLine("Do you wish to travel here? Y/N");
            string YNinput = Console.ReadLine();
            YNinput = YNinput.ToUpper();

            if (YNinput == "Y")
            {
                Console.WriteLine("You have arrive at " + Created.planet.PlanetName + ".");
                Created.CharAge += Aged;
                Created.x = x;
                Created.y = y;
                MainSelection();
            }
            else
            {
                Console.WriteLine("It seems you changed your mind.");
                Console.ReadKey();
                Travel();
            }

        }

        void Display()
        {
            Console.Clear();
            HUD(Created, MyShip);

            Console.WriteLine($"   Items              Quantity           {MyShip.ShipName}'s Equipment");
            Console.WriteLine("   -----              --------              ------------");
            Console.WriteLine($" {Items.TradingItems[0]}              {Shopping.LootQTY[0]}            Level {MyShip.WarpSpeed} Warp Engine");
            Console.WriteLine($" {Items.TradingItems[1]}               {Shopping.LootQTY[1]}           Level {MyShip.Weapons} Weapon Systems");
            Console.WriteLine($" {Items.TradingItems[2]}               {Shopping.LootQTY[2]}           Level {MyShip.Sensors} Sensor Systems");
            Console.WriteLine($" {Items.TradingItems[3]}     {Shopping.LootQTY[3]}");
            Console.WriteLine($" {Items.TradingItems[4]}               {Shopping.LootQTY[4]}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
            MainSelection();
        }

        void MainSelection()
        {
            string input;

            Console.Clear();
            HUD(Created, MyShip);

            // Run out of Money ending
            if (Created.Creds <= 0 && Shopping.LootQTY[0] <= 0 && Shopping.LootQTY[1] <= 0 && Shopping.LootQTY[2] <= 0 && Shopping.LootQTY[3] <= 0 && Shopping.LootQTY[4] <= 0)
            {
                Run = false;
                BadMoneyEnd = true;
                return;
            }

            // Fortune Good ending
            if (Created.Creds >= 100000000)
            {
                Run = false;
                GoodMoneyEnd = true;
                return;
            }

            // Aged out ending
            if ( Created.CharAge >= 70)
            {
                Run = false;
                AgedOut = true;
                return;
            }

            if (Created.Creds < 0)
            {
                Created.Creds = 0;
            }

            Console.WriteLine();
            Console.WriteLine(" Please make a selection:");
            Console.WriteLine(" To SHOP, press 1:");
            Console.WriteLine(" To TRAVEL to a new planet, Press 2:");
            Console.WriteLine(" To DISPLAY Status and Inventory, Press 3;");

            input = Console.ReadLine();

           

            if (input == "1" || input == "2" || input == "3")
            {

                switch (input)
                {
                    case "1":

                        Shop();
                        break;

                    case "2":

                        Travel();
                        break;

                    case "3":

                        Display();
                        break;

                    default:

                        break;
                }
            }

            else
            {
                Console.WriteLine("Please input a proper selection!");
                Console.ReadKey();
                
            }

        }

        void EndGame()
        {
            if (BadMoneyEnd == true)
            {
                Console.WriteLine("You have run out of money!");
                Console.WriteLine("GAME OVER!!!");
                Console.ReadKey();

            }
            else if (GoodMoneyEnd == true)
            {
                Console.WriteLine(" Congratulations!!!");
                Console.WriteLine(" You have amassed quite the fortune!");
                Console.WriteLine(" Enjoy your retirement!");
                Console.ReadKey();
            }
            else if (AgedOut == true)
            {
                Console.WriteLine(" You are much to old to continue.");
                Console.WriteLine(" While it is not enough to retire comfortably, you did make some money.");
                Console.WriteLine($" Current Creds = {Created.Creds}.");
                Console.ReadKey();
            }
            else 
            {
                Run = true;
                MainSelection();
            }
        }

    }
}
