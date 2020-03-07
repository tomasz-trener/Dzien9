using P05AplikacjaZawodnicy.KlasyDomenowe;
using P05AplikacjaZawodnicy.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P05AplikacjaZawodnicy
{

    public partial class Zawodnicy : System.Web.UI.Page
    {
        public Zawodnik[] ZawodnicyLista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepo zr = new ZawodnicyRepo();
          //  ZawodnicyLista =  zr.PodajWszystkichZawodnikow();

            //tutaj napisz algorytm, który ustawi właściwość StylWyswietlania na bold albo normal,
            // dla kazdego zawodnika, w zaleznosci czy jest on najwyzszy czy nie w swoim kraju 



            List<Zawodnik> wszyscyZawodnicy = new List<Zawodnik>();
            string[] kraje = zr.PodajWszystkieKraje();
            for (int i = 0; i < kraje.Length; i++)
            {
               Zawodnik[] zawodnicyZKraju= zr.PodajZawodnikow(kraje[i]);

                double wzrost = 0;
                int aktualnieNajwyzszy=0;
                for (int j = 0; j < zawodnicyZKraju.Length; j++)
                {
                    if (zawodnicyZKraju[j].Wzrost > wzrost)
                    {
                        wzrost = zawodnicyZKraju[j].Wzrost;
                        aktualnieNajwyzszy = zawodnicyZKraju[j].Id;
                    }
                }

                for (int j = 0; j < zawodnicyZKraju.Length; j++)
                {
                    if (zawodnicyZKraju[j].Id == aktualnieNajwyzszy)
                        zawodnicyZKraju[j].StylWyswietlania = "bold";
                    else
                        zawodnicyZKraju[j].StylWyswietlania = "normal";

                    wszyscyZawodnicy.Add(zawodnicyZKraju[j]);
                }

                ZawodnicyLista = wszyscyZawodnicy.ToArray();
            }

        }
    }
}