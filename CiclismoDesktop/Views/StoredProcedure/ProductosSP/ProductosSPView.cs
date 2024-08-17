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

namespace CiclismoDesktop.Views.StoredProcedure.ProductosSP
{
    public partial class ProductosSPView : Form
    {
        SqlCommand cmd = new SqlCommand();
        public ProductosSPView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos el comando que vamos a ejecutar, el resultado queda en SqlDataReader
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllProducts";
            SqlDataReader productosReader = cmd.ExecuteReader();

            // Cargamos los datos en un DataTable para poder mostrarlos en la grilla
            DataTable productosTable = new DataTable();
            productosTable.Load(productosReader);
            dataGridProductos.DataSource = productosTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProductoAEliminar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            string nombreProducto = (string)dataGridProductos.CurrentRow.Cells[1].Value;

            // Mostramos un messageBox que pregunta si estas seguro de eliminar el cliente
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el producto {nombreProducto}?",
                               "Eliminar producto",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere eliminar, enviamos a borrar el cliente utilizando el id
            if (respuesta == DialogResult.Yes)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", idProductoAEliminar);
                cmd.CommandText = "DeleteProduct";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarProductoSPView nuevoEditarProductoSPView = new NuevoEditarProductoSPView();
            nuevoEditarProductoSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idProductoAEditar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            NuevoEditarProductoSPView nuevoEditarProductoSPView = new NuevoEditarProductoSPView(idProductoAEditar);
            nuevoEditarProductoSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
