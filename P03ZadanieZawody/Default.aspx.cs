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
            if (!Page.IsPostBack)
            {
                ZawodnicyRepo zr = new ZawodnicyRepo();

                Zawodnik[] zawodnicy = zr.PodajWszystkichZawodnikow();

                lbZawodnicy.DataSource = zawodnicy;
                lbZawodnicy.DataValueField = "Id";
                lbZawodnicy.DataTextField = "ImieNazwisko";
                lbZawodnicy.DataBind();
            }
          


        }

        protected void lbZawodnicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idZaznaczonegoZawodnika = Convert.ToInt32(lbZawodnicy.SelectedValue);
            ZawodyRepo zr = new ZawodyRepo();
            string[] zawody= zr.PodajZawody(idZaznaczonegoZawodnika);
            lblZawody.Text = "";

            for (int i = 0; i < zawody.Length; i++)
                lblZawody.Text += zawody[i] + "<br>"; 
 

        }
    }
}