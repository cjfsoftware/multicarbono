namespace prjMultiCarbono.Forms
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVrUnitario = new System.Windows.Forms.TextBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNcmsh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAliqIpi = new System.Windows.Forms.TextBox();
            this.txtAliqIcms = new System.Windows.Forms.TextBox();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(57, 19);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(278, 19);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(263, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidade";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "",
            "KG",
            "TON"});
            this.cmbUnidade.Location = new System.Drawing.Point(368, 45);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(100, 21);
            this.cmbUnidade.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor Unitário";
            // 
            // txtVrUnitario
            // 
            this.txtVrUnitario.Location = new System.Drawing.Point(97, 71);
            this.txtVrUnitario.Name = "txtVrUnitario";
            this.txtVrUnitario.Size = new System.Drawing.Size(70, 20);
            this.txtVrUnitario.TabIndex = 13;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(163, 21);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 15;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(486, 125);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtCst
            // 
            this.txtCst.Location = new System.Drawing.Point(203, 45);
            this.txtCst.Name = "txtCst";
            this.txtCst.Size = new System.Drawing.Size(100, 20);
            this.txtCst.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "NCMSH";
            // 
            // txtNcmsh
            // 
            this.txtNcmsh.Location = new System.Drawing.Point(63, 45);
            this.txtNcmsh.Name = "txtNcmsh";
            this.txtNcmsh.Size = new System.Drawing.Size(100, 20);
            this.txtNcmsh.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Alíquota ICMS (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Alíquota IPI (%)";
            // 
            // txtAliqIpi
            // 
            this.txtAliqIpi.Location = new System.Drawing.Point(418, 72);
            this.txtAliqIpi.Name = "txtAliqIpi";
            this.txtAliqIpi.Size = new System.Drawing.Size(50, 20);
            this.txtAliqIpi.TabIndex = 23;
            // 
            // txtAliqIcms
            // 
            this.txtAliqIcms.Location = new System.Drawing.Point(275, 72);
            this.txtAliqIcms.Name = "txtAliqIcms";
            this.txtAliqIcms.Size = new System.Drawing.Size(50, 20);
            this.txtAliqIcms.TabIndex = 24;
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.txtAliqIcms);
            this.gpbProduto.Controls.Add(this.txtAliqIpi);
            this.gpbProduto.Controls.Add(this.label8);
            this.gpbProduto.Controls.Add(this.label7);
            this.gpbProduto.Controls.Add(this.txtNcmsh);
            this.gpbProduto.Controls.Add(this.label6);
            this.gpbProduto.Controls.Add(this.label2);
            this.gpbProduto.Controls.Add(this.txtCst);
            this.gpbProduto.Controls.Add(this.ckbAtivo);
            this.gpbProduto.Controls.Add(this.txtVrUnitario);
            this.gpbProduto.Controls.Add(this.label5);
            this.gpbProduto.Controls.Add(this.cmbUnidade);
            this.gpbProduto.Controls.Add(this.label4);
            this.gpbProduto.Controls.Add(this.label3);
            this.gpbProduto.Controls.Add(this.txtDescricao);
            this.gpbProduto.Controls.Add(this.label1);
            this.gpbProduto.Controls.Add(this.txtCodigoProduto);
            this.gpbProduto.Location = new System.Drawing.Point(12, 12);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(549, 107);
            this.gpbProduto.TabIndex = 25;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Informações";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(405, 125);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 157);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbProduto);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.ShowIcon = false;
            this.Text = "MultiCarbono - Gerenciar - Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frProduto_FormClosing);
            this.Load += new System.EventHandler(this.frProduto_Load);
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVrUnitario;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNcmsh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAliqIpi;
        private System.Windows.Forms.TextBox txtAliqIcms;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Button btnConsultar;
    }
}