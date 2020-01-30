using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    public class Stalker
    {
        public event EventHandler<OutOfAmmoEventArgs> OutOfAmmo;

        private List<Ammo> _ammoTypes;

        public class Ammo
        {
            public string Type { get; set; }

            public Ammo(string type)
            {
                Type = type;
            }
        }

        public int loadedBullets = 30;

        public void OutOfAmmoInternalEventHandler(object sender, OutOfAmmoEventArgs args)
        {
            Console.WriteLine();
            Console.WriteLine("You run out of bullets, Stalker. Let's pray there are no mutants nearby while you reload." +
                              "Which type of bullet you want to load:" +
                              $"\n1. {_ammoTypes[0].Type}" +
                              $"\n2. {_ammoTypes[1].Type}" +
                              $"\n3. {_ammoTypes[2].Type}");
            Console.WriteLine();

            int type = int.Parse(Console.ReadLine());
            loadedBullets = 30;

            Console.WriteLine($"You have loaded {_ammoTypes[type - 1].Type} ammo. You have {loadedBullets} bullets in your mag.");
        }

        public Stalker()
        {
            _ammoTypes = new List<Ammo>()
            {
                new Ammo("Full Metal Jacket"),
                new Ammo("Armor Piercing"),
                new Ammo("Hollow Point")
            };

            OutOfAmmo += OutOfAmmoInternalEventHandler;
        }

        // public List<Mutants> _mutants;
        // public class Mutants
        // {
        //     public string Mutant { get; set; }
        //
        //     public Mutants(string mutant)
        //     {
        //         Mutant = mutant;
        //     }
        // }
        //
        // public Mutant()
        // {
        //     _mutants = new List<Mutants>()
        //     {
        //         new Mutants("Bloodsucker"),
        //         new Mutants("Controler"),
        //         new Mutants("Pseudogiant")
        //     };
        // }
        public void Shoot(int ammoType, int maxAmmo)
        {
            Random rnd = new Random();
            int mutant = rnd.Next(1, 4);
            switch (mutant)
            {
                case 1:
                    Console.WriteLine("Bloodsucker incoming, better keep low.");
                    loadedBullets -= 10;
                    break;

                case 2:
                    Console.WriteLine("It's just a lone blind dog, nothing to worry about.");
                    loadedBullets -= 5;
                    break;

                case 3:
                    Console.WriteLine("Oh God Oh Fuck... It's Pseudogiant, RUN!!!");
                    break;
            }

            if (loadedBullets < 1)
            {
                OutOfAmmo.Invoke(this, new OutOfAmmoEventArgs(ammoType, maxAmmo));
            }


        }
    }
}
