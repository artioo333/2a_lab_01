using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Zad05
    {
        public Zad05(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }

        public string Autor { get; private set; }
        public string Tytul { get; private set; }
        public DateTime DataWydania { get; private set; }

        DateTime _DataOstaniegoZakupu;
        public DateTime DataOstatniegoZakupu
        {
            get
            {
                return _DataOstaniegoZakupu;
            }
            set
            {
                if (value.Date > _DataOstaniegoZakupu)
                {
                    _DataOstaniegoZakupu = value;
                }
            }
        }


        double _CenaStandardowa;
        public double CenaStandardowa
        {
            get
            {
                return _CenaStandardowa;
            }

            set
            {
                if (value > 0)
                {
                    _CenaStandardowa = value;
                }
                else
                {
                    Console.WriteLine("Cena nie może być ujemna.");
                }
            }

        }

        double _Obnizka;
        public double Obnizka
        {
            get
            {
                return _Obnizka;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _Obnizka = value;
                }
                else
                {
                    Console.WriteLine("Niepoprawna obniżka.");
                }
            }
        }

        public double AktualnaCena
        {
            get
            {
                return CenaStandardowa * ((100 - Obnizka) / 100);
            }
        }
    }
}
