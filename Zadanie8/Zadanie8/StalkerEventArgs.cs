using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    public abstract class StalkerEventArgs : EventArgs
    {
        public int MaxAmmo { get; set; }

        public StalkerEventArgs(int maxAmmo)
        {
            MaxAmmo = 30;
        }
    }
}
