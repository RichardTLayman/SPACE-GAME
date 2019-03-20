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
        public double x;
        public double y;

        public Planet(string name, double x, double y)
        {
            PlanetName = name;
            this.x = x;
            this.y = y;

        }


    }
}
