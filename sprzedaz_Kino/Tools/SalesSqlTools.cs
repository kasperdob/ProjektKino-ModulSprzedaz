using sprzedaz_Kino.SalesComponents;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprzedaz_Kino.Tools
{
    internal class SalesSqlTools
    {
        static string conString = "Data Source = DESKTOP-NDSJLTH; Initial Catalog = sprzedaz_kino; Integrated Security = True";
        static SqlConnection sqlConnection = new SqlConnection(ConString);

        public static string ConString { get => conString; set => conString = value; }
        public static SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }
    }
}
