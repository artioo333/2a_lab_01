using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1_v3
{
    class Zad02
    {
        public void Zad2(double[] tab)
        {
            double suma = 0;
            double srednia = 0;
            double[] a = new double[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] += suma; 
            }
            srednia = suma / tab.Length;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (tab[i] - srednia) * (tab[i] - srednia);
            }
            policz(a);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.ReadLine();
        }
        public void policz(double[] tab)
        {
            double suma = 0;
            double dochylenie;
            for (int i = 0; i < tab.Length ; i++)
            {
                suma += tab[i];
            }
            dochylenie = suma / tab.Length;
            Math.Sqrt(dochylenie);
        }
    }
}
