using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Calculations
    {
        const int SpeedOfLight = 670616629; // MPH
                                            // Warp speed v(W) = W(10/3) + (10 − W)(-11/3)
        const long LightYear = 5880000000000000; // Unit of distance it takes light to travel in one year (5.88 trillion)

        //int EventLuck = Sensors + Weapons;

        //distance formula pythagreum = SQRT ((xa - xb)^2 + (ya - yb)^2)
        // Takes two X/Y coordsinates to calculate distance between planets

        //pluto is 4.67 billion miles away from earth

        double distance;

        public double WarpSpeed(int WarpSpeed)
        {
            double Velocity = WarpSpeed * (10 / 3) + (10 - WarpSpeed) * (-11 / 3);
            return Velocity;
        }

        double MeasureDistance(int x1, int x2, int y1, int y2)
        {
            double xFinal = (x1 - x2);
            xFinal = Math.Pow(xFinal, 2);

            double yFinal = (y1 - y2);
            yFinal = Math.Pow(yFinal, 2);

            Double Distance = Math.Sqrt(xFinal + yFinal);
            return Distance;
        }

        double ConvertDistance(double distance)
        {

        }


    }
}
