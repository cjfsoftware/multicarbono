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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            
            dgvResultado.Rows.Add();

            dgvResultado.Rows[0].Cells[1].Value = txtCnpj.Text;
            dgvResultado.Rows[0].Cells[2].Value = txtNome.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
