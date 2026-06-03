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
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            clsAutomovil auto = new clsAutomovil();
            auto.ListarAutomoviles(cmbAutoMovil);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.nom = txtNombreApellido.Text;
            x.lim = Convert.ToDecimal(txtLimite.Text);
            x.idAu = Convert.ToInt32(cmbAutoMovil.SelectedValue);
            x.Agregar();

            MessageBox.Show("Datos cargados correctamente");
            txtNombreApellido.Text = "";
            txtLimite.Text = "";
            cmbAutoMovil.SelectedIndex = 0;
        }
    }
}
