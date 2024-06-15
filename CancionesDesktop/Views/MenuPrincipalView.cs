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
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void cancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCancionesView gestionCancionesView = new GestionCancionesView();
            gestionCancionesView.ShowDialog();
        }
    }
}
