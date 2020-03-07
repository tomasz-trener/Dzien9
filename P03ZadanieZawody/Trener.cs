using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieZawody.KlasyDomenowe
{
    public class Trener
    {
        public int Id;
        public string Imie;
        public string Nazwisko;
        public DateTime DataUr;

        public string ImieNazwisko { get { return Imie + " " + Nazwisko; } }
    }
}
