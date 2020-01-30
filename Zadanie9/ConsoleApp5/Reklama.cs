using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Reklama
    {
        public string Tresc;
        private TypOsoby typOsoby;
        private Zainteresowania zainteresowania;

        public Reklama(string tresc, TypOsoby typOsoby, Zainteresowania zainteresowania)
        {
            Tresc = tresc;
            this.typOsoby = typOsoby;
            this.zainteresowania = zainteresowania;
        }

        public void Test()
        {
            if (typOsoby.HasFlag(TypOsoby.Dziecko))
            {
                Console.WriteLine("Ta reklama jest dla dziecka");
            }
            if (typOsoby < TypOsoby.Dorosły)
            {
                Console.WriteLine("Ta reklama jest dla niepełnoletnich");
            }

            for (int i = 0; i < TypOsoby.Brak.SumaTypowOsob(); i++)
            {
                Console.WriteLine((TypOsoby)i);
            }
        }

    }
}
