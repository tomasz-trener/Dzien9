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
            ZawodnicyLista =  zr.PodajWszystkichZawodnikow();

            //tutaj napisz algorytm, który ustawi właściwość StylWyswietlania na bold albo normal,
            // dla kazdego zawodnika, w zaleznosci czy jest on najwyzszy czy nie w swoim kraju 



        }
    }
}