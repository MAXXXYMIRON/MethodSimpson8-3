using System;
using System.Collections.Generic;
using static System.Math;

namespace MethSimoson3div8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5,
                b = 7,
                m = 1000;

            double n = 3 * m;
            double h = (b - a) / n;

            double s0 = 0;


            for (int k = 1; k < m; k++)
            {
                s0 += (f(a + (3 * k - 3) * h) + 

                    3 * f(a + (3 * k - 2) * h) + 

                    3 * f(a + (3 * k - 1) * h) + 

                    f(a + (3 * k) * h));
            }
            s0 *= ((3 * h) / 8);

            Console.WriteLine(s0);

            Console.ReadLine();
        }

        static double f(double x)
        {
            return Cos(x) / Log(x);
        }
    }
}
