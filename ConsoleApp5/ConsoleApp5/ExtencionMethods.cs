using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public static class ExtencionMethods
    {  
        public static(int,int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna/dzielnik, dzielna % dzielnik);
        }

        public static int Zlicz2(this string Parametr, char character)
        {
            return Parametr.Where(x => x.Equals(character)).Count();
        }

        public static int Zlicz(this string text, char character,bool caseInVariant = true)
        {
            if(caseInVariant)
            {
                text = text.ToLower();
                character = char.ToLower(character);
            }
            return text.Zlicz(character);
        }
        
        public static int SumaTyp(this TypOsoby typ)
        {
            return Enum.GetValues(typeof(TypOsoby)).Cast<TypOsoby>().Sum(x => (int)x);
        }

        public static int SumaEnum<T>(this T typ) where T: System.Enum
        {
            return Enum.GetValues(typeof(T)).Cast<int>().Sum(x => x);
        }

    }
}
