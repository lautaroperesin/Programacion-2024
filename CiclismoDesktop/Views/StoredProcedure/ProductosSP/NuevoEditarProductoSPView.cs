using CiclismoDesktop.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class NuevoEditarProductoSPView : Form
    {
        SqlCommand cmd = new SqlCommand();
        private int? idProductoAEditar;

        public NuevoEditarProductoSPView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public NuevoEditarProductoSPView(int idProductoAEditar)
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            this.idProductoAEditar = idProductoAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "GetProductById";
            cmd.Parameters.AddWithValue("ID", idProductoAEditar);
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
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("NombreProducto", txtNombreProducto.Text);
            cmd.Parameters.AddWithValue("Color", txtColorProducto.Text);
            cmd.Parameters.AddWithValue("Talla", txtTallaProducto.Text);
            cmd.Parameters.AddWithValue("M_F", txtMFProducto.Text);
            cmd.Parameters.AddWithValue("Precio", numericUpDownPrecioProducto.Value);
            cmd.Parameters.AddWithValue("ClaseProducto", txtClaseProducto.Text);

            if (idProductoAEditar == null)
            {
                cmd.CommandText = $"AddProduct";
            }
            else
            {
                cmd.Parameters.AddWithValue("ID", idProductoAEditar);
                cmd.CommandText = $"UpdateProduct";
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
