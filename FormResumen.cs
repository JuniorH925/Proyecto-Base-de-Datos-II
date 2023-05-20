using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDD
{
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet10.Compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter1.Fill(this.proyectoDataSet10.Compras);
            // TODO: This line of code loads data into the 'proyectoDataSet9.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter1.Fill(this.proyectoDataSet9.Ventas);
            // TODO: This line of code loads data into the 'proyectoDataSet8.proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter1.Fill(this.proyectoDataSet8.proveedores);
            // TODO: This line of code loads data into the 'proyectoDataSet7.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter1.Fill(this.proyectoDataSet7.productos);


        }

        private void btnMostrarInventario_Click(object sender, EventArgs e)
        {
            FormMenú formMenú = new FormMenú();
            formMenú.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
