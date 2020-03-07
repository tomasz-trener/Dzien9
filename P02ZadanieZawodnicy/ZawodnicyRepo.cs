using P01AplikacjaZawodnicy.KlasyDomenowe;
using P06PolaczenieZBazaBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy.Repo
{
    class ZawodnicyRepo
    {
        public Zawodnik[] PodajWszystkichZawodnikow()
        {
            return PodajZawodnikow(""); 
        }

        public Zawodnik PodajZawodnikow(int id)
        {
            string connectionString =
              DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);
            string sql = "select z.id_zawodnika, z.imie, z.nazwisko, z.kraj, z.waga,z.wzrost, z.data_ur, " +
                "t.id_trenera, t.imie_t, t.nazwisko_t, t.data_ur_t " +
                "from zawodnicy z left join trenerzy t on z.id_trenera = t.id_trenera";

           
            sql += " where id_zawodnika = " + id;

            string[][] wynik = pzb.WykonajZapytanieSQL(sql);

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik z = new Zawodnik();
                z.Id = Convert.ToInt32(wynik[i][0]);
                z.Imie = wynik[i][1];
                z.Nazwisko = wynik[i][2];
                z.Kraj = wynik[i][3];
                if (wynik[i][4] != "")
                    z.Waga = Convert.ToDouble(wynik[i][4]);
                if (wynik[i][5] != "")
                    z.Wzrost = Convert.ToDouble(wynik[i][5]);
                if (wynik[i][6] != "")
                    z.DataUr = Convert.ToDateTime(wynik[i][6]);

                z.Trener = new Trener();
                if (wynik[i][7] != "")
                    z.Trener.Id = Convert.ToInt32(wynik[i][7]);
                z.Trener.Imie = wynik[i][8];
                z.Trener.Nazwisko = wynik[i][9];
                if (wynik[i][10] != "")
                    z.DataUr = Convert.ToDateTime(wynik[i][10]);

                zawodnicy[i] = z;


            }
            return zawodnicy[0];
        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            string connectionString =
              DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);
            string sql = "select z.id_zawodnika, z.imie, z.nazwisko, z.kraj, z.waga,z.wzrost, z.data_ur, " +
                "t.id_trenera, t.imie_t, t.nazwisko_t, t.data_ur_t "+
                "from zawodnicy z left join trenerzy t on z.id_trenera = t.id_trenera";

            if(kraj != "")
                sql += " where kraj = '" + kraj + "'";

            string[][] wynik = pzb.WykonajZapytanieSQL(sql);

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik z = new Zawodnik();
                z.Id = Convert.ToInt32(wynik[i][0]);
                z.Imie = wynik[i][1];
                z.Nazwisko = wynik[i][2];
                z.Kraj = wynik[i][3];
                if (wynik[i][4] != "")
                    z.Waga = Convert.ToDouble(wynik[i][4]);
                if (wynik[i][5] != "")
                    z.Wzrost = Convert.ToDouble(wynik[i][5]);
                if (wynik[i][6] != "")
                    z.DataUr = Convert.ToDateTime(wynik[i][6]);

                z.Trener = new Trener();
                if (wynik[i][7] != "")
                    z.Trener.Id = Convert.ToInt32(wynik[i][7]);
                z.Trener.Imie = wynik[i][8];
                z.Trener.Nazwisko = wynik[i][9];
                if(wynik[i][10] != "")
                    z.DataUr = Convert.ToDateTime(wynik[i][10]);

                zawodnicy[i] = z;


            }
            return zawodnicy;
        }

        public string[] PodajWszystkieKraje()
        {
            string connectionString =
                DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);

            string[][] wynik=
                pzb.WykonajZapytanieSQL("select distinct kraj from zawodnicy where kraj is not null");

            string[] kraje = new string[wynik.Length];
            for (int i = 0; i < wynik.Length; i++)
                kraje[i] = wynik[i][0];

            return kraje;
        }

        public Zawodnik[] PodajZawodnikow(ZawodnikFiltr zf)
        {
            string connectionString =
            "Data Source=.;Initial Catalog=A_zawodnicy;User ID=sa;Password=alx";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);
            string sql = 
                "select id_zawodnika, imie, nazwisko, kraj, waga,wzrost, data_ur from zawodnicy where 1=1";

            if (zf.Imie != "")
                sql += " and imie like '%" + zf.Imie+ "%'";

            if (zf.Nazwisko != "")
                sql += " and nazwisko like '%" + zf.Nazwisko + "%'";

            if (zf.Kraj != "")
               sql += " and kraj = '" + zf.Kraj+ "'";

            if (zf.WzrostOd != null)
                sql += " and wzrost >=" + zf.WzrostOd;

            if (zf.WzrostDo != null)
                sql += " and wzrost <=" + zf.WzrostDo;

            if (zf.WagaOd != null)
                sql += " and waga >=" + zf.WagaOd;

            if (zf.WagaDo != null)
                sql += " and waga <=" + zf.WagaDo;

            if (zf.DataUrOd != null)
                sql += " and data_ur >='" + zf.DataUrOd+"'";

            if (zf.DataUrDo != null)
                sql += " and data_ur <='" + zf.DataUrDo + "'";

            string[][] wynik = pzb.WykonajZapytanieSQL(sql);

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik z = new Zawodnik();
                z.Id = Convert.ToInt32(wynik[i][0]);
                z.Imie = wynik[i][1];
                z.Nazwisko = wynik[i][2];
                z.Kraj = wynik[i][3];
                if (wynik[i][4] != "")
                    z.Waga = Convert.ToDouble(wynik[i][4]);
                if (wynik[i][5] != "")
                    z.Wzrost = Convert.ToDouble(wynik[i][5]);
                if (wynik[i][6] != "")
                    z.DataUr = Convert.ToDateTime(wynik[i][6]);
                zawodnicy[i] = z;


            }
            return zawodnicy;
        }

        public void DodajZawodnika(Zawodnik z)
        {
            string connectionString =
              DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);
            string sql =
                string.Format("insert into zawodnicy (imie,nazwisko,kraj,wzrost,waga,data_ur)" +
                " values ('{0}','{1}','{2}',{3},{4},'{5}')",
                    z.Imie,z.Nazwisko,z.Kraj,z.Wzrost,z.Waga,z.DataUr
                );

            pzb.WykonajZapytanieSQL(sql);
                       
        }

        public void UsunZawodnika(int id)
        {
            string connectionString =
                DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);
            string sql = string.Format("delete zawodnicy where id_zawodnika = {0}", id);
            pzb.WykonajZapytanieSQL(sql);
        }

        public void EdytujZawodnika(Zawodnik z)
        {
            string connectionString =
                DaneDostepowe.ConnectionString;

            PolaczenieZBaza pzb = new PolaczenieZBaza(connectionString);
            string sql =
                string.Format("update zawodnicy set imie='{0}', nazwisko='{1}',kraj='{2}'" +
                " ,waga={3},wzrost={4},data_ur='{5}' where id_zawodnika = {6}",               
                    z.Imie, z.Nazwisko, z.Kraj, z.Waga, z.Wzrost, z.DataUr,z.Id
                );
            pzb.WykonajZapytanieSQL(sql);
        }
    }
}
