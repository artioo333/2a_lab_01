using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa
{
    class Zad1
    {
        static double K { get; set; }
        static double G { get; set; }
        public void Zad01()
        {
            Console.WriteLine("Wpisz wartość x z przediału [-1,1]");
            K = double.Parse(Console.ReadLine());

            if (K >= 1)
            {
                if (-1 >= K)
                {
                }
                else {Console.WriteLine("Zła wartość"); }
            }
            else { Console.WriteLine("Zła wartość"); }
            Console.WriteLine("Wpisz wartość y z przedziału [-1,1]");
            if (G >= 1)
            {
                if (-1 >= G)
                {
                }
                else { Console.WriteLine("Zła wartość"); }
            }
            else { Console.WriteLine("Zła wartość"); }
            G = double.Parse(Console.ReadLine());
            
            if ((K*K)+(G*G) <= 1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}
