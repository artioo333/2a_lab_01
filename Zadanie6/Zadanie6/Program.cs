using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void OpiszSamochod(Samochod auto)
        {
            Console.WriteLine("["+ auto.VIN + "]"+ auto.Model + ": " + auto.Przebieg + "km " + "Ilość Drzwi: " + auto.IloscDrzwi + "  Waga: " + auto.Waga + " kg");
        }
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("Passeratti", 100000, 4, 1500);
            Samochod s2 = new Samochod("Mustang", 1000, 4, 2000);
            Samochod s3 = new Samochod("Mini", 50000, 4, 1600);
            Samochod nowyPassat = new Samochod(4, 2000);


            OpiszSamochod(s1);
            OpiszSamochod(s2);
            OpiszSamochod(s3);
            OpiszSamochod(nowyPassat);
            Console.WriteLine("Wyprodukowano: " + Samochod.IloscModeli);
            Console.Read();
            
        }
    }
}
