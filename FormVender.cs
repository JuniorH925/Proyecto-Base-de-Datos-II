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
using System.Drawing;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoBDD
{
    public partial class FormVender : Form
    {
        public FormVender()
        {
            InitializeComponent();
        }

        private void FormVender_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet5.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.proyectoDataSet5.Ventas);
            // TODO: This line of code loads data into the 'proyectoDataSet4.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.proyectoDataSet4.productos);

        }

        private void btnguardarfacturav_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LUIS_HERRERA\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ventas VALUES (@id_producto,@cantidad,@codigo_cliente,@nombre,@direccion,@correo, @nit)", con);

            cmd.Parameters.AddWithValue("@id_producto", int.Parse(txtidproductov.Text));
            txtidproductov.Clear();
            cmd.Parameters.AddWithValue("@cantidad", int.Parse(txtcantidadv.Text));
            txtcantidadv.Clear();
            cmd.Parameters.AddWithValue("@codigo_cliente", int.Parse(txtcodigoclientev.Text));
            txtcodigoclientev.Clear();
            cmd.Parameters.AddWithValue("@nombre", comboboxventas.Text);
            comboboxventas.Items.Clear();
            cmd.Parameters.AddWithValue("@direccion", txtdirecciónv.Text);
            txtdirecciónv.Clear();
            cmd.Parameters.AddWithValue("@correo", txtcorreov.Text);
            txtcorreov.Clear();
            cmd.Parameters.AddWithValue("@nit", int.Parse(txtnitv.Text));
            txtnitv.Clear();
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Datos guardados con éxito");
        }

        private void btnMostrarInventario_Click(object sender, EventArgs e)
        {
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LUIS_HERRERA\\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas", con);
            con.Close();
        }

        private void btnimprimirfacturav_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto del TextBox
                string contenido = txtidproductov.Text;
                string contenido1 = txtcantidadv.Text;
                string contenido2 = txtcodigoclientev.Text;
                string contenido3 = comboboxventas.Text;
                string contenido4 = txtdirecciónv.Text;
                string contenido5 = txtcorreov.Text;
                string contenido6 = txtnitv.Text;


                // Configurar la impresora y el documento
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, ev) =>
                {
                    // Definir el formato y el tamaño del documento
                    Font font = new Font("Arial", 12);
                    RectangleF bounds = ev.MarginBounds;

                    // Imprimir el contenido en la página
                    ev.Graphics.DrawString(contenido, font, Brushes.Black, bounds, StringFormat.GenericTypographic);
                };

                // Imprimir directamente a la impresora predeterminada
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }
    }
}

