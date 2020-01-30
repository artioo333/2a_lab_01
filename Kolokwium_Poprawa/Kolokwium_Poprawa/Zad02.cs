using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolokwium_Poprawa
{
    class Zad02
    {
        public void Zad2()
        {
            //Inicjalizacja i uzupełnienie tablicy
            int[] tab = new int[10];
            for (int i = 0; i < 9; i++)
            {
                tab[0] = 1;
                tab[i + 1] = 3;
                tab[2] += i;
                tab[3] -= i - 3;
            }

            //Zapisanie liczb z tablicy do słownika i wyciągnięcie liczby o największej ilości powtórzeń
            var occurencies = tab.GroupBy(x => x)
                .ToDictionary(group => group.Key, group => group.Count())
                .OrderByDescending(x => x.Value).First();

            Console.WriteLine($"Najczęściej występuje liczba {occurencies.Key}. Liczba wystąpień: {occurencies.Value}");
        }
    }
}
