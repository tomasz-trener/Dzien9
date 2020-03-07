using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy.Repo
{
    class DaneDostepowe
    {
        public static string ConnectionString =
            System.Configuration.ConfigurationManager.
                ConnectionStrings["polaczenieZBaza"].ConnectionString;
        //   = "Data Source=.;Initial Catalog=A_zawodnicy;User ID=sa;Password=alx";
    }
}
