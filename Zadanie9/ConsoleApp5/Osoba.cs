using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    [Flags]
    public enum TypOsoby
    {
        Brak = 0,
        Dziecko = 1,   //[0001]
        Młodzierz = 2, //[0010]
        Dorosły = 4,   //[0100]
        Starszy = 8    //[1000]
    }

    [Flags]
    public enum Zainteresowania
    {
        Narty,
        Rower,
        Gaming,
        Motoryzacja
    }
}
