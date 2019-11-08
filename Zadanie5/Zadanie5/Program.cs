using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Książka[,,] Magazyn = new Książka[3, 6, 10];
            for(int i = 0; i < 3; i++) {
                for (int n = 0; n < 6; n++) {
                    for (int o = 0; o < 10; o++) {
                        Magazyn[i,n,o] = new Książka("Potop", "Sienkiewicz", i,n,o);
                    }
                }
            }
            Magazyn[1,1,1] = new Książka()
            {
                Tytuł = "aaa",
                Autor = "aa",
                Regal = 1,
                Polka = 1,
                Miejsce = 1
            };
            Magazyn[2, 4, 8] = new Książka()
            {
                Tytuł = "Gra o Tron",
                Autor = "RR.Martin",
                Regal = 2,
                Polka = 4,
                Miejsce = 9
            };
            Console.WriteLine("Co potrzebne:");
            string Książka = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    for (int o = 0; o < 10; o++)
                    {
                        if(Magazyn[i, n, o].Tytuł == Książka || Magazyn[i, n, o].Autor == Książka)
                        {
                            Console.WriteLine("Na regale:" + i + "\t Na półce:" + n + "\t Na miejscu:" +  o);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
