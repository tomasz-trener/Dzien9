using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy.KlasyDomenowe
{
    public class Zawodnik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public double Waga { get; set; }
        public double Wzrost { get; set; }

        public DateTime DataUr { get; set; }

        public Trener Trener;

        public string WszystkiePola
        {
            get
            {
                return Id + " " + Imie + " " + Nazwisko +
                    " " + Kraj + " " + Waga + " " + Wzrost;
            }

        }
    }
}
