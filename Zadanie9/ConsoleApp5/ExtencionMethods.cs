using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public static class ExtencionMethods
    {
        public static (int, int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna / dzielnik, dzielna % dzielnik);
        }

        public static int Znaki(this string ciag, char znak)
        {
            return ciag.Where(x => x.Equals(znak)).Count();
        }

        public static int Zlicz(this string ciag, char znak, bool caseInvariant)
        {
            caseInvariant = Char.IsUpper(znak);
            if (caseInvariant)
            {
                ciag = ciag.ToLower();
                znak = char.ToLower(znak);
            }
            return ciag.Znaki(znak);
        }

        public static int SumaTypowOsob(this TypOsoby Typ)
        {
            //int suma = 0;
            //foreach (var item in Enum.GetValues(typeof(TypOsoby)))
            //{
            //    suma += (int)item;
            //}
            //return suma;

            return Enum.GetValues(typeof(TypOsoby)).Cast<TypOsoby>().Sum(x => (int)x);
        }

        public static int SumaEnum<T>(this T typ) where T : System.Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<int>()
                .Sum();
        }

    }
}
