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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Verificar si el usuario y la contraseña son válidos
            if (usuario == "Ingeniero123" && contrasena == "Umg123")
            {
                // Si el inicio de sesión es exitoso, mostrar un mensaje y cerrar el formulario de inicio de sesión
                MessageBox.Show("           ¡Bienvenido Ingeniero!");
                FormMenú formMenú = new FormMenú();
                formMenú.Show();
                this.Hide();
            }
            else
            {
                // Si el inicio de sesión falla, mostrar un mensaje de error y borrar los cuadros de texto de la contraseña
                MessageBox.Show("     El nombre de usuario y/o la contraseña son incorrectos.");
                txtContraseña.Clear();
            }
        }
    }
}
