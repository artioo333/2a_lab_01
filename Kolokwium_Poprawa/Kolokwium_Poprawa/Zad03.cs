using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa
{
    class Zad03
    {   
        static void GóraDół(int [,] wynik)
        {
            int gora = 0;
            int dol = 0;
            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.GetLength(1); j++)
                {
                    if (i<j)
                    {
                        gora += wynik[i, j];
                    }
                    else if (i>j)
                    {
                        dol += wynik[i, j];
                    }
                    else if (i == j)
                    {
                     
                    }
                    Console.Write(wynik[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Wynik z nad przekątnej {gora}");
            Console.WriteLine($"Wynik z pod przekątnej {dol}");
            if
                (gora>dol)
            {
                Console.WriteLine("Wynik górny jest większy");
            }
            else if (gora<dol)
            {
                Console.WriteLine("Wynik dolny jest większy");
            }
            else if (gora == dol)
            {
                Console.WriteLine("Są sobie równe");
            }
        }
        static int K { get; set; } 
        public void Zad3()
        {
            Console.WriteLine("Wpisz długość kwadratowej macieży:");
            K = int.Parse(Console.ReadLine());
            int[,] tab = new int[K, K];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    int rnd = new Random().Next(0, 9);
                    tab[i, j] = rnd;
                }
            }
            Console.Clear();
            Console.WriteLine("Przypadkowa macież kwadratowa");
            GóraDół(tab);
            Console.ReadLine();
        }
    }
}
