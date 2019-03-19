using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class GAME
    {
        Player Created = new Player();
        Ship MyShip = new Ship();

        // This is where all the magic will happen.
        public void StartGame()
        {
            GameTitle();
            CharacterCreation();
            HUD();
            
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
            Console.WriteLine("  ------------------------------------------------------------");
            Console.WriteLine("| Char Name: " + Created.CharName + " <> Location: " + Created.Location + " <> Age: " + Created.CharAge + " <> Creds: " + Created.Creds + " |");
            Console.WriteLine("  ------------------------------------------------------------");
            Console.ResetColor();

            //Need to color
        }


    }
}
