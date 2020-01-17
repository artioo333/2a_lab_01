using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Zad02
    {
        public static double G { get; set; }
        public void Zad2()
        {
            Console.WriteLine("Podaj Dzielnik: ");
            G = double.Parse(Console.ReadLine());
            double[] q = new double[200];
            int a = 1;

            for (int i = 0; i < q.Length; i++)
            {
                q[i] = a;
                if (q[i] % G == 0)
                {
                    Console.WriteLine("q[" + i + "]:" + a);
                }
                a++;
            }
            Console.ReadKey();
        }
    }
}
