using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01Wstep
{
    public partial class StronaDruga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrzycisk_Click(object sender, EventArgs e)
        {
            string s = txtPoleTekstowe.Text;
            int a = Convert.ToInt32(s);
            a++;
            txtPoleTekstowe.Text = a.ToString();
        }
    }
}