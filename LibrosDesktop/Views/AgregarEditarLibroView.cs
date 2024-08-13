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
        LibrosRepositorio repo = new LibrosRepositorio();
        private Libro libro;

        // Constructor
        public AgregarEditarLibroView()
        {
            InitializeComponent();
            this.libro = new Libro();
        }

        public AgregarEditarLibroView(Libro libro)
        {
            this.libro = libro;
            InitializeComponent();
            CargarDatosLibrosEnPantalla();
        }

        private void CargarDatosLibrosEnPantalla()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            this.libro.nombre = txtNombre.Text;
            this.libro.autor = txtAutor.Text;
            this.libro.genero = txtGenero.Text;
            this.libro.portada_url = txtPortada.Text;
            this.libro.sinopsis = txtSinopsis.Text;
            this.libro.paginas = (int)numericPaginas.Value;
            this.libro.editorial = txtEditorial.Text;

            if (libro._id != null)
            {
                await repo.ActualizarAsync(this.libro);
            }
            else
            {
                await repo.AgregarAsync(this.libro);
            }
            this.Close();
        }
    }
}
