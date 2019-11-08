using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static double Obliczenia(string nazwa)
        {
            string tekst = string.Empty;
            double suma = 0;
            int licznik = 0;

            Console.WriteLine("Wpisz oceny dla " + nazwa);

            while (tekst != "0")
            {
                tekst = Console.ReadLine();
                double ocena;
                bool czyPrzekonwertowano = double.TryParse(tekst, out ocena);
                if (czyPrzekonwertowano)
                {
                    if (ocena > 0 && ocena <= 5)
                    {
                        suma += ocena;
                        licznik++;
                    }
                    else Console.WriteLine("To nie jest poprawna ocena");
                }
                else Console.WriteLine("Podano Niepoprawną Liczbę");
            }
            double srednia = suma / licznik;
            Console.WriteLine("Średnia z " + nazwa + " to: " + String.Format("{0:N2}", srednia));
            return srednia;
        }
        static void Main(string[] args)
        {
            string[] przedmioty = { "MPIS", "PTC", "BOIO" };
            double[] srednie = new double[przedmioty.Length];
            for (int i = 0; i < przedmioty.Length; i++)
            {
                srednie[i] = Obliczenia(przedmioty[i]);
            }
            double sredniaCalkowita = 0;
            foreach (double sredniaCzastkowa in srednie)
            {
                sredniaCalkowita += sredniaCzastkowa;
            }

            Console.WriteLine("Średnia całkowita: " + String.Format("{0:N2}", sredniaCalkowita / przedmioty.Length));



            Console.ReadLine();
        }
    }
}