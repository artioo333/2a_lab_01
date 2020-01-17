using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Zad04
    {
        static void Najmniejsza(int[,] tablica)
        {
            int min = tablica[0, 0];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i, j] < min)
                    {
                        min = tablica[i, j];
                    }
                }
            }
            Console.WriteLine($"Najmniejszy element tablicy: {min}");
        }
        public static int I { get; set; }
        public static int L { get; set; }
        public void Zad4()
        {
            Console.WriteLine("Wpisz wymiary Tablicy :");
            I = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());
            int[,] Nowa = new int[I, L];

            for (int i = 0; i < Nowa.GetLength(0); i++)
            {
                for (int j = 0; j < Nowa.GetLength(1); j++)
                {
                    int rnd = new Random().Next(0, 9);
                    Nowa[i, j] = rnd;
                    Console.Write(Nowa[i, j] + " ");
                }
                Console.WriteLine();
            }
            Najmniejsza(Nowa);
            Console.ReadLine();
        }
    }
}
