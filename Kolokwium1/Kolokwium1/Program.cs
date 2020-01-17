using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz numer Zadania:");
            int liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 1:
                    Console.Clear();
                    Zad01 xd = new Zad01();
                    xd.Zad1();
                    break;
                case 2:
                    Console.Clear();
                    Zad02 xd2 = new Zad02();
                    xd2.Zad2();
                    break;
                case 3:
                    Console.Clear();
                    Zad03 xd3 = new Zad03();
                    xd3.Zad3();
                    break;
                case 4:
                    Console.Clear();
                    Zad04 xd4 = new Zad04();
                    xd4.Zad4();
                    break;
                case 5:
                    Console.Clear();
                    var dat1 = new DateTime(2001, 04, 20);
                    var dat2 = new DateTime(2020, 01, 10);
                    Zad05 xd5 = new Zad05("J.K. Rowling", "Harry Pjoter: Czara Łognia", dat1, dat2, 49.99, 20);
                    Console.WriteLine(xd5.Autor);
                    Console.WriteLine(xd5.Tytul);
                    Console.WriteLine(xd5.AktualnaCena);
                    Console.WriteLine(xd5.DataOstatniegoZakupu);
                    Console.ReadLine();
                    break;
                default:

                    break;


            }

        }
    }
}
