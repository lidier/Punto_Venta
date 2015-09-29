using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_Venta
{
    public partial class Principal : Form
    {
        

        public Principal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.AgregarCliente addCliente= new Cliente.AgregarCliente();
            addCliente.MdiParent = this.MdiParent;
            addCliente.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedor.AgregarProveedor addProveedor = new Proveedor.AgregarProveedor();
            addProveedor.MdiParent = this.MdiParent;
            addProveedor.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new buscar().Show();
        }

        private void cerrarCesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vcliente().Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vfactura().Show();
        }
    }
}
