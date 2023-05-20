using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ProyectoBDD
{
    public partial class FormComprar : Form
    {
        public FormComprar()
        {
            InitializeComponent();
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet6.Compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter.Fill(this.proyectoDataSet6.Compras);

        }

        private void btnMostrarInventario_Click(object sender, EventArgs e)
        {
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
            this.Hide();
        }

        private void btnrealizarcompra_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LUIS_HERRERA\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Compras VALUES (@id_producto,@cantidad,@NIT,@nombre,@direccion,@telefono, @correo, @portal)", con);

            cmd.Parameters.AddWithValue("@id_producto", int.Parse(txtidproductoc.Text));
            txtidproductoc.Clear();
            cmd.Parameters.AddWithValue("@cantidad", int.Parse(txtcantidadc.Text));
            txtcantidadc.Clear();
            cmd.Parameters.AddWithValue("@NIT", int.Parse(txtnitc.Text));
            txtnitc.Clear();
            cmd.Parameters.AddWithValue("@nombre", comboboxcompras.Text);
            comboboxcompras.Items.Clear();
            cmd.Parameters.AddWithValue("@direccion", txtdirecciónc.Text);
            txtdirecciónc.Clear();
            cmd.Parameters.AddWithValue("@telefono", txttelefonoc.Text);
            txttelefonoc.Clear();
            cmd.Parameters.AddWithValue("@correo", txtcorreoc.Text);
            txtcorreoc.Clear();
            cmd.Parameters.AddWithValue("@portal", comboboxcompras.Text);
            comboboxcompras.Items.Clear();
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Datos guardados con éxito");
        }

        private void btnActualizarv_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LUIS_HERRERA\\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Compras", con);
            con.Close();
        }

        private void btnimprimirfacturav_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto del TextBox
                string contenido = txtidproductoc.Text;
                string contenido1 = txtcantidadc.Text;
                string contenido2 = txtnitc.Text;
                string contenido3 = comboboxcompras.Text;
                string contenido4 = txtdirecciónc.Text;
                string contenido5 = txttelefonoc.Text;
                string contenido6 = txtcorreoc.Text;
                string contenido7 = comboBoxportal.Text;

                // Guardar el contenido en un archivo de texto temporal
                string tempFilePath = Path.GetTempFileName();
                File.WriteAllText(tempFilePath, contenido);

                // Configurar el proceso para imprimir con PDFCreator
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "PDFCreator.exe",
                    Arguments = String.Format("/PrintFile=\"{0}\"", tempFilePath),
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                // Iniciar el proceso de impresión
                Process.Start(psi);

                // Eliminar el archivo temporal
                File.Delete(tempFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir con PDFCreator: " + ex.Message);
            }
        }
    }
}
       