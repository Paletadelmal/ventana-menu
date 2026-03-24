using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ventana_menu
{
    public partial class Clientes : Form
    {
        private int idSeleccionado = 0;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            Conexion con = new Conexion();

            using (SqlConnection conexion = con.ObtenerConexion())
            {
                conexion.Open();

                string query = "SELECT * FROM Clientes";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (!dataGridView1.Columns.Contains("Editar"))
                {
                    DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                    btnEditar.Name = "Editar";
                    btnEditar.Text = "Editar";
                    btnEditar.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnEditar);
                }

                if (!dataGridView1.Columns.Contains("Eliminar"))
                {
                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.Name = "Eliminar";
                    btnEliminar.Text = "Eliminar";
                    btnEliminar.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnEliminar);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();

            using (SqlConnection conexion = con.ObtenerConexion())
            {
                conexion.Open();

                if (idSeleccionado > 0)
                {
                    string query = @"UPDATE Clientes SET
                    nombre=@nombre,
                    rfc=@rfc,
                    domicilio=@domicilio,
                    correo=@correo,
                    telefono=@telefono,
                    fecha_nacimiento=@fecha
                    WHERE id_cliente=@id";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@rfc", txtRFC.Text);
                    cmd.Parameters.AddWithValue("@domicilio", txtDomicilio.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente actualizado");
                }
                else
                {
                    string query = @"INSERT INTO Clientes
                    (nombre, rfc, domicilio, correo, telefono, fecha_nacimiento)
                    VALUES (@nombre, @rfc, @domicilio, @correo, @telefono, @fecha)";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@rfc", txtRFC.Text);
                    cmd.Parameters.AddWithValue("@domicilio", txtDomicilio.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente guardado");
                }

                LimpiarCampos();
                CargarClientes();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                idSeleccionado = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["id_cliente"].Value
                );

                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtRFC.Text = dataGridView1.Rows[e.RowIndex].Cells["rfc"].Value.ToString();
                txtDomicilio.Text = dataGridView1.Rows[e.RowIndex].Cells["domicilio"].Value.ToString();
                txtCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells["telefono"].Value.ToString();

                dtpFecha.Value = Convert.ToDateTime(
                    dataGridView1.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value
                );
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["id_cliente"].Value
                );

                DialogResult res = MessageBox.Show(
                    "¿Eliminar cliente?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (res == DialogResult.Yes)
                {
                    Conexion con = new Conexion();

                    using (SqlConnection conexion = con.ObtenerConexion())
                    {
                        conexion.Open();

                        string query = "DELETE FROM Clientes WHERE id_cliente=@id";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente eliminado");
                        CargarClientes();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;

            txtNombre.Text = "";
            txtRFC.Text = "";
            txtDomicilio.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";

            dtpFecha.Value = DateTime.Now;
        }

       
    }
}