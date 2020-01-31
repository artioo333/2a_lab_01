using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1_v3
{
    class Zad03
    {
        public void Zad3(int [,] tab)
        {
            
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (0 > i || tab.GetLength(0) < i)
                    {
                        if (0 > j || tab.GetLength(1) > j)
                        {
                            tab[i, j] = tab[i - 1, j - 1] + tab[i - 1, j] + tab[i - 1, j + 1] + tab[i, j - 1] + tab[i, j] + tab[i, j + 1] + tab[i + 1, j - 1] + tab[i + 1, j] + tab[i + 1, j + 1];
                        }

                    }
                }
            }
            Konwertuj(tab);
            Console.WriteLine(tab);
            Console.ReadLine();
        }
        public void Konwertuj(int[,] tab)
        {
            int a = 0;
            int b = 0;
            int[,] tabX = new int[a, b];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (0 > i || tab.GetLength(0) < i)
                    {
                        if (0 > j || tab.GetLength(1) > j)
                        {
                            tab[i, j] = tabX[a, b];
                            a++;
                        }

                    }
                }
                b++;
            }
        }
    }
}
