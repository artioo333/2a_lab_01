using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa
{
    class KontoBankowe
    {
        public KontoBankowe(string imie,string nazwiszko,double nrkonta, double stan)
        {
            Imie = imie;
            Nazwiszko = nazwiszko;
            NrKonta = nrkonta;
        }
        public string Imie { get; private set; }
        public string Nazwiszko { get; private set; }
        public double NrKonta {
            get
            {
                double xd = new Random(26).Next();
                return xd;
            }
            private set
            {
            }
                
        }
        public double stan {
            get
            {
                if (stan < -100)
                {
                    Console.WriteLine("Zbyt duży debet");
                }
            }
            set
            {

            }
        }
    }
}
