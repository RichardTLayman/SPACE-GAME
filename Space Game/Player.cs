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
        public string Location;
        public double CharAge = 20;
        public int Creds = 0;

        public Player()
        {
            Location = "Earth";
            Creds = 1000;
        }
    }
}
