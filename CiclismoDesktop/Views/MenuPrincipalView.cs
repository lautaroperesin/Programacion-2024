using CiclismoDesktop.Views;
using CiclismoDesktop.Views.Linq;
using CiclismoDesktop.Views.StoredProcedure.ProductosSP;

namespace CiclismoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void gestionarClientesStoredProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesSPView clientesStoreProcedure = new ClientesSPView();
            clientesStoreProcedure.ShowDialog();
        }

        private void gestionarClientesORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesORMView clientesORMView = new ClientesORMView();
            clientesORMView.ShowDialog();
        }

        private void productosStoredProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosSPView productosSPView = new ProductosSPView();
            productosSPView.ShowDialog();
        }

        private void pruebaConLINQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebasLinqView pruebasLinqView = new PruebasLinqView();
            pruebasLinqView.ShowDialog();
        }
    }
}
