using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());

            (int wynik, int reszta) = liczba.Podziel(3);
            Console.WriteLine($"{liczba}/3 = {wynik} | {reszta}");

            string text = "Ala ma kota";
            Console.WriteLine(text.Zlicz('a', true));
            Console.ReadKey();

            Reklama reklama = new Reklama("Kup teraz", TypOsoby.Dziecko | TypOsoby.Młodzierz | TypOsoby.Starszy, Zainteresowania.Gaming);
            reklama.Test();

        }
    }
}
