using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Zad01
    {
        public static int K { get; set; }
        public void Zad1()
        {
            Console.WriteLine("Podaj n: ");
            K = int.Parse(Console.ReadLine());
            double[] y = new double[K + 1];
            const int V = 1;
            Console.WriteLine("y[0]: 1");
            for (int n = 1; n < K + 1; n++)
            {
                y[0] = V;
                y[n] = 1.5 * (y[n - 1]) - 1;
                Console.WriteLine($"y[{n}]: " + y[n]);

            }
            Console.ReadKey();
        }
    }
}
