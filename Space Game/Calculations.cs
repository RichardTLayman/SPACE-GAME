using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Calculations
    {
        const int SpeedOfLightSec = 186000;
        const int SpeedOfLightMin = 11160000;
        const int SpeedOfLightHour = 669600000;
        const long SpeedOfLightDay = 16070400000;
        const long SpeedOfLightMonth = 482112000000;
                                            
        const long LightYear = 5880000000000000; // Unit of distance it takes light to travel in one year (5.88 trillion)

        //pluto is 4.67 billion miles away from earth. 8% of a LY.
        // Alpha Centari 3 is 4.3 LYs away from Earth

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
            Distance = Math.Round(Distance, 2);

            Console.WriteLine("You have traveled " + Distance + " Light Years.");
            return Distance; // compared to 1 LY
        }

        public double MeasuredTime(double distance, double speed)
        {
            double Time = distance / speed;
            Time = Math.Round(Time, 2);
            Console.WriteLine("You are " + Time + " years older.");
            return Time;
        }

       
    }
}
