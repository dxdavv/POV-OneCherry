using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Data;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Word;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Colors;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Pdf.Canvas;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using iText.Commons.Actions;
using System.Drawing.Printing;
namespace POV_OneCherry
{
    static class DBC
    {
        public static string? nombre { get; set; }
        public static string? DB { get; set; }

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
                    listaUsuarios.Add(item: reader.GetValue(0).ToString());
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
        public static void ticket(string idVenta, string query, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlConnection connection = GlobalDBConnecion();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDVenta", idVenta);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string usuario = reader["Usuario"].ToString();
                string fecha = reader["Fecha"].ToString();
                string nombreCliente = reader["Nombre_Cliente"].ToString();
                string idProducto = reader["ID_Producto"].ToString();
                string cantidad = reader["Cantidad"].ToString();
                string precio = reader["Precio"].ToString();
                string subtotal = reader["Subtotal"].ToString();
                string total = reader["Total"].ToString();
                string pagoCon = reader["PagoCon"].ToString();
                string cambio = reader["Cambio"].ToString();

                // Aquí puedes formatear los datos para tu ticket.
                string ticket = $"Ticket de Venta\n" +
                                $"ID Venta: {idVenta}\n" +
                                $"Usuario: {usuario}\n" +
                                $"Fecha: {fecha}\n" +
                                $"Nombre Cliente: {nombreCliente}\n" +
                                $"ID Producto: {idProducto}\n" +
                                $"Cantidad: {cantidad}\n" +
                                $"Precio: {precio}\n" +
                                $"Subtotal: {subtotal}\n" +
                                $"Total: {total}\n" +
                                $"Pago Con: {pagoCon}\n" +
                                $"Cambio: {cambio}";

                System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
                int y = 20;

                e.Graphics.DrawString("One Cherry", font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("ID Venta: " + idVenta, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Usuario: " + usuario, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Fecha: " + fecha, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Cliente: " + nombreCliente, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("ID Producto: " + idProducto, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Cantidad: " + cantidad, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Precio: $" + precio, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Subtotal: $" + subtotal, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("TOTAL: $" + total, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Pago con: $" + pagoCon, font, Brushes.Black, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString("Cambio a recibir: $" + cambio, font, Brushes.Black, new PointF(10, y));
                y += 40;
                e.Graphics.DrawString("*** Gracias por su compra ***", font, Brushes.Black, new PointF(10, y));
            }
        }
        public static void factura(string id)
        {
            string rutaArchivo = System.IO.Path.Combine(Application.StartupPath, "Resources", "factura.docx");

            using (WordprocessingDocument documento = WordprocessingDocument.Open(rutaArchivo, true))
            {
                Body cuerpo = documento.MainDocumentPart.Document.Body;

                // Agregar un nuevo párrafo al final del documento

                DocumentFormat.OpenXml.Wordprocessing.Paragraph nuevoParrafo = 
                    new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(
                        new DocumentFormat.OpenXml.Wordprocessing.Text("Este es el texto insertado en el documento.")));

                cuerpo.AppendChild(nuevoParrafo);

                // Guardar cambios
                documento.MainDocumentPart.Document.Save();
            }
        }
    }
}
