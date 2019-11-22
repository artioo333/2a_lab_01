using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arg1();
            {
                Console.WriteLine();
            }
        }
        public static void Arg1()
        {
            Console.WriteLine("Podaj wartość n:");
            int n = 10;
            double[] y = new double[n];
            for (int i = n; 0 < i; i--)
            {
                y[n] = 1.5 * (y[i - 1]) - 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(y[i] = y[n]);
            }
        }
    }

        public static void Arg2()
        {
            int[] tab = new int[200];
            for (int i = 1; i < 200; i++)
            {
                tab[i] = i;
                Console.WriteLine(tab[i] + " ");
            }
        }
        public void Arg3()
        {

        }
    }
}
