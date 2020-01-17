using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Zad03
    {
        public static int I { get; set; }
        public static int L { get; set; }
        public static int G { get; set; }
        public static int H { get; set; }
        public void Zad3()
        {
            Console.WriteLine("Wpisz wymiary Tablicy 1:");
            I = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());
            int[,] tab1 = new int[I, L];

            Console.WriteLine("Wpisz wymiary Tablicy 2:");
            G = int.Parse(Console.ReadLine());
            H = int.Parse(Console.ReadLine());
            int[,] tab2 = new int[G, H];

            Console.Clear();
            Console.WriteLine("Tablica Po dodaniu:");
            int x1 = Math.Max(tab1.GetLength(0), tab2.GetLength(0));
            int x2 = Math.Max(tab1.GetLength(1), tab2.GetLength(1));

            int[,] wynik = new int[x1, x2];

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = 1;
                    wynik[i, j] += tab1[i, j];
                }
            }

            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    tab2[i, j] = 1;
                    wynik[i, j] += tab2[i, j];
                }
            }

            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.GetLength(1); j++)
                {
                    Console.Write(wynik[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
