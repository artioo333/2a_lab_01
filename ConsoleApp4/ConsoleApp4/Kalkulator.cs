using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Kalkulator
    {
       
        public static int Plus(int x, int y) { return (x + y); }
        public static int Plus(string x, string y)
        {
            int tekst1 = Convert.ToInt32(x);
            int tekst2 = Convert.ToInt32(y);
            return tekst1 + tekst2;
        }
        public static int Minus(int x, int y) { return (x - y); }
        public static int Mnożenie(int x, int y) { return (x * y); }
        public static double Dzielenie(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)x / y;
        }
        public static double PodzielzWyjątkiem(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)x / y;
        }
    }
}
