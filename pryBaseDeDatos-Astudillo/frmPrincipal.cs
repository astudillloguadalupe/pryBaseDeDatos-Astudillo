using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaseDeDatos_Astudillo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores frm = new frmClientesDeudores();
            frm.ShowDialog();

        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTodosClientes frm = new frmConsultaTodosClientes();
                frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente frm = new frmBusquedaCliente();
            frm.ShowDialog();
        }

        private void EditarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarCliente frm = new frmEditarCliente();
            frm.ShowDialog();
        }

        private void agregarNuevosClienteslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frm   = new   frmAgregarCliente();
            frm.ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes_Foreach_ frm = new frmConsultaClientes_Foreach_();  
            frm.ShowDialog();
        }
    }
}
