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
        private Vfactura view_factura = new Vfactura();
        private Vcliente view_cliente = new Vcliente();
        private Vbuscar view_buscar = new Vbuscar();


        public Principal()
        {
            InitializeComponent();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Vbuscar().Show();
        }

        private void cerrarCesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_cliente.IsDisposed)
            {
                view_cliente = new Vcliente();
            }
            view_cliente.Show();
            if (view_cliente.Focused == false)
            {
                view_cliente.BringToFront();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //view_proveedor
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(view_factura.IsDisposed)
            {
                view_factura = new Vfactura();
            }
            view_factura.Show();
            if(view_factura.Focused == false)
            {
                view_factura.BringToFront();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_buscar.IsDisposed)
            {
                view_buscar = new Vbuscar();
            }
            view_buscar.Show();
            if (view_buscar.Focused == false)
            {
                view_buscar.BringToFront();
            }
        }
    }
}
