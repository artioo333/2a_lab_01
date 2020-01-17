using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class OsobaStarsza
    {
        public bool ZwolnienieZOplat { get; set; }
        public string NrLegitymacji { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZdjecia { get; set; }
        

        public (string Legita,bool rabacik,DateTime urodzinki, string adresDoZdjec) ZwrocWszystkieDane()
        {
            return (NrLegitymacji,ZwolnienieZOplat,DataUrodzenia,AdresZdjecia);
        }

        public void Deconstruct(out string Legita, out string adresDoZdjec)
        {
            Legita = NrLegitymacji;
            adresDoZdjec = AdresZdjecia;
        }

        public void Deconstruct(out string Legita,out bool rabacik,out DateTime urodzinki,out string adresDoZdjec)
        {
            Legita = NrLegitymacji;
            rabacik = ZwolnienieZOplat;
            urodzinki = DataUrodzenia;
            adresDoZdjec = AdresZdjecia;
        }
    }
}
