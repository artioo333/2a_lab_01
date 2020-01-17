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
                    Zad1 xd = new Zad1();
                    xd.Zad01();
                    break;
                case 2:
                    Zad02 xd2 = new Zad02();
                    xd2.Zad2();
                    break;
            }
        }        
    }
}
