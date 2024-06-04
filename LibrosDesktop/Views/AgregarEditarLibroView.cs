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
        public AgregarEditarLibroView()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            LibrosRepositorio repo = new LibrosRepositorio();
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
