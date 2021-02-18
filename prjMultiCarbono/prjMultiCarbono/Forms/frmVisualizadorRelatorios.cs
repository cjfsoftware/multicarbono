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
    public partial class frmVisualizadorRelatorios : Form
    {
        public string tipoRelatorio;
        //public object relatorio;

        public frmVisualizadorRelatorios()
        {
            InitializeComponent();
        }

        private void frmVisualizadorRelatorios_Load(object sender, EventArgs e)
        {
            this.Text = "MultiCarbono - " + tipoRelatorio + " - Vendas";

            //crvInterface.ReportSource = new Relatorios.rltVendas1();
            //crvInterface.Refresh();
            
        }
    }
}
