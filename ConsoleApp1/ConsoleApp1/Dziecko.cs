using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Dziecko
    {
        public double Znizka { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Imie { get; set; }

        public void Deconstruct(out string firstname,out DateTime urodzinki)
        {
            firstname = Imie;
            urodzinki = DataUrodzenia;
            if (12 <(DateTime.Now.Year - DataUrodzenia.Year) && 18 >= (DateTime.Now.Year - DataUrodzenia.Year) )
            {
                Console.WriteLine("Podstawówka");
            }
            else if (18 < (DateTime.Now.Year - DataUrodzenia.Year) && 20 >= (DateTime.Now.Year - DataUrodzenia.Year))
            {
                Console.WriteLine("Liceum");
            }
            else if (20 <(DateTime.Now.Year - DataUrodzenia.Year) && 26 >= (DateTime.Now.Year - DataUrodzenia.Year))
            {
                Console.WriteLine("Wyższa Szkoła Opierdalania");
            }
        }
    }
}
