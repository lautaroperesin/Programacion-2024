using CancionesDesktop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CancionesDesktop.Views
{
    public partial class GestionCancionesView : Form
    {
        RepositorioCanciones repo = new RepositorioCanciones();
        public GestionCancionesView()
        {
            InitializeComponent();
            CargarCancionesALaGrilla();
        }

        private async void CargarCancionesALaGrilla()
        {
            dataGridCanciones.DataSource = await repo.ObtenerCancionesAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCancionView agregarEditarCancionView = new AgregarEditarCancionView();
            agregarEditarCancionView.ShowDialog();
            CargarCancionesALaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string? idCancionSeleccionada = (string)dataGridCanciones.CurrentRow.Cells[0].Value;

            AgregarEditarCancionView agregarEditarCancionView = new AgregarEditarCancionView(idCancionSeleccionada);

            agregarEditarCancionView.ShowDialog();

            CargarCancionesALaGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string? idCancionSeleccionada = (string)dataGridCanciones.CurrentRow.Cells[0].Value;
            string? nombreCancionSeleccionada = (string)dataGridCanciones.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar la canción {nombreCancionSeleccionada}?",
                               "Eliminar canción",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idCancionSeleccionada);
                CargarCancionesALaGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
