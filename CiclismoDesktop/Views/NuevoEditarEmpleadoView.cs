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
    public partial class NuevoEditarEmpleadoView : Form
    {
        SqlCommand cmd = new SqlCommand();
        private int? idEmpleadoAEditar;

        public NuevoEditarEmpleadoView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
        }

        public NuevoEditarEmpleadoView(int idEmpleadoAEditar)
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            this.idEmpleadoAEditar = idEmpleadoAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            cmd.CommandText = $"SELECT * FROM Empleados WHERE ID = {this.idEmpleadoAEditar}";
            var empleadoReader = cmd.ExecuteReader();
            if (empleadoReader != null)
            {
                if (empleadoReader.Read())
                {
                    txtNombreEmpleado.Text = (string)empleadoReader["Nombre"];
                    txtApellidoEmpleado.Text = (string)empleadoReader["Apellido"];
                    txtCargoEmpleado.Text = (string)empleadoReader["Cargo"];
                    dateTimeFechaNacimiento.Value = (DateTime)empleadoReader["FechaDeNacimiento"];
                    dateTimeFechaIngreso.Value = (DateTime)empleadoReader["FechaDeIngreso"];
                    txtTelEmpleado.Text = (string)empleadoReader["TelefonoDomicilio"];
                }
            }
            empleadoReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellidoEmpleado.Text;
            string nombre = txtNombreEmpleado.Text;
            string cargo = txtCargoEmpleado.Text;
            DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;
            DateTime fechaIngreso = dateTimeFechaIngreso.Value;
            string telEmpleado = txtTelEmpleado.Text;

            if (idEmpleadoAEditar == null)
            {
                cmd.CommandText = $"INSERT INTO Empleados (Apellido, Nombre, Cargo, FechaDeNacimiento, FechaDeIngreso,TelefonoDomicilio) VALUES ('{apellido}','{nombre}','{cargo}','{fechaNacimiento}','{fechaIngreso}','{telEmpleado}')";
            }
            else
            {
                cmd.CommandText = $"UPDATE Empleados SET Apellido='{apellido}',Nombre='{nombre}', Cargo='{cargo}', FechaDeNacimiento='{fechaNacimiento}', FechaDeIngreso='{fechaIngreso}',TelefonoDomicilio='{telEmpleado}' WHERE id={this.idEmpleadoAEditar}";
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
