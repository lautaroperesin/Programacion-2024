using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            agregarEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del libro seleccionado y su nombre
            string? idLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[0].Value;
            string? nombreLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[1].Value;

            // Mostramos un messageBox que pregunta si estas seguro de eliminar el libro
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el libro {nombreLibroSeleccionado}?",
                               "Eliminar libro",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            // Si el usuario selecciono que quiere eliminar, enviamos a borrar el libro utilizando el id y el objeto repo.
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idLibroSeleccionado);
                CargarLibrosALaGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del libro seleccionado
            string? idLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[0].Value;

            // Instanciar la ventana AgregarEditarLibro y pasarle ese ID a su constructor
            // (vamos a tener que crear un nuevo constructor en ese formulario que este preparado para recibir ese ID)
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView(idLibroSeleccionado);

            // LLamamos a la ventana con el metodo showmodal que la pone por encima
            agregarEditarLibroView.ShowDialog();

            // Recargar la grilla
            CargarLibrosALaGrilla();
        }
    }
}
