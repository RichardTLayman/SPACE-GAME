using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class RandomEvents
    {
        Random Choice = new Random();
        Random Event = new Random();

        string[] EventDescription = 
        {
            "While travelling to your next destination, a wormhole appears before your ship.",
            "A distress call appears on screen.",
            "A raiding ship appears out warp before you.",

        };

        public void TravelEvent(Player player, Ship ship)
        {
            int Choices = Choice.Next(1,4);
            int RanNum = Event.Next(1,101);
            
            if (RanNum <= 50)
            { 
                switch (1)
                {
                    case 1:

                        AgeEvent(player, ship);
                        break;

                    case 2:

                        CredsEvent(player, ship);
                        break;

                    case 3:

                        PirateEvent(player, ship);
                        break;
                }
            }
        }

        void AgeEvent(Player player, Ship ship)
        {
            int Choices = Choice.Next(1, 4);
            int RanNum = Event.Next(1, 101);

            if (RanNum <= 25) // all minor good choices
            {
                Console.Clear();
                
                Console.WriteLine(EventDescription[0]);
                
                Console.WriteLine("Do you enter? Y/N");
                Console.WriteLine();
                string YNinput = Console.ReadLine();
                YNinput = YNinput.ToUpper();

                if (YNinput == "Y")
                {
                    Console.WriteLine($"You steer {ship.ShipName} into the warmhole... ");
                    Console.WriteLine("A bright light flashes through the cockpit and then is followed by a sudden darkness as the hole closes around you.");
                    Console.WriteLine("When you come to, your find that you have arrived at your destination full of energy; ready to sieze the day.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" *** You feel younger *** ");
                    Console.ResetColor();

                    if (player.Luck < 40)
                    {
                        player.CharAge = player.CharAge - (Choices - 1);
                    }
                    else if (player.Luck <60)
                    {
                        player.CharAge = player.CharAge - Choices;
                    }
                    else if (player.Luck <= 75)
                    {
                        player.CharAge = player.CharAge - (Choices + 1);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" You easily avoid the wormhole and continue onto your destination.");
                    Console.ReadKey();
                }
            }  
            else if (RanNum >= 26 && RanNum <= 50) // minor bad choices
            {
                Console.Clear();

                Console.WriteLine(EventDescription[0]);

                Console.WriteLine("Do you enter? Y/N");
                Console.WriteLine();
                string YNinput = Console.ReadLine();
                YNinput = YNinput.ToUpper();

                if (YNinput == "Y")
                {
                    Console.WriteLine($"You steer {ship.ShipName} into the warmhole... ");
                    Console.WriteLine("A bright light flashes through the cockpit and then is followed by a sudden darkness as the hole closes around you.");
                    Console.WriteLine("When you come to, your find that you have arrived at your destination feeling sick and tired. You want nothing more than to take a long nap.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" *** You feel older *** ");
                    Console.ResetColor();

                    if (player.Luck < 40)
                    {
                        player.CharAge = player.CharAge + (Choices - 1);
                    }
                    else if (player.Luck < 60)
                    {
                        player.CharAge = player.CharAge + Choices;
                    }
                    else if (player.Luck <= 75)
                    {
                        player.CharAge = player.CharAge + (Choices + 1);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" You easily avoid the wormhole and continue onto your destination.");
                    Console.ReadKey();
                }
            }
            else if (RanNum >= 51 && RanNum <= 75) // major good choices
            {
                Console.Clear();

                Console.WriteLine(EventDescription[0]);

                Console.WriteLine("Do you enter? Y/N");
                Console.WriteLine();
                string YNinput = Console.ReadLine();
                YNinput = YNinput.ToUpper();

                if (YNinput == "Y")
                {
                    Console.WriteLine($"You steer {ship.ShipName} into the warmhole... ");
                    Console.WriteLine("A bright light flashes through the cockpit and then is followed by a sudden darkness as the hole closes around you.");
                    Console.WriteLine("When you come to, your find that you have arrived at your destination full of energy; ready to sieze the day.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" *** You feel much younger *** ");
                    Console.ResetColor();

                    if (player.Luck < 40)
                    {
                        player.CharAge = player.CharAge - (Choices - 1) * 3;
                    }
                    else if (player.Luck < 60)
                    {
                        player.CharAge = player.CharAge - Choices * 3;
                    }
                    else if (player.Luck <= 75)
                    {
                        player.CharAge = player.CharAge - (Choices + 1) * 3;
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" You easily avoid the wormhole and continue onto your destination.");
                    Console.ReadKey();
                }
            }
            else if (RanNum >= 76 && RanNum <= 90) // major bad choices
            {
                Console.Clear();

                Console.WriteLine(EventDescription[0]);

                Console.WriteLine("Do you enter? Y/N");
                Console.WriteLine();
                string YNinput = Console.ReadLine();
                YNinput = YNinput.ToUpper();

                if (YNinput == "Y")
                {
                    Console.WriteLine($"You steer {ship.ShipName} into the warmhole... ");
                    Console.WriteLine("A bright light flashes through the cockpit and then is followed by a sudden darkness as the hole closes around you.");
                    Console.WriteLine("When you come to, your find that you have arrived at your destination feeling sick and tired. You want nothing more than to take a very long nap.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" *** You feel much older *** ");
                    Console.ResetColor();

                    if (player.Luck < 40)
                    {
                        player.CharAge = player.CharAge + (Choices - 1) * 3;
                    }
                    else if (player.Luck < 60)
                    {
                        player.CharAge = player.CharAge + Choices *3;
                    }
                    else if (player.Luck <= 75)
                    {
                        player.CharAge = player.CharAge + (Choices + 1 *3);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(" You easily avoid the wormhole and continue onto your destination.");
                    Console.ReadKey();
                }
            }
            else if (RanNum >= 91 ) // Worst choice
            {
                Console.Clear();

                Console.WriteLine(EventDescription[0]);

                Console.WriteLine("You immeadiately realize that you are headed straight for it.");
                Console.WriteLine("You try to avoid it, but your commands yeild no response.");
                Console.WriteLine("Bracing for the worse. You helplessly pass into the folds of the wormhole.......and then darkness.");
                Console.WriteLine();
                Console.WriteLine("You awake to the alarms and flashing lights of a faulty system as you feel terrible.");
                Console.WriteLine("Reaching out to reboot the system, you notice lines on your hand. Rushing to your camera, you can see eztra visible lines on your face as well.");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" *** You feel and look much much older *** ");
                Console.ResetColor();

                player.CharAge = player.CharAge + 20;
                Console.ReadKey();
            }
        }

        void CredsEvent(Player player, Ship ship)
        {
                
        }

        void PirateEvent(Player player, Ship ship)
        {
                
        }
    }
}
