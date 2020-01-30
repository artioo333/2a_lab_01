using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_Poprawa
{
    class KontoBankowe
    {
        private readonly string _imie;
        private readonly string _nazwisko;
        private readonly int[] _nrKonta = new int[26];
        private int _num = 0;

        public string Imie => _imie;
        public string Nazwisko => _nazwisko;
        public int[] NrKonta => _nrKonta;
        public double Stan { get; set; }

        private double[] Historia = new double[100];

        private void addToHistoria(int nr, double kwota)
        {
            Historia[nr] = kwota;
            if (nr > 100)
            {
                _num = 0;
            }
        }

        public void Uznanie(double wiecej)
        {
            Stan += wiecej;
            _num++;
            addToHistoria(_num, wiecej);
        }

        public void Obciazenie(double mniej)
        {
            if (Stan - mniej > -100.00)
            {
                Stan -= mniej;
                _num++;
                addToHistoria(_num, -mniej);
            }
            else
            {
                Console.WriteLine($"Nie można wziąć większego debetu. Aktualny debet: {Stan}");
            }
        }

        public KontoBankowe(string imie, string nazwisko) : this()
        {
            _imie = imie;
            _nazwisko = nazwisko;
        }

        public void NrKont()
        {
            for (int i = 0; i < NrKonta.Length; i++)
            {
                int rnd = new Random().Next(0, 9);
                _nrKonta[i] = rnd;
                Console.Write(NrKonta[i]);
            }
        }

        private KontoBankowe()
        {

            bool czyUzupelniono = false;

            int[] whyItDoesNotWork = new int[26];

            whyItDoesNotWork = _nrKonta;

            for (int i = 25; i >= 0; i--)
            {
                do
                {
                    if (whyItDoesNotWork[i] == 9)
                    {
                        whyItDoesNotWork[i] = 0;
                    }
                    else
                    {
                        whyItDoesNotWork[i] += 1;
                        czyUzupelniono = true;
                    }
                } while (!czyUzupelniono);
            }

            _nrKonta = whyItDoesNotWork;
        }
    }
}
