using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Planet
    {
        public string PlanetName;
        public int x;
        public int y;

        public Planet(string name, int x, int y)
        {
            PlanetName = name;
            this.x = x;
            this.y = y;

        }


    }
}
