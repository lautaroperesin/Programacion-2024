using CiclismoDesktop.Utils;
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
    public partial class ProductosView : Form
    {
        SqlCommand cmd = new SqlCommand();
        public ProductosView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos el comando que vamos a ejecutar, el resultado queda en SqlDataReader
            cmd.CommandText = "SELECT * FROM Productos";
            SqlDataReader productosReader = cmd.ExecuteReader();

            // Cargamos los datos en un DataTable para poder mostrarlos en la grilla
            DataTable productosTable = new DataTable();
            productosTable.Load(productosReader);
            dataGridViewProductos.DataSource = productosTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProductoAEliminar = (int)dataGridViewProductos.CurrentRow.Cells[0].Value;
            string nombreProducto = (string)dataGridViewProductos.CurrentRow.Cells[1].Value;

            // Mostramos un messageBox que pregunta si estas seguro de eliminar el producto
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar al cliente {nombreProducto}?",
                               "Eliminar producto",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere eliminar, enviamos a borrar el producto utilizando el id
            if (respuesta == DialogResult.Yes)
            {
                cmd.CommandText = $"DELETE FROM Productos WHERE ID = {idProductoAEliminar}";
                cmd.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarProductoView nuevoEditarProductosView = new NuevoEditarProductoView();
            nuevoEditarProductosView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idProductosAEditar = (int)dataGridViewProductos.CurrentRow.Cells[0].Value;
            NuevoEditarProductoView nuevoEditarProductosView = new NuevoEditarProductoView(idProductosAEditar);
            nuevoEditarProductosView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
