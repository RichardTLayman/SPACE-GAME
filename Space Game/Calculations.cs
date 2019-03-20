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

        //pluto is 4.67 billion miles away from earth

        public double WarpSpeed(int WarpSpeed)
        {
            double Velocity = Math.Pow(WarpSpeed,(10 / 3)) + Math.Pow((10 - WarpSpeed), (-11 / 3));
            Velocity = Math.Round(Velocity, 2);
            return Velocity;
        }

        public double MeasureDistance(double x1, double x2, double y1, double y2) // Takes two X/Y coordsinates to calculate distance between planets
        {
            double xFinal = (x1 - x2);
            xFinal = Math.Pow(xFinal, 2);

            double yFinal = (y1 - y2);
            yFinal = Math.Pow(yFinal, 2);

            Double Distance = Math.Sqrt(xFinal + yFinal);
            return Distance;
        }

        void ConvertDistance(double distance)
        {
            
        }

       
    }
}
