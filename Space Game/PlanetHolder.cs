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

        public static Planet Earth = new Planet("Earth", 0, 0, 0, new[] { 50, 150, 500, 5000, 10000 });
        public static Planet Pluto = new Planet("Pluto", 1, .06, .06, new[] { 150, 25, 1000, 3500, 7000 });
        public static Planet PlanetX = new Planet("Planet X", 2, 1.5, 1.5, new[] { 500, 250, 125, 2500, 5000 });
        public static Planet AlphaCentari3 = new Planet("Alpha Centeri 3", 3, 3, 3,  new[] { 1000, 500, 750, 500, 500 });
        public static Planet Gliese7 = new Planet("Gliese 7", 4, 14.2, 14.1, new[] { 5000, 1500, 2500, 10000, 50000 });
    }
}
