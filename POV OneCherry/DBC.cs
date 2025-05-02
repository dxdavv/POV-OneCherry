using System.Data.SqlClient;
using System.Data;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using Rectangle = iTextSharp.text.Rectangle;
using Font = iTextSharp.text.Font;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using iText.Layout.Borders;
using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
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
        public static void ticket(string idVenta)
        {
            string rutaPDF = Path.Combine(Application.StartupPath, "Resources", "ticket.pdf");
            string rutaSalida = "ticket_completo.pdf";

            using (PdfReader reader = new PdfReader(rutaPDF))
            using (FileStream fs = new FileStream(rutaSalida, FileMode.Create, FileAccess.Write, FileShare.None))
            using (PdfStamper stamper = new PdfStamper(reader, fs))
            {
                using (SqlConnection connection = GlobalDBConnecion())
                {
                    connection.Open();
                    int filas = 0;
                    string queryArticulosCount = "SELECT COUNT(*) FROM DetallesVenta WHERE ID_Ventas = @IDVenta";
                    using (SqlCommand countCommand = new SqlCommand(queryArticulosCount, connection))
                    {
                        countCommand.Parameters.AddWithValue("@IDVenta", idVenta);
                        filas = (int)countCommand.ExecuteScalar();
                    }
                    int espacioExtra = filas * 15; // Cada fila ocupa aproximadamente 15 unidades de espacio
                    Rectangle nuevoTamano = new Rectangle(reader.GetPageSize(1).Width, reader.GetPageSize(1).Height + espacioExtra);

                    string queryVenta = "SELECT Empleados.NombreApellido, Ventas.FechaVenta, " +
                        "CONCAT(Clientes.Nombre, ' ', Clientes.Apellido) AS Nombre_Cliente, " +
                        "Ventas.TotalVenta FROM Ventas " +
                        "JOIN Clientes ON Ventas.ID_Clientes = Clientes.ID_Clientes " +
                        "JOIN Empleados ON Ventas.ID_Empleados = Empleados.ID_Empleados " +
                        "WHERE ID_Ventas = @IDVenta";
                    string queryArticulos = "SELECT DetallesVenta.ID_Productos, Productos.NombreProducto, " +
                        "DetallesVenta.Cantidad, DetallesVenta.PrecioUnidad, DetallesVenta.SubTotal FROM DetallesVenta " +
                        "JOIN Productos ON DetallesVenta.ID_Productos = Productos.ID_Productos " +
                        "WHERE ID_Ventas = @IDVenta";

                    using (SqlCommand command = new SqlCommand(queryVenta, connection))
                    {
                        command.Parameters.AddWithValue("@IDVenta", idVenta);
                        SqlDataReader readerVenta = command.ExecuteReader();

                        PdfContentByte canvas = stamper.GetOverContent(1);
                        canvas.BeginText();
                        canvas.SetFontAndSize(BaseFont.CreateFont(), 15);
                        if (readerVenta.Read())
                        {
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, idVenta, 115, 446, 0);
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, readerVenta["NombreApellido"].ToString(), 105, 423, 0);
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, readerVenta["FechaVenta"].ToString(), 86, 400, 0);
                            canvas.ShowTextAligned(Element.ALIGN_LEFT, readerVenta["Nombre_Cliente"].ToString(), 178, 376, 0);
                        }
                        canvas.EndText();
                        readerVenta.Close();
                        
                    }

                    using (SqlCommand command = new SqlCommand(queryArticulos, connection))
                    {
                        command.Parameters.AddWithValue("@IDVenta", idVenta);
                        SqlDataReader readerArticulos = command.ExecuteReader();

                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("productos.pdf", FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(5);
                        table.WidthPercentage = 90;
                        table.SetWidths(new float[] { 0.2f, 1f, 0.5f, 1f, 1f });
                        table.DefaultCell.BorderWidth = 0f;


                        while (readerArticulos.Read())
                        {
                            table.AddCell(readerArticulos["ID_Productos"].ToString());
                            table.AddCell(readerArticulos["NombreProducto"].ToString());
                            table.AddCell(readerArticulos["PrecioUnidad"].ToString());
                            table.AddCell(readerArticulos["Cantidad"].ToString());
                            table.AddCell(readerArticulos["SubTotal"].ToString());
                        }

                        doc.Add(table);
                        doc.Close();
                        readerArticulos.Close();
                        //table.WriteSelectedRows(0, -1, 50, 900 - espacioExtra, stamper.GetOverContent(1));
                        PdfReader readerProductos = new PdfReader("productos.pdf");

                        //PdfReader readerProductos = new PdfReader(productosPDF);
                        PdfContentByte canvas = stamper.GetOverContent(1);
                        PdfImportedPage page = stamper.GetImportedPage(readerProductos, 1);
                        canvas.AddTemplate(page, -55, 90);

                        // Posición en el ticket (ajustar según tu diseño)

                    }
                }

                stamper.FormFlattening = true;
                stamper.Close();
                ImprimirPDF(rutaSalida);
            }
        }

        public static void ImprimirTicket(string idVenta)
        {
            string rutaSalida = "ticket_completo.pdf";

            int filas = 0;
            SqlConnection conn = DBC.GlobalDBConnecion();
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM DetallesVenta WHERE ID_Ventas = @IDVenta", conn))
            {
                conn.Open();
                command.Parameters.AddWithValue("@IDVenta", idVenta);
                filas = (int)command.ExecuteScalar(); // Obtiene el número de filas en la venta
                conn.Close();
            }

            using (FileStream fs = new FileStream(rutaSalida, FileMode.Create))
            using (Document doc = new Document(new Rectangle(300, 290 + (filas * 20)))) // Tamaño inicial del ticket
            using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
            {
                doc.Open();

                // **1️⃣ CABECERA DEL TICKET**
                PdfPTable headerTable = new PdfPTable(1);
                headerTable.WidthPercentage = 130;

                using (SqlConnection connection = DBC.GlobalDBConnecion())
                {
                    connection.Open();

                    // Obtener datos de la venta, cliente y promoción
                    string queryVenta = @"SELECT 
                                V.ID_Ventas, V.FechaVenta, 
                                C.Nombre + ' ' + C.Apellido AS Nombre_Cliente, 
                                E.NombreApellido AS Nombre_Empleado, 
                                P.NombrePromocion, P.Descuento, V.TotalVenta
                            FROM Ventas V
                            JOIN Clientes C ON V.ID_Clientes = C.ID_Clientes
                            JOIN Empleados E ON V.ID_Empleados = E.ID_Empleados
                            LEFT JOIN Promociones P ON V.ID_Promociones = P.ID_Promociones
                            WHERE V.ID_Ventas = @IDVenta";

                    using (SqlCommand command = new SqlCommand(queryVenta, connection))
                    {
                        command.Parameters.AddWithValue("@IDVenta", idVenta);
                        SqlDataReader readerVenta = command.ExecuteReader();

                        if (readerVenta.Read())
                        {
                            headerTable.AddCell(new PdfPCell(new Phrase(new Chunk("One Cherry\n ", FontFactory.GetFont(FontFactory.HELVETICA, 20, Font.BOLD, new BaseColor(214, 0, 43)))))
                            {
                                Border = Rectangle.NO_BORDER,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            });

                            headerTable.AddCell(new PdfPCell(new Phrase(new Chunk($"Venta ID: {idVenta}\nFecha: {readerVenta["FechaVenta"].ToString().Remove(10)}\nCliente: {readerVenta["Nombre_Cliente"]}\nEmpleado: {readerVenta["Nombre_Empleado"]}\n ",FontFactory.GetFont(FontFactory.HELVETICA, 12))))
                            {
                                Border = Rectangle.NO_BORDER,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            });
                            doc.Add(headerTable);
                        }
                        readerVenta.Close();
                    }
                    // **2️⃣ TABLA DE PRODUCTOS**
                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 130;
                    table.SetWidths(new float[] { 0.2f, 1f, 0.3f, 0.3f, 0.3f });
                    table.DefaultCell.BorderWidth = 0f;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(new PdfPCell(new Phrase(new Chunk("ID", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));
                    table.AddCell(new PdfPCell(new Phrase(new Chunk("Producto", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));
                    table.AddCell(new PdfPCell(new Phrase(new Chunk("Cantidad", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));
                    table.AddCell(new PdfPCell(new Phrase(new Chunk("Precio", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));
                    table.AddCell(new PdfPCell(new Phrase(new Chunk("Subtotal", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));

                    string queryArticulos = @"SELECT DV.ID_Productos, P.NombreProducto, DV.Cantidad, DV.PrecioUnidad, DV.SubTotal 
                                  FROM DetallesVenta DV 
                                  JOIN Productos P ON DV.ID_Productos = P.ID_Productos 
                                  WHERE DV.ID_Ventas = @IDVenta";

                    using (SqlCommand command = new SqlCommand(queryArticulos, connection))
                    {
                        command.Parameters.AddWithValue("@IDVenta", idVenta);
                        SqlDataReader readerArticulos = command.ExecuteReader();

                        while (readerArticulos.Read())
                        {
                            table.AddCell(readerArticulos["ID_Productos"].ToString());
                            table.AddCell(readerArticulos["NombreProducto"].ToString());
                            table.AddCell(readerArticulos["Cantidad"].ToString());
                            table.AddCell(readerArticulos["PrecioUnidad"].ToString());
                            table.AddCell(readerArticulos["SubTotal"].ToString());
                        }
                        readerArticulos.Close();
                    }

                    doc.Add(table);
                    PdfPTable espacio = new PdfPTable(1);
                    espacio.AddCell(new PdfPCell(new Phrase(new Chunk(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12))))
                    {
                        Border = Rectangle.NO_BORDER,
                        FixedHeight = 20
                    });
                    doc.Add(espacio);

                    // **3️⃣ PIE DEL TICKET CON DETALLES DE PAGO**
                    PdfPTable footerTable = new PdfPTable(2);
                    footerTable.WidthPercentage = 130;
                    footerTable.SetWidths(new float[] { 1f, 1f });

                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("Subtotal:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));
                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("$" + DBC.GetData($"SELECT SUM(SubTotal) AS SubTotal FROM DetallesVenta WHERE ID_Ventas = {idVenta};")[0], FontFactory.GetFont(FontFactory.HELVETICA, 12)))));

                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("Promoción:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)))));
                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("$" + DBC.GetData($"SELECT CONCAT(Promociones.NombrePromocion, ' ', Promociones.Descuento) AS PROMOCION FROM Ventas\r\n    JOIN Promociones ON Ventas.ID_Promociones = Promociones.ID_Promociones\r\nWHERE ID_Ventas = {idVenta};")[0], FontFactory.GetFont(FontFactory.HELVETICA, 12)))));

                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("TOTAL:", FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.BOLD)))));
                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("$" + DBC.GetData($"SELECT TotalVenta FROM Ventas WHERE ID_Ventas = {idVenta};")[0], FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.BOLD)))));

                    footerTable.AddCell(new PdfPCell(new Phrase(new Chunk("*** Gracias por su compra ***", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.ITALIC))))
                    {
                        Colspan = 2,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                    doc.Add(footerTable);
                }

                doc.Close();
                //System.Diagnostics.Process.Start("ticket_completo.pdf");
                ImprimirPDF(rutaSalida);
            }

        }
        private static void ImprimirPDF(string rutaPDF)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = rutaPDF,
                UseShellExecute = true
            });
        }
        //public static void factura(string id)
        //{
        //    string rutaArchivo = System.IO.Path.Combine(Application.StartupPath, "Resources", "factura.docx");

        //    using (WordprocessingDocument documento = WordprocessingDocument.Open(rutaArchivo, true))
        //    {
        //        Body cuerpo = documento.MainDocumentPart.Document.Body;

        //        // Agregar un nuevo párrafo al final del documento

        //        DocumentFormat.OpenXml.Wordprocessing.Paragraph nuevoParrafo = 
        //            new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(
        //                new DocumentFormat.OpenXml.Wordprocessing.Text("Este es el texto insertado en el documento.")));

        //        cuerpo.AppendChild(nuevoParrafo);

        //        // Guardar cambios
        //        documento.MainDocumentPart.Document.Save();
        //    }
        //}
        public static void Salir()
        {
            Application.Exit();
        }
    }
}
