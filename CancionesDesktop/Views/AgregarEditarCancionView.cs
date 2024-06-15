using CancionesDesktop.Models;
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
    public partial class AgregarEditarCancionView : Form
    {
        private string idCancionSeleccionada;
        RepositorioCanciones repo = new RepositorioCanciones();
        public AgregarEditarCancionView()
        {
            InitializeComponent();
        }

        public AgregarEditarCancionView(string idCancionSeleccionada)
        {
            this.idCancionSeleccionada = idCancionSeleccionada;
            InitializeComponent();
            CargarDatosCancionesEnPantalla();
        }

        private async void CargarDatosCancionesEnPantalla()
        {
            Cancion? cancion = await repo.ObtenerPorIdAsync(this.idCancionSeleccionada);
            if (cancion != null)
            {
                txtCancion.Text = cancion.cancion;
                txtArtista.Text = cancion.artista;
                txtPortada.Text = cancion.portada_url;
                pictureBoxPortada.ImageLocation = cancion.portada_url;
            }
            else
            {
                MessageBox.Show("Error: no se encontró la canción");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.idCancionSeleccionada != null)
            {
                await repo.ActualizarAsync(txtCancion.Text,
                                    txtArtista.Text,
                                    txtPortada.Text,
                                    this.idCancionSeleccionada);
                this.Close();
            }
            else
            {
                await repo.AgregarAsync(txtCancion.Text,
                                    txtArtista.Text,
                                    txtPortada.Text);
                this.Close();
            }
        }
    }
}
