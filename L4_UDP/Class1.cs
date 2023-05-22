using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_UDP
{
    internal class Generate
    {
        public static double SineWave(double x)
        {
            double amplitude = 1.0;
            double frequency = 1.0;
            return amplitude * Math.Sin(2 * Math.PI * frequency * x);
        }

        public static double LinearData(double x)
        {
            double slope = 2.0;
            double intercept = 1.0;
            return slope * x + intercept;
        }

        public static double RandomData(double x)
        {
            double minValue = -1.0;
            double maxValue = 1.0;
            return minValue + (maxValue - minValue) * x;
        }


    }
}
