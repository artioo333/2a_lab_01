using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    public class OutOfAmmoEventArgs : StalkerEventArgs
    {
        public int MaxAmmo { get; set; }
        public int BulletType { get; set; }

        public OutOfAmmoEventArgs(int bulletType, int maxAmmo) : base(maxAmmo)
        {

            BulletType = bulletType;
            MaxAmmo = maxAmmo;
        }
    }
}
