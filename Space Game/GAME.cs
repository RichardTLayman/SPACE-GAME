using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class GAME
    {
        public static Player Created = new Player();
        Ship MyShip = new Ship();
        Calculations Calc = new Calculations();
        Items Shopping = new Items();
        

        //double distance = Calc.MeasureDistance(0, .08, 0, .08);

        // This is where all the magic will happen.
        public void StartGame()
        {
            GameTitle();
            CharacterCreation();
            HUD();
            MainSelection();
            //double distance = Calc.MeasureDistance(0, 3, 0, 3);
            //double Warped = Calc.WarpSpeed(MyShip.WarpSpeed);
           // double Time = Calc.MeasuredTime(distance, Warped);
            Console.ReadKey();

            //EndGame();
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

         void HUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  ------------------------------------------------------------     ");
            Console.WriteLine("| Char Name: " + Created.CharName + " <> Location: " + Created.Location + " <> Age: " + Created.CharAge + " <> Creds: " + Created.Creds + " |");
            Console.WriteLine("  ------------------------------------------------------------     ");
            Console.ResetColor();
        }

        void Shop()
        {
            Console.Clear();
            HUD();

            Console.WriteLine("Welcome to the shop!\n Do you wish to Buy or Sell?");
            Console.WriteLine(" To BUY: Press 1.\n To SELL: Press 2.");

            string input = Console.ReadLine();

            if (input == "1" || input == "2")
            {

                switch (input)
                {
                    case "1":

                        Created.Creds -= Shopping.Buy(Created.PlanetMarker);
                        break;

                    case "2":

                        Created.Creds += Shopping.Sell(Created.PlanetMarker);
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
            HUD();
            string CurrentPlanet = Created.Location;
            double CurrentX = Created.x;
            double CurrentY = Created.y;

            string planet = "";
            int planetMarker;
            double x = 0;
            double y = 0;

            Console.WriteLine(" Please select the planet you which to travel to:");
            Console.WriteLine(" For Earth: Press 1.\n For Pluto: Press 2.\n For Planet X: Press 3.\n For Alpha Centari 3: Press 4.\n To GO BACK: Press 5.");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                planet = PlanetHolder.Earth.PlanetName;
                Created.PlanetMarker = PlanetHolder.Earth.PlanetMarker;
                x = PlanetHolder.Earth.x;
                y = PlanetHolder.Earth.y;
            }
            else if ( input == "2")
            {
                planet = PlanetHolder.Pluto.PlanetName;
                Created.PlanetMarker = PlanetHolder.Pluto.PlanetMarker;
                x = PlanetHolder.Pluto.x;
                y = PlanetHolder.Pluto.y;
            }
            else if (input == "3")
            {
                planet = PlanetHolder.PlanetX.PlanetName;
                Created.PlanetMarker = PlanetHolder.PlanetX.PlanetMarker;
                x = PlanetHolder.PlanetX.x;
                y = PlanetHolder.PlanetX.y;
            }
            else if (input == "4")
            {
                planet = PlanetHolder.AlphaCentari3.PlanetName;
                Created.PlanetMarker = PlanetHolder.AlphaCentari3.PlanetMarker;
                x = PlanetHolder.AlphaCentari3.x;
                y = PlanetHolder.AlphaCentari3.y;
            }
            else if (input == "5")
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

            if (CurrentPlanet == planet)
            {
                Console.WriteLine("You are already at this planet. Please choose again!");
                Console.ReadKey();
                Travel();
            }

            Console.WriteLine("You wish to travel from " + CurrentPlanet + " to " + planet + ".");
            Double Distance = Calc.MeasureDistance(Created.x, x, Created.y, y);
            Double Aged = Calc.MeasuredTime(Distance, (Calc.WarpSpeed(MyShip.WarpSpeed)));
            Console.WriteLine();

            Console.WriteLine("Do you wish to travel here? Y/N");
            string YNinput = Console.ReadLine();
            YNinput = YNinput.ToUpper();

            if (YNinput == "Y")
            {
                Console.WriteLine("You have arrive at " + planet + ".");
                Created.CharAge += Aged;
                Created.Location = planet;
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
            HUD();

            Console.WriteLine("   Items              Quantity");
            Console.WriteLine("   -----              --------");
            Console.WriteLine($" {Shopping.TradingItems[0]}              {Shopping.LootQTY[0]}");
            Console.WriteLine($" {Shopping.TradingItems[1]}               {Shopping.LootQTY[1]}");
            Console.WriteLine($" {Shopping.TradingItems[2]}               {Shopping.LootQTY[2]}");
            Console.WriteLine($" {Shopping.TradingItems[3]}     {Shopping.LootQTY[3]}");

            Console.ReadKey();
            MainSelection();
        }

        void MainSelection()
        {
            string input;

            Console.Clear();
            HUD();
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
                MainSelection();
            }

        }

    }
}
