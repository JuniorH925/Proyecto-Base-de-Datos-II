using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDD
{
    public partial class FormMenú : Form
    {
        public FormMenú()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormResumen formInventario = new FormResumen();
            formInventario.Show();
            this.Hide();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FormVender formVender = new FormVender();
            formVender.Show();  
            this.Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormComprar formComprar = new FormComprar();
            formComprar.Show();
            this.Hide();
        }
    }
}
