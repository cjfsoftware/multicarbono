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
    public partial class frmNotaFiscal : Form
    {
        public frmNotaFiscal()
        {
            InitializeComponent();
        }

        private void frNotaFiscal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVisualizadorRelatorios form = new frmVisualizadorRelatorios();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Comunicação com SEFAZ

            MessageBox.Show("Nota Fiscal emitida com Sucesso!", 
                "Emissão Nota Fiscal", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            btnEmitirNotaFiscal.Enabled = false;
        }
    }
}
