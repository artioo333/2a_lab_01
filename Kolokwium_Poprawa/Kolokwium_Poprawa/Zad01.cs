using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa
{
    class Zad01
    {
        public void Zad1()
        {
            Zad111();
            Console.ReadLine();
        }
        public static bool Zad111()
        {
            Console.WriteLine("Podaj współrzędne z przedziału <-1,1>");
            Console.WriteLine("Podaj x: ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y: ");
            double y = Double.Parse(Console.ReadLine());

            if (x < -1 || x > 1 || y < -1 || y > 1)
            {
                Console.WriteLine("Podano złą wartość!");
                Console.WriteLine("Zamieniono liczby na x=-1 oraz y=1");
                x = -1;
                y = 1;
            }

            bool CzyWKole = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;

            return CzyWKole;

        }
    }
}
