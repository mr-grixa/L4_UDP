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
            return 0;
        }

        public static double RandomData(double x)
        {
            double minValue = -1.0;
            double maxValue = 1.0;
            return minValue + (maxValue - minValue) * x;
        }

        public static double TriangleWave(double x)
        {
            double amplitude = 1.0;
            double period = 1.0;
            double phase = 0.0;

            double normalizedX = (x + phase) % period / period;
            double triangleValue = 0.0;

            if (normalizedX < 0.5)
            {
                triangleValue = 4.0 * normalizedX - 1.0;
            }
            else
            {
                triangleValue = -4.0 * normalizedX + 3.0;
            }

            return amplitude * triangleValue;
        }

        public static double GaussianNoise(double x)
        {
            double mean = 0.0;
            double standardDeviation = 0.1;

            Random random = new Random();
            x = random.NextDouble();
            double u1 = 1.0 - random.NextDouble(); // Uniform random variable from 0 to 1
            double u2 = 1.0 - random.NextDouble(); // Uniform random variable from 0 to 1
            double standardNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // Standard normal random variable

            return mean + standardDeviation * standardNormal;
        }
    }
}
