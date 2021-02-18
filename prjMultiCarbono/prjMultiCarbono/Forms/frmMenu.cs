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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frMenu_Shown(object sender, EventArgs e)
        {
            frLogin fr = new frLogin();            
            fr.ShowDialog();
        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente form = new frmConsultaCliente();
            form.ShowDialog();
        }
        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPedido form = new frmConsultaPedido();
            form.ShowDialog();
        }
        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario form = new frmConsultaFuncionario();
            form.ShowDialog();
        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoDeVenda form = new frmPedidoDeVenda();
            form.MdiParent = this;
            form.Show();
        }
        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Forms.frmCliente form = new Forms.frmCliente();
            form.MdiParent = this;
            form.Show();
        }
        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.frmFuncionario form = new frmFuncionario();
            form.MdiParent = this;
            form.Show();
        }
        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Forms.frmProduto form = new frmProduto();
            form.MdiParent = this;
            form.Show();
        }
        #region FrTeste
        private void frToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PadroesTelas.frPadraoConsulta form = new PadroesTelas.frPadraoConsulta();
            //PadroesTelas.frmPadraoCadastro form = new PadroesTelas.frmPadraoCadastro();
            //PadroesTelas.frmPadraoVisualizadorImp form = new PadroesTelas.frmPadraoVisualizadorImp();
            PadroesTelas.frmPadraoSelecao form = new PadroesTelas.frmPadraoSelecao();
            form.ShowDialog();
        }
        #endregion
        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultarProduto form = new frmConsultarProduto();
            form.ShowDialog();
        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void relátoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmVisualizadorRelatorios form = new frmVisualizadorRelatorios();
            frmGerarRelacaoCarregamento form = new frmGerarRelacaoCarregamento();
            //form.tipoRelatorio = "Cargas";
            //form.relatorio = new Relatorios.rltVendas();
            form.Show();
        }
        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmVisualizadorRelatorios form = new frmVisualizadorRelatorios();
            frmGerarReletorioVendas form = new frmGerarReletorioVendas();
            //form.tipoRelatorio = "Vendas";
            //form.relatorio  = new Relatorios.rltVendas();
            form.Show();
        }
    }
}
