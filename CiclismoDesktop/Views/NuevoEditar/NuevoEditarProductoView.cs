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
    public partial class NuevoEditarProductoView : Form
    {
        SqlCommand cmd = new SqlCommand();
        private int? idProductoAEditar;
        public NuevoEditarProductoView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
        }

        public NuevoEditarProductoView(int idProductoAEditar)
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            this.idProductoAEditar = idProductoAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            cmd.CommandText = $"SELECT * FROM Productos WHERE ID = {this.idProductoAEditar}";
            var productoReader = cmd.ExecuteReader();
            if (productoReader != null)
            {
                if (productoReader.Read())
                {
                    txtNombreProducto.Text = (string)productoReader["NombreProducto"];
                    txtColorProducto.Text = (string)productoReader["Color"];
                    txtTallaProducto.Text = (string)productoReader["Talla"];
                    txtMFProducto.Text = (string)productoReader["M_F"];
                    numericUpDownPrecioProducto.Value = (decimal)productoReader["Precio"];
                    txtClaseProducto.Text = (string)productoReader["ClaseProducto"];
                }
            }
            productoReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            string colorProducto = txtColorProducto.Text;
            string tallaProducto = txtTallaProducto.Text;
            string M_FProducto = txtMFProducto.Text;
            decimal precioProducto = numericUpDownPrecioProducto.Value;
            string claseProducto = txtClaseProducto.Text;

            if (idProductoAEditar == null)
            {
                cmd.CommandText = $"INSERT INTO Productos (NombreProducto, Color, Talla, M_F, Precio, ClaseProducto) VALUES ('{nombreProducto}', '{colorProducto}', '{tallaProducto}','{M_FProducto}', '{precioProducto}', '{claseProducto}')";
            }
            else
            {
                cmd.CommandText = $"UPDATE Productos SET NombreProducto='{nombreProducto}', Color='{colorProducto}', Talla='{tallaProducto}', M_F='{M_FProducto}', Precio='{precioProducto}', ClaseProducto='{claseProducto}' WHERE id = {this.idProductoAEditar}";
            }
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
