using EjerciciosDePrueba.Models;
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
    public partial class AgregarEditarLibroView : Form
    {
        private string idLibroSeleccionado;
        LibrosRepositorio repo = new LibrosRepositorio();

        // Constructor
        public AgregarEditarLibroView()
        {
            InitializeComponent();
        }

        // Constructor que recibe el id como parametro
        public AgregarEditarLibroView(string idLibroSeleccionado)
        {
            this.idLibroSeleccionado = idLibroSeleccionado;
            InitializeComponent();
            CargarDatosLibrosEnPantalla();
        }

        private async void CargarDatosLibrosEnPantalla()
        {
            Libro? libro = await repo.ObtenerPorIdAsync(this.idLibroSeleccionado);
            if(libro != null)
            {
                txtNombre.Text = libro.nombre;
                txtAutor.Text = libro.autor;
                txtEditorial.Text = libro.editorial;
                txtGenero.Text = libro.genero;
                txtPortada.Text = libro.portada_url;
                txtSinopsis.Text = libro.sinopsis;
                numericPaginas.Value = libro.paginas;
                pictureBoxPortada.ImageLocation = libro.portada_url;
            }
            else
            {
                MessageBox.Show("Error: no se encontró el libro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if(this.idLibroSeleccionado != null)
            {
                await repo.ActualizarAsync(txtNombre.Text,
                                    (int)numericPaginas.Value,
                                    txtAutor.Text,
                                    txtEditorial.Text,
                                    txtGenero.Text,
                                    txtSinopsis.Text,
                                    txtPortada.Text,
                                    this.idLibroSeleccionado);
                this.Close();
            }
            else
            {
                await repo.AgregarAsync(txtNombre.Text,
                                    (int)numericPaginas.Value,
                                    txtAutor.Text,
                                    txtEditorial.Text,
                                    txtGenero.Text,
                                    txtSinopsis.Text,
                                    txtPortada.Text);
                this.Close();
            }
        }
    }
}
