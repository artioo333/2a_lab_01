using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    public class Książka
    {
        public string Tytuł;
        public string Autor;
        public int Regal;
        public int Polka;
        public int Miejsce;

        public Książka(string tytuł, string autor, int regal, int polka, int miejsce)
        {
            Tytuł = tytuł;
            Autor = autor;
            Regal = regal;
            Polka = polka;
            Miejsce = miejsce;
        }
        public Książka()
        {

        }
    }
}
