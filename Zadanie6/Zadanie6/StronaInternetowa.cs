using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class StronaInternetowa
    {
        // Strona Internetowa
        //  Serwer
        //      SzybkoscProcesora                   Dowolnie rozrzerzaj klasy
        //      Lacze                               Hermetyzuj co się da
        //      RAM
        //      Technologia
        //  Domena
        //      Nazwa
        //      Wazność : Datetime
        public StronaInternetowa(string serwer, string domena) : this()
            {
            Serwer = serwer;
            Domena = domena;
            }
        public string Serwer;
        public string Domena;
        private static readonly DateTime warznosc;

        private StronaInternetowa(int szybkoscProcesora, int lacze, int ram, string technologia, string NazwaDomeny, DateTime warznosc)
        {
            
        }

        public StronaInternetowa()
        {
        }

        public int SzybkoscProcesora { get; private set; }
        public int Lacze { get; private set; }
        public int RAM { get; private set; }
        public string technologia { get; private set; }
    }
}
