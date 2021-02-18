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
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add();
            dt.Columns.Add();

            dgvResultado.Rows.Add();

            dgvResultado.Rows[0].Cells[0].Value = txtCodigoCliente.Text;
            dgvResultado.Rows[0].Cells[1].Value = txtNome.Text;
        }
    }
}
