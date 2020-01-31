using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1_v3
{
    class Program
    {
        static int K { get; set; }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie:");
            K = int.Parse(Console.ReadLine());
            switch(K)
            {
                case 1:
                    break;
                case 2:
                    double[] tab = { 3, 4, 3, 1, 4, 6, 8, 4, 2, 4, 6, 4 };
                    Zad02 xd2 = new Zad02();
                    xd2.Zad2(tab);
                    break;
                case 3:
                    int[,] tab2 = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
                    Zad03 xd3 = new Zad03();
                    xd3.Zad3(tab2);
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}
