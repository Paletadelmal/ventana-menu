using System;
using System.Windows.Forms;

namespace ventana_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        // 🔘 BOTÓN LOGIN AGREGADO
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validación básica
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                // Crear instancia del menú
                FormMenu menu = new FormMenu();

                // Mostrar menú
                menu.Show();

                // Ocultar login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}