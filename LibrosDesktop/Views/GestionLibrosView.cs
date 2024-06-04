using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosDesktop.Views
{
    public partial class GestionLibrosView : Form
    {
        LibrosRepositorio repo = new LibrosRepositorio();
        public GestionLibrosView()
        {
            InitializeComponent();
            CargarLibrosALaGrilla();
        }

        private async void CargarLibrosALaGrilla()
        {
            dataGridLibros.DataSource = await repo.ObtenerLibrosAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView();
            agregarEditarLibroView.Show();
            CargarLibrosALaGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
