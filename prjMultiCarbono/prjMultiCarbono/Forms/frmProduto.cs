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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frProduto_Load(object sender, EventArgs e)
        {

        }

        private void frProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                //não fecha e pergunta se ele quer sair sem salvar
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmConsultarProduto form = new frmConsultarProduto();
            form.ShowDialog();
        }
    }
}
