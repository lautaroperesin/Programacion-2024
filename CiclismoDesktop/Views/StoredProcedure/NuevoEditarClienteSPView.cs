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

namespace CiclismoDesktop.Views.StoreProcedure
{
    public partial class NuevoEditarClienteSPView : Form
    {
        SqlCommand cmd = new SqlCommand();
        private int? idClienteAEditar;

        public NuevoEditarClienteSPView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public NuevoEditarClienteSPView(int idClienteAEditar)
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            this.idClienteAEditar = idClienteAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "GetClientById";
            cmd.Parameters.AddWithValue("ID", idClienteAEditar);
            var clienteReader = cmd.ExecuteReader();
            if (clienteReader != null)
            {
                if (clienteReader.Read())
                {
                    txtNombre.Text = (string)clienteReader["Nombre"];
                    txtNombreContacto.Text = (string)clienteReader["NombreContacto"];
                    txtApellidoContacto.Text = (string)clienteReader["ApellidoContacto"];
                }
            }
            clienteReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("NombreContacto", txtNombreContacto.Text);
            cmd.Parameters.AddWithValue("ApellidoContacto", txtApellidoContacto.Text);

            if (idClienteAEditar == null)
            {
                cmd.CommandText = $"AddClient";
            }
            else
            {
                cmd.Parameters.AddWithValue("ID", idClienteAEditar);
                cmd.CommandText = $"UpdateClient";
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
