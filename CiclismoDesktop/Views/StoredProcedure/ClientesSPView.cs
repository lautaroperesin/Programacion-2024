using CiclismoDesktop.Utils;
using CiclismoDesktop.Views.StoreProcedure;
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
    public partial class ClientesSPView : Form
    {
        SqlCommand cmd = new SqlCommand();
        public ClientesSPView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos el comando que vamos a ejecutar, el resultado queda en SqlDataReader
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllClients";
            SqlDataReader clientesReader = cmd.ExecuteReader();

            // Cargamos los datos en un DataTable para poder mostrarlos en la grilla
            DataTable clientesTable = new DataTable();
            clientesTable.Load(clientesReader);
            dataGridClientes.DataSource = clientesTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idClienteAEliminar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string nombreCliente = (string)dataGridClientes.CurrentRow.Cells[1].Value;

            // Mostramos un messageBox que pregunta si estas seguro de eliminar el cliente
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar al cliente {nombreCliente}?",
                               "Eliminar cliente",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere eliminar, enviamos a borrar el cliente utilizando el id
            if (respuesta == DialogResult.Yes)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", idClienteAEliminar);
                cmd.CommandText = "DeleteClient";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                CargarDatosAGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteSPView nuevoEditarClienteSPView = new NuevoEditarClienteSPView();
            nuevoEditarClienteSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idClienteAEditar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            NuevoEditarClienteSPView nuevoEditarClienteSPView = new NuevoEditarClienteSPView(idClienteAEditar);
            nuevoEditarClienteSPView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
