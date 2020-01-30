using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Osoba
    {
        public int ID;
        public string Imie;
        public string Nazwisko;
        public int Wiek;
        public string Kraj;

        public Osoba(int id, string imie, string nazwisko, int wiek, string kraj)
        {
            ID = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Kraj = kraj;
        }
    }
}
