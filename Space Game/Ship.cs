using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Ship
    {
        

        public string ShipName;
        public int WarpSpeed;
        public double ModifiedWarpSpeed;
        public int Sensors = 1;
        public int Weapons = 1;
        // int Capacity = 10;
        
        public Ship()
        {
            WarpSpeed = 1;
        }

        public int Luck(int Sensor, int Weapons)
        {
            int luck = (Sensor * 10) + (Weapons * 10);
            return luck;
        }

        
    }
}
