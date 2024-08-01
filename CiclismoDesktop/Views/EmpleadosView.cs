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
    public partial class EmpleadosView : Form
    {
        SqlCommand cmd = new SqlCommand();
        public EmpleadosView()
        {
            InitializeComponent();
            cmd.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos el comando que vamos a ejecutar, el resultado queda en SqlDataReader
            cmd.CommandText = "SELECT * FROM Empleados";
            SqlDataReader empleadosReader = cmd.ExecuteReader();

            // Cargamos los datos en un DataTable para poder mostrarlos en la grilla
            DataTable empleadosTable = new DataTable();
            empleadosTable.Load(empleadosReader);
            dataGridViewEmpleados.DataSource = empleadosTable;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            NuevoEditarEmpleadoView nuevoEditarEmpleadoView = new NuevoEditarEmpleadoView();
            nuevoEditarEmpleadoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int idEmpleadoAEliminar = (int)dataGridViewEmpleados.CurrentRow.Cells[0].Value;
            string nombreEmpleado = (string)dataGridViewEmpleados.CurrentRow.Cells[1].Value;

            // Mostramos un messageBox que pregunta si estas seguro de eliminar el cliente
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar al empleado {nombreEmpleado}?",
                               "Eliminar empleado",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere eliminar, enviamos a borrar el cliente utilizando el id
            if (respuesta == DialogResult.Yes)
            {
                cmd.CommandText = $"DELETE FROM Empleados WHERE ID = {idEmpleadoAEliminar}";
                cmd.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idEmpleadoAEditar = (int)dataGridViewEmpleados.CurrentRow.Cells[0].Value;
            NuevoEditarEmpleadoView nuevoEditarEmpleadoView = new NuevoEditarEmpleadoView(idEmpleadoAEditar);
            nuevoEditarEmpleadoView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
