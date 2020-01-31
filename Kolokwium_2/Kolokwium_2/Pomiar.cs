using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_2
{
    public class Pomiar
    {
        public double Temp { get; set; }
        public double Wilgotnosc { get; set; }
        public double PrWiatru { get; set; }
        public double Cisnienie { get; set; }

        public Pomiar(double temp, double wilgotnosc, double prWiatru, double cisnienie)
        {
            temp = Temp;
            wilgotnosc = Wilgotnosc;
            prWiatru = PrWiatru;
            cisnienie = Cisnienie;
        }
    }
}
