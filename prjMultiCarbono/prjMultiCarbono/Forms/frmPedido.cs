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
    public partial class frmPedidoDeVenda : Form
    {
        public frmPedidoDeVenda()
        {
            InitializeComponent();
        }

        private void frPedidoDeVenda_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUnidadeItem.Text = "Unidade - ";
        }

        private void btnSelecionarEndereco_Click(object sender, EventArgs e)
        {
            frmSelecionarEnderecosEntrega form = new frmSelecionarEnderecosEntrega();
            form.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultaPedido frmConsultaPedido = new frmConsultaPedido();
            frmConsultaPedido.ShowDialog();
        }

        private void btnVisualizarNotaFiscal_Click(object sender, EventArgs e)
        {
            if(txtNumeroPedido.Text == string.Empty)
            {
                MessageBox.Show("Falha na comunicação com o Servidor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Falta informar o pedido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                frmNotaFiscal form = new frmNotaFiscal();
                form.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
