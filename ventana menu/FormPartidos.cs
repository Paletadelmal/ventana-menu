using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana_menu
{
    public partial class FormPartidos : Form
    {
        public FormPartidos()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al abrir la ventana
        private void FormPartidos_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasDeAccion();
            CargarDatosPartidos(); // Este método debe contener tu consulta SQL
        }

        // Método para crear los botones de Editar y Borrar
        private void ConfigurarColumnasDeAccion()
        {
            // Evita que se dupliquen las columnas si el método se llama varias veces
            if (dgvPartidos.Columns.Contains("btnEditar")) return;

            // Botón EDITAR (Azul)
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acciones";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.SteelBlue;
            btnEditar.DefaultCellStyle.ForeColor = Color.White;
            dgvPartidos.Columns.Add(btnEditar);

            // Botón BORRAR (Rojo)
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            btnBorrar.Name = "btnBorrar";
            btnBorrar.HeaderText = ""; // Sin texto en el encabezado para que pegado al de editar
            btnBorrar.Text = "Borrar";
            btnBorrar.UseColumnTextForButtonValue = true;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.DefaultCellStyle.BackColor = Color.Crimson;
            btnBorrar.DefaultCellStyle.ForeColor = Color.White;
            dgvPartidos.Columns.Add(btnBorrar);
        }

        // Método para llenar la tabla (aquí conectas con tu DB_TicketingEstadioPro)
        public void CargarDatosPartidos()
        {
            // Aquí va tu lógica de SQL para llenar el dgvPartidos
            // Ejemplo: dgvPartidos.DataSource = tuClaseConexion.ObtenerTabla();
        }

        // --- Tus eventos actuales del formulario ---

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Probablemente este sea tu botón de "Crear Nuevo Partido"
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}