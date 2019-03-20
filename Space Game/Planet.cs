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
        public int PlanetMarker;
        public double x;
        public double y;

        public Planet(string name, int PM, double x, double y)
        {
            PlanetName = name;
            PlanetMarker = PM;
            this.x = x;
            this.y = y;

        }


    }
}
