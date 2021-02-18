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
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin")
                if (txtSenha.Text == "123")
                    this.Close(); //Entrou
                else 
                    lblMensagem.Text = "Senha Inválida."; //Senha errada
            else
                lblMensagem.Text = "Usuário não cadastrado."; //usuário não existe

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;

            if (txtUser.Text != string.Empty)
                if (txtSenha.Text != string.Empty)
                    btnEntrar.Enabled = true;
                else
                    btnEntrar.Enabled = false;
        }
    }
}
