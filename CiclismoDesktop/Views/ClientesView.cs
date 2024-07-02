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

namespace CiclismoDesktop.Views
{
    public partial class ClientesView : Form
    {
        // Establecemos la conexion
        string connectionString = "server=.\\SQLEXPRESS; database=Ciclismo2; user=sa; password=123; multipleactiveresultsets=true; Encrypt=false";

        SqlConnection conexion;

        SqlCommand cmd = new SqlCommand();
        public ClientesView()
        {
            InitializeComponent();
            AbrirConexion();
            CargarDatosAGrilla();
        }

        private void AbrirConexion()
        {
            conexion = new SqlConnection(connectionString);
            conexion.Open();
            cmd.Connection = conexion;
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos el comando que vamos a ejecutar, el resultado queda en SqlDataReader
            cmd.CommandText = "SELECT * FROM Clientes";
            SqlDataReader clientesReader = cmd.ExecuteReader();

            // Cargamos los datos en un DataTable para poder mostrarlos en la grilla
            DataTable clientesTable = new DataTable();
            clientesTable.Load(clientesReader);
            dataGridView1.DataSource = clientesTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idClienteAEliminar = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string nombreCliente = (string)dataGridView1.CurrentRow.Cells[1].Value;

            // Mostramos un messageBox que pregunta si estas seguro de eliminar el cliente
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar al cliente {nombreCliente}?",
                               "Eliminar cliente",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere eliminar, enviamos a borrar el cliente utilizando el id
            if (respuesta == DialogResult.Yes)
            {
                cmd.CommandText = $"DELETE FROM Clientes WHERE ID = {idClienteAEliminar}";
                cmd.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteView nuevoEditarClienteView = new NuevoEditarClienteView();
            nuevoEditarClienteView.ShowDialog();
        }
    }
}
