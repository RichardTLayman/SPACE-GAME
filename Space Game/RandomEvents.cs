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

        string[] AgeDesc =
        {
            "While travelling to your next destination, a wormhole appears before your ship.",

        };

        string[] EventDescription = 
        {
            "A warphole appears before your ship.",
            "A distress call appears on screen.",
            "A raiding ship appears out warp before you.",

        };

        public void TravelEvent(int luck)
        {
            int Choices = Choice.Next(1,4);
            int RanNum = Event.Next(1,101);
            
            if (RanNum <= 50)
            { 
                switch (Choices)
                {
                    case 1:

                        AgeEvent(luck);
                        break;

                    case 2:

                        CredsEvent(luck);
                        break;

                    case 3:

                        PirateEvent(luck);
                        break;
                }
            }
        }

        void AgeEvent(int luck2)
        {
            int RanNum = Event.Next(1, 101);

            if (RanNum <=25)
                {
                    Console.WriteLine(AgeDesc[0]);
                }
        }

        void CredsEvent(int luck2)
        {

        }

        void PirateEvent(int luck2)
        {

        }
    }
}
