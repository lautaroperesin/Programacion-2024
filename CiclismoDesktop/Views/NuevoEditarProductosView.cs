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
    public partial class NuevoEditarProductosView : Form
    {
        SqlCommand cmd = new SqlCommand();
        private int? idProductoAEditar;
        public NuevoEditarProductosView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
        }

        public NuevoEditarProductosView(int idProductoAEditar)
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
                    //txtNombre.Text = (string)productoReader["Nombre"];
                    //txtNombreContacto.Text = (string)productoReader["NombreContacto"];
                    //txtApellidoContacto.Text = (string)productoReader["ApellidoContacto"];
                }
            }
            productoReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idProductoAEditar == null)
            {
                //cmd.CommandText = $"INSERT INTO Clientes (Nombre, NombreContacto, ApellidoContacto) VALUES ('{txtNombre.Text}', '{txtNombreContacto.Text}', '{txtApellidoContacto.Text}')";
            }
            else
            {
                //cmd.CommandText = $"UPDATE Clientes SET Nombre='{txtNombre.Text}', NombreContacto='{txtNombreContacto.Text}', ApellidoContacto='{txtApellidoContacto.Text}' WHERE id = {this.idClienteAEditar}";
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
