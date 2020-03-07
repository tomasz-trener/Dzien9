
using P03ZadanieZawody.KlasyDomenowe;
using P06PolaczenieZBazaBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieZawody.Repo
{
    class ZawodyRepo
    {
        
        public string[] PodajZawody(int id)
        {
            string connectionString =
             DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);

            string sql = string.Format(@"select zw.nazwa 
                            from zawodnicy z left
                            join uczestnictwa u on
                            z.id_zawodnika = u.id_zawodnika
                            left
                            join zawody zw on zw.id_zawodow = u.id_zawodow
                             where z.id_zawodnika = {0}", id);

            string[][] wynikZBazy = pzb.WykonajZapytanieSQL(sql);

            string[] wynik = new string[wynikZBazy.Length];
            for (int i = 0; i < wynikZBazy.Length; i++)
                wynik[i] = wynikZBazy[i][0];

            return wynik;
        }

      
    }
}
