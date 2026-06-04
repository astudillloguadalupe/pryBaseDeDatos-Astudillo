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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
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
                txtLimite.Text = x.lim.ToString();
            }
            else
            {
                lblNombreRTA.Text = "";
                lblDeudaRTA.Text = "";
                txtLimite.Text = "";


                MessageBox.Show("Cliente no existente");
            }
            txtLimite.ReadOnly = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled= false;
            btnEliminar.Enabled= false;
            btnBuscar.Enabled= false;
            btnGuardar.Enabled= false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else 
            {
                btnBuscar.Enabled = false;  
            }
    }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnGuardar.Enabled=true;
            btnModificar.Enabled = false;
            txtLimite.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int id))
            {
                MessageBox.Show("Ingrese un código válido.");
                return;
            }

            if (!decimal.TryParse(txtLimite.Text, out decimal limite))
            {
                MessageBox.Show("Ingrese un límite válido.");
                return;
            }

            clsClientes x = new clsClientes();
            x.Limite = limite;
            x.Modificar(id);

            MessageBox.Show("El dato se cambió correctamente.");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            Int32 id = Convert.ToInt32(txtCodigo.Text);

            x.Eliminar(id);
            MessageBox.Show("Cliente Eliminado");

        }
    }
}
