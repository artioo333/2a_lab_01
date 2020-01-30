using System;

namespace Kolokwium_Poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 1:
                    Zad01 xd = new Zad01();
                    xd.Zad1();
                    break;
                case 2:
                    Zad02 xd2 = new Zad02();
                    xd2.Zad2();
                    break;
                case 3:
                    Zad03 xd3 = new Zad03();
                    xd3.Zad3();
                    break;
                case 4:
                    KontoBankowe Konto = new KontoBankowe("Artur", "Bednarczyk");
                    void stanKonta()
                    {
                        Console.WriteLine($" Stan konta na dzień dzisiejszy wynosi {Konto.Stan}zł. ");
                    }
                    Console.Write("Właścicielem konta o numerze ");
                    Konto.NrKont();
                    Console.Write($" jest {Konto.Imie} {Konto.Nazwisko}.");

                    Console.WriteLine();
                    stanKonta();
                    Console.ReadLine();
                    break;
            }
        }        
    }
}
