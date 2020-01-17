using System;

namespace ConsoleApp1
{
    class Program
    {
        static double ObliczCeneBiletu (object pasazer)
        {
            switch (pasazer)
            {
                case ZwykłyPasazer zp:
                    Console.WriteLine("pasazer z pełną ceną biletu");
                    break;
                case Dziecko d:
                    Console.WriteLine($"to jest dziecko. ma znizke {d.Znizka}");
                    break;
                case OsobaStarsza osc when osc.ZwolnienieZOplat:
                    Console.WriteLine("to jest osoba starsza \n Ma darmowe przejazdy");
                    break;
                case OsobaStarsza _:
                    Console.WriteLine("to jest osoba starsza");
                    break;
                case null:
                    Console.WriteLine("Nie wiem nie pomogę");
                    break;
                case Recista r when r.ZwolnienieZOplat:
                    if (r.WaznoscRenty >= DateTime.Now)
                    {
                        Console.WriteLine("Ma darmowy przejazd i ważną rentę");
                    }
                    else
                    {
                        Console.WriteLine("Rencista z pełną ceną biletu");
                    }
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            /*
            var pasazer = new ZwykłyPasazer();
            var dziecko = new Dziecko() { Znizka = 0.5 };
            var emeryt = new OsobaStarsza() { ZwolnienieZOplat = true };
            var rencista = new Recista() { ZwolnienieZOplat = true, WaznoscRenty = new DateTime(2021,12,31)};
            var rencista2 = new Recista() { ZwolnienieZOplat = true, WaznoscRenty = new DateTime(2019,12,31)};
            var rencista3 = new Recista() { ZwolnienieZOplat = true, WaznoscRenty = DateTime.Now };

            ObliczCeneBiletu(pasazer);
            ObliczCeneBiletu(dziecko);
            ObliczCeneBiletu(emeryt);
            ObliczCeneBiletu("Zwykły pasazr");
            ObliczCeneBiletu(null);
            ObliczCeneBiletu(rencista);
            ObliczCeneBiletu(rencista2);
            ObliczCeneBiletu(rencista3);
            Console.ReadLine();
            */
            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "1234567890",
                ZwolnienieZOplat = true,
                DataUrodzenia = new DateTime(1960, 05, 10),
                AdresZdjecia = "/images/photos/1234567890.jpg"
            };
            var student = new Dziecko() {   DataUrodzenia = new DateTime(2007,04,20),Imie = "Adrian"};
            //Dekonstrukcja przykłady
            (string Legitymacja,bool darmoszka, DateTime Urodz, string fotka) = osoba.ZwrocWszystkieDane();
            var (Leg, obnizka, dataUr, zdjecieRencisty) = osoba.ZwrocWszystkieDane();
            var temp = osoba.ZwrocWszystkieDane();
            Console.WriteLine($"{temp.Legita} {temp.adresDoZdjec}");
            (_, bool darmowy, DateTime UrodzinkiData, string Zdjecie) = osoba.ZwrocWszystkieDane();

            var (nrLegity, zwolnionko, DataUr, zdjecie) = osoba;
            var (nrlegity, Focia) = osoba;
            var(adrian,Data) = student;

            Console.ReadLine();

        }
    }
}
