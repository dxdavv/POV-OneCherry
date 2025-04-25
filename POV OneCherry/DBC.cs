using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace POV_OneCherry
{
    static class DBC
    {
        public static string nombre { get; set; }
        public static string DB { get; set; }

        public static SqlConnection GlobalDBConnecion()
        {
            string connectionString = "Server=" + nombre + "\\SQLEXPRESS" + ";Database=" + DB + ";Trusted_Connection=True;";
            SqlConnection c = new SqlConnection(connectionString);
            return c;
        }
        public static SqlDataAdapter CreateAdapter (string query, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            return adapter;
        }
    }

}
