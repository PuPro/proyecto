using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace WindowsFormsApplication2
{
    public partial class InicioReporte : Form
    {
        public InicioReporte()
        {
            InitializeComponent();
            stock_producto();
        }

        public void stock_producto()
        {
            SqlConnection CN = new SqlConnection();
            CN.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            CN.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select nombre, stock from producto where stock <= 10", CN);
            sda1.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("select COUNT (*) from producto where stock <= 10", CN);
            sda2.Fill(dt2);

          


            for (int i = 0; i < Convert.ToInt32(dt2.Rows[0][0]); i++)
            {

                lbox_reporteStock.Items.Add(dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + "\n ");
               


            }
            

            CN.Close();
        }





        private void bt_guardar_reporte_Click(object sender, EventArgs e)
        {

            string dato = txt_user_reporte.Text;
            SqlConnection CN = new SqlConnection();
            CN.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";
            DataTable dt3 = new DataTable();
            CN.Open();

            SqlDataAdapter sda3 = new SqlDataAdapter("select nombre, apellido from usuario where usuario = '" + dato + "'", CN);
            sda3.Fill(dt3);

            string hora;
            string fechas;
            string nombre = " ";

            fechas = DateTime.Now.ToString("dd/MM/yyyy");
            hora= DateTime.Now.ToString("hh:mm:ss");
            nombre += dt3.Rows[0][0].ToString() + " " + dt3.Rows[0][1].ToString();

            //Gestion reporte = new Gestion();
            //reporte.agregar_reporte(fechas, hora, nombre);

            this.Close();


             


            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\ReporteStock\ReporteStock_"+fechas+".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Alerta Stock Bajo");
            doc.AddCreator("ElfmanStrauss");

            // Abrimos el archivo
            doc.Open();


            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Reporte de stock bajo......."));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblstock = new PdfPTable(3);
            tblstock.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clProducto = new PdfPCell(new Phrase("Producto", _standardFont));
            clProducto.BorderWidth = 0;
            clProducto.BorderWidthBottom = 0.75f;

            PdfPCell clcantidadstock = new PdfPCell(new Phrase("Cantidad stock", _standardFont));
            clcantidadstock.BorderWidth = 0;
            clcantidadstock.BorderWidthBottom = 0.75f;

            PdfPCell clextra = new PdfPCell(new Phrase(" ", _standardFont));
            clextra.BorderWidth = 0;
            clextra.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblstock.AddCell(clProducto);
            tblstock.AddCell(clcantidadstock);
            tblstock.AddCell(clextra);



            SqlConnection CN2 = new SqlConnection();
            CN2.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            CN2.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select nombre, stock from producto where stock <= 10", CN);
            sda1.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("select COUNT (*) from producto where stock <= 10", CN);
            sda2.Fill(dt2);

            
            for (int i = 0; i < Convert.ToInt32(dt2.Rows[0][0]); i++)
            {

                // Llenamos la tabla con información
                clProducto = new PdfPCell(new Phrase(dt.Rows[i][0].ToString(), _standardFont));
                clProducto.BorderWidth = 0;

                clcantidadstock = new PdfPCell(new Phrase(dt.Rows[i][1].ToString(), _standardFont));
                clcantidadstock.BorderWidth = 0;

                clextra = new PdfPCell(new Phrase(" ", _standardFont));
                clextra.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblstock.AddCell(clProducto);
                tblstock.AddCell(clcantidadstock);
                tblstock.AddCell(clextra);


            }



            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblstock);

            doc.Close();
            writer.Close();

            MessageBox.Show("Su Reporte a sido guardado");


        }




    }
}
