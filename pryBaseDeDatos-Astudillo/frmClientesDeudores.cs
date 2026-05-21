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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        private void gbConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void btnListarDeu_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ListarDeudoresBD(dgvClientes);
            lblCantClie.Text = x.CantidadDeudores.ToString();
            lblTotalDeuda.Text = x.TotalDeuda.ToString();
           // lblPromedio.Text= x.PromDeuda.ToString("0,00");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ReporteClientes();
            MessageBox.Show("El Reporte se genero correctamente");
        }
    }
}
