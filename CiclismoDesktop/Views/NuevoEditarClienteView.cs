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
    public partial class NuevoEditarClienteView : Form
    {
        SqlCommand cmd = new SqlCommand();
        private int? idClienteAEditar;

        public NuevoEditarClienteView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
        }

        public NuevoEditarClienteView(int idClienteAEditar)
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            this.idClienteAEditar = idClienteAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            cmd.CommandText = $"SELECT * FROM Clientes WHERE ID = {this.idClienteAEditar}";
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
            if(idClienteAEditar == null)
            {
                cmd.CommandText = $"INSERT INTO Clientes (Nombre, NombreContacto, ApellidoContacto) VALUES ('{txtNombre.Text}', '{txtNombreContacto.Text}', '{txtApellidoContacto.Text}')";
            }
            else
            {
                cmd.CommandText = $"UPDATE Clientes SET Nombre='{txtNombre.Text}', NombreContacto='{txtNombreContacto.Text}', ApellidoContacto='{txtApellidoContacto.Text}' WHERE id = {this.idClienteAEditar}";
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
