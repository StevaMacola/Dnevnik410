using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Dnevnik410A
{
    internal class Konekcija
    {
            public static SqlConnection povezi()
            {
                string CS;
                CS = ConfigurationManager.ConnectionStrings["skola"].ConnectionString;
                SqlConnection veza = new SqlConnection(CS);
                return veza;
            }

    }
}
