using P03ZadanieZawody.KlasyDomenowe;
using P03ZadanieZawody.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03ZadanieZawody
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepo zr = new ZawodnicyRepo();

            Zawodnik[] zawodnicy =  zr.PodajWszystkichZawodnikow();

            lbZawodnicy.DataSource = zawodnicy;
            lbZawodnicy.DataValueField = "Id";
            lbZawodnicy.DataTextField = "ImieNazwisko";
            lbZawodnicy.DataBind();
        }
    }
}