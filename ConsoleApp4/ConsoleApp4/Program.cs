using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        static string WczytajLiczbe(string licznik)
        {
            Console.WriteLine("Podaj liczbę " + licznik + ":");
            String tekst = Console.ReadLine();
            return tekst;
        }
        public static void Main(string[] args)
        {
            string tekst1 = WczytajLiczbe("1");
            string tekst2 = WczytajLiczbe("2");
            
            Console.WriteLine("Wybierz operacje:");
            String operacja = Console.ReadLine();
            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);
            switch(operacja)
            {
                case "+":
                    int wynik1 = Kalkulator.Plus(tekst1, tekst2);
                    Console.WriteLine(wynik1);
                    break;
                case "-":
                    int wynik2 = Kalkulator.Minus(liczba1, liczba2);
                    Console.WriteLine(wynik2);
                    break;
                case "*":
                    int wynik3 = Kalkulator.Mnożenie(liczba1, liczba2);
                    Console.WriteLine(wynik3);
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine(Kalkulator.PodzielzWyjątkiem(liczba1, liczba2));
                    }
                    catch(DivideByZeroException)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    break;
                default:
                    break;       
            }
            Console.Read();
        }
    }
}
