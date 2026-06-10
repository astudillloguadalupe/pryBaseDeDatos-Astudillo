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
    public partial class frmConsultaClientes_Foreach_ : Form
    {
        public frmConsultaClientes_Foreach_()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmConsultaClientes_Foreach__Load(object sender, EventArgs e)
        {
            CrearColumnas();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();

            clsClientes x = new clsClientes();
            x.ListarForeach(dgvConsulta);
        }
        private void CrearColumnas()
        {
            dgvConsulta.Columns.Clear();

            dgvConsulta.Columns.Add("Codigo", "Código");
            dgvConsulta.Columns.Add("Nombre", "Nombre");
            dgvConsulta.Columns.Add("Deuda", "Deuda");
            dgvConsulta.Columns.Add("Limite", "Límite");
            dgvConsulta.Columns.Add("Automovil", "Automóvil");
        }
    }
}
