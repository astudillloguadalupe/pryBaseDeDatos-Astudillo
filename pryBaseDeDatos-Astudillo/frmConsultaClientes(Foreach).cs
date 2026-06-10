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
            clsClientes x = new clsClientes();
            x.ListarForeach(dgvConsulta);
        }
    }
}
