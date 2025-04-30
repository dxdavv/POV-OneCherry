using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Data;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Word;
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
        public static DataTable Data(string query, bool needCommand = false)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GlobalDBConnecion();
            SqlDataAdapter adapter;
            connection.Open();
            if (needCommand)
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                adapter = new SqlDataAdapter(cmd);
            } else
            {
                adapter = new SqlDataAdapter(query, connection);
            }
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static int EditData(string query)
        {
            int rowsAffected;
            SqlConnection conn = GlobalDBConnecion();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return rowsAffected;
        }
        public static void SentToExcel(string query, string ventana)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.Title = "Guardar Excel";
                sfd.FileName = $"{ventana}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add(DBC.Data(query, true), "Todas las ventas");
                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("El Excel se guardo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static string[] GetData(string query)
        {
            List<string> listaUsuarios = new List<string>();
            SqlConnection conn = GlobalDBConnecion();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetValue(0).ToString());
                    listaUsuarios.Add(reader.GetValue(0).ToString());
                }
            }
            conn.Close();
            if (listaUsuarios.Count == 0)
            {
                return [""];
            }
            return listaUsuarios.ToArray();
        }
        public static string queryBuscar(string query, string buscarEn, string datoABuscar)
        {
            query += $" WHERE {buscarEn} LIKE ('%{datoABuscar}%')";
            // [A-Za-z0-9]%
            //  ORDER BY {buscarEn}
            return query;
        }
    }

}
