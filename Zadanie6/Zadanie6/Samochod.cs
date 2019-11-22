using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    public class Samochod
    {
        public static int IloscModeli { get; private set; } = 0;
        public int VIN { get; private set; }
        public string Model;
        //private int _przebieg;
        /*  public int Przebieg {
              get { return _przebieg; }
              set
              {
                  if(value > _przebieg)
                  {
                      _przebieg = value;
                  }
              }
          }*/
        public int Przebieg { get; private set; }

        public void ZwiekszPrzebieg(int dystans)
        {
            if(dystans < 0)
            {
                throw new ArgumentException("Dystans nie może być ujemny");
            }
            Przebieg += Przebieg;
        }
        public int IloscDrzwi { get; private set; }

        public Samochod(int iloscDrzwi, int waga) : this("Passeratti", 0, iloscDrzwi, waga) { }
        public Samochod(string model, int przebieg, int iloscDrzwi, int waga) : this()
        {
            Model = model;
            Przebieg = przebieg;
            IloscDrzwi = iloscDrzwi;
            Waga = waga;
        }
        private Samochod()
        {
            VIN = IloscModeli++;
        }
        private int _waga;
        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;
                if(_waga < 0)
                {
                    _waga = 0;
                }
            }
        }
        public Samochod(int id)
        {
            //var dane = Baza.GetById(id)
            // Przebieg = dane.Przebieg;
        }
    }
}
