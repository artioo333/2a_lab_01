using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        private static bool _outOfAmmo = false;

        static void OutOfAmmoEventHandler(object sender, OutOfAmmoEventArgs args)
        {
            _outOfAmmo = true;
        }

        static void Main(string[] args)
        {
            var stalker = new Stalker();

            stalker.OutOfAmmo += OutOfAmmoEventHandler;

            for (int i = 0; i < 30; i++)
            {
                int ammo = 30;
                stalker.Shoot(ammo, i);
                if (_outOfAmmo)
                {
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
