using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Player
    {
        public string CharName;
        public double x = 0;
        public double y = 0;
        public double CharAge = 20;
        public int Creds = 0;
        public int Luck;

        public Planet planet = PlanetHolder.Earth;

        public Player()
        {
            Creds = 100000;
            Luck = 1;
        }

        
    }
}
