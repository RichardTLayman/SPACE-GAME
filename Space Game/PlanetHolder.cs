using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class PlanetHolder
    {
        // Simply Holds the instsanced Planets since instancing an object is its own class breaks everything.

        public static Planet Earth = new Planet("Earth", 0, 0);
        public static Planet AlphaCentari3 = new Planet("Alpha Centeri 3", 15, 15);
        public static Planet PlanetX = new Planet("Planet X", 10, 10);
        public static Planet Pluto = new Planet("Pluto", 7, 7);
    }
}
