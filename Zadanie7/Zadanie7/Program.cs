using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Zadanie7
{
    class Program
    {
//        public static void linq()
//        {
//            list<int> lista = enumerable.range(100, 150).tolist();
//            list<int> podzielneprzez3 = lista.where(x => x % 3 == 0).tolist();
//            double srednia = podzielneprzez3.average();
//            int suma = podzielneprzez3.sum();
//              foreach (var item in podzielneprzez3)
//              {
//                  console.writeline(item);
//              }
//  
        
//        console.writeline($"srednia to {srednia}");
//              console.writeline($"suma to {suma}");
//
//            int nrstrony = 2;
//            int elemnastronie = 10;
//            var strona = lista.skip(elemnastronie * (nrstrony)).take(elemnastronie);
//              foreach (var item in strona)
//            {
//                 console.writeline(item);
//              }
//
//            list<osoba> osoby = lista.select(
//                x => new osoba()
//                {
//                    id = x,
//                    imie =  x.tostring(),
//                    nazwisko = "aaa"
//                }
//            ).tolist();
//
//            osoby[45].nazwisko = "bbb";
//
//              foreach (var item in osoby)
//              {
//                  console.writeline($"{item.id}: {item.imie} {item.nazwisko}");
//              }
//
//            list<string> nazwiska = osoby.select(x => x.nazwisko).tolist();
//
//              foreach (var item in nazwiska)
//              {
//                  console.writeline(item);
//              }
//
//            list<string> unikalnenazwiska = osoby.select(x => x.nazwisko).distinct().tolist();
//
//              foreach (var item in unikalnenazwiska)
//              {
//                  console.writeline($"{item}");
//              }
//
//            osoba szukana = osoby.firstordefault(x => x.nazwisko == "ccc");
//   
//        }
        static void Main(string[] args)
        {

            var nameGen = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastNameGen = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var ageGen = RandomizerFactory.GetRandomizer(new FieldOptionsByte() {Min = 18, Max = 100});
            var countryGen = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());

            List<Osoba> osoby = Enumerable.Range(1, 1500)
                .Select(x => new Osoba(
                    x,
                    nameGen.Generate(),
                    lastNameGen.Generate(),
                    ageGen.Generate().Value,
                    countryGen.Generate())
                ).ToList();

            var posortowaneOsoby = osoby.OrderBy(x => x.Nazwisko).ThenBy(x => x.Imie).ThenBy(x => x.Wiek)
                .ThenBy(x => x.Kraj).ToList();

//            foreach (var item in posortowaneosoby)
//            {
//                console.writeline($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");
//            }

            Console.WriteLine("Podaj kraj");
            string kraj = Console.ReadLine();

            Console.WriteLine("Podaj minimalny wiek");
            bool min = int.TryParse(Console.ReadLine(), out int minWiek);
            if (min == false)
            {
                Console.WriteLine("Podano niepoprawny wiek");
            }

            Console.WriteLine("Podaj maksymalny wiek");
            bool max = int.TryParse(Console.ReadLine(), out int maxWiek);
            if (max == false)
            {
                Console.WriteLine("Podano niepoprawny wiek");
            }

            var szukanaOsoba = osoby.Where(x => x.Wiek > minWiek).Where(x => x.Wiek < maxWiek)
                .Where(x => x.Kraj == kraj)
                .ToList();

            foreach (var item in szukanaOsoba)
            {
                Console.WriteLine($"{item.ID}: {item.Imie} {item.Nazwisko} {item.Wiek} {item.Kraj}");
            }
        }
    }
}