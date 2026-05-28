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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un codigo");
                txtCodigo.Focus();
                return;
            }
            Int32 IDCliente = Convert.ToInt32(txtCodigo.Text);

            clsClientes x = new clsClientes();

            x.Buscar(IDCliente);
            txtCodigo.Clear();
            
            if (x.idCli != 0)
            {
                lblNombreRTA.Text = x.nom;
                lblDeudaRTA.Text = x.deu.ToString();
                lblLimiteRTA.Text = x.lim.ToString();
            }
            else
            {
                lblNombreRTA.Text = "";
                lblDeudaRTA.Text = "";
                lblLimiteRTA.Text = "";
                

                MessageBox.Show("Cliente no existente");
            }
        }
    }
}
