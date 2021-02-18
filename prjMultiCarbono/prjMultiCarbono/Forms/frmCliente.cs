using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMultiCarbono.Forms
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
                        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmSelecionarPedidosCliente form = new frmSelecionarPedidosCliente();
            form.ShowDialog();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultaCliente frmConsultaCliente = new frmConsultaCliente();
            frmConsultaCliente.ShowDialog();
        }
    }
}
