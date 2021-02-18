namespace prjMultiCarbono.Forms
{
    partial class frmFuncionario
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbRegiao = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultarCep = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbTelefones = new System.Windows.Forms.GroupBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.ckbSelecionarTudo = new System.Windows.Forms.CheckBox();
            this.btnIncluirTelefone = new System.Windows.Forms.Button();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.colCodTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirTelefone = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.gpbCliente.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbTelefones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.label19);
            this.gpbCliente.Controls.Add(this.txtConfirmarSenha);
            this.gpbCliente.Controls.Add(this.txtSenha);
            this.gpbCliente.Controls.Add(this.textBox1);
            this.gpbCliente.Controls.Add(this.label18);
            this.gpbCliente.Controls.Add(this.txtNomeUsuario);
            this.gpbCliente.Controls.Add(this.mtbCpf);
            this.gpbCliente.Controls.Add(this.ckbAtivo);
            this.gpbCliente.Controls.Add(this.label16);
            this.gpbCliente.Controls.Add(this.txtNacionalidade);
            this.gpbCliente.Controls.Add(this.label1);
            this.gpbCliente.Controls.Add(this.cmbSexo);
            this.gpbCliente.Controls.Add(this.cmbRegiao);
            this.gpbCliente.Controls.Add(this.label14);
            this.gpbCliente.Controls.Add(this.dtpNascimento);
            this.gpbCliente.Controls.Add(this.label13);
            this.gpbCliente.Controls.Add(this.txtRg);
            this.gpbCliente.Controls.Add(this.label12);
            this.gpbCliente.Controls.Add(this.dtpCadastro);
            this.gpbCliente.Controls.Add(this.label2);
            this.gpbCliente.Controls.Add(this.txtNome);
            this.gpbCliente.Controls.Add(this.label8);
            this.gpbCliente.Controls.Add(this.label4);
            this.gpbCliente.Controls.Add(this.label7);
            this.gpbCliente.Controls.Add(this.cmbCargo);
            this.gpbCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(583, 131);
            this.gpbCliente.TabIndex = 43;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Funcionário";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(57, 26);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(90, 20);
            this.mtbCpf.TabIndex = 60;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(511, 84);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 59;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(321, 53);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidade.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(197, 53);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(36, 21);
            this.cmbSexo.TabIndex = 55;
            // 
            // cmbRegiao
            // 
            this.cmbRegiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegiao.FormattingEnabled = true;
            this.cmbRegiao.Items.AddRange(new object[] {
            "",
            "NORTE",
            "NORDESTE",
            "SUDESTE",
            "SUL",
            "CENTRO OESTE"});
            this.cmbRegiao.Location = new System.Drawing.Point(243, 80);
            this.cmbRegiao.Name = "cmbRegiao";
            this.cmbRegiao.Size = new System.Drawing.Size(106, 21);
            this.cmbRegiao.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "RG";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(497, 53);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(80, 20);
            this.dtpNascimento.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Dt.Nasc.";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(57, 52);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(90, 20);
            this.txtRg.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "CPF";
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastro.Location = new System.Drawing.Point(425, 81);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(80, 20);
            this.dtpCadastro.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(381, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Região";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Dt. Cadastro";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "",
            "Analista de Vendas",
            "Gerente de Vendas",
            "Técnico de Vendas"});
            this.cmbCargo.Location = new System.Drawing.Point(57, 79);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(134, 21);
            this.cmbCargo.TabIndex = 41;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(520, 336);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 51;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Novo";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.cmbCidade);
            this.gpbEndereco.Controls.Add(this.cmbPais);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.label17);
            this.gpbEndereco.Controls.Add(this.label15);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.label5);
            this.gpbEndereco.Controls.Add(this.cmbUf);
            this.gpbEndereco.Controls.Add(this.label6);
            this.gpbEndereco.Controls.Add(this.btnConsultarCep);
            this.gpbEndereco.Controls.Add(this.txtCep);
            this.gpbEndereco.Controls.Add(this.label11);
            this.gpbEndereco.Controls.Add(this.label10);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.label9);
            this.gpbEndereco.Location = new System.Drawing.Point(293, 149);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(302, 181);
            this.gpbEndereco.TabIndex = 44;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "SOROCABA",
            "ITU",
            "SÃO PAULO",
            "VOTORANTIM"});
            this.cmbCidade.Location = new System.Drawing.Point(66, 151);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.TabIndex = 67;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "BRASIL",
            "CHINA"});
            this.cmbPais.Location = new System.Drawing.Point(66, 98);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 66;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(256, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 20);
            this.txtNumero.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(234, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Nº";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Pais";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(66, 72);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(165, 20);
            this.txtBairro.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Bairro";
            // 
            // cmbUf
            // 
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "PR",
            "RS"});
            this.cmbUf.Location = new System.Drawing.Point(66, 124);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(36, 21);
            this.cmbUf.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cidade";
            // 
            // btnConsultarCep
            // 
            this.btnConsultarCep.Location = new System.Drawing.Point(129, 18);
            this.btnConsultarCep.Name = "btnConsultarCep";
            this.btnConsultarCep.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCep.TabIndex = 54;
            this.btnConsultarCep.Text = "Consultar";
            this.btnConsultarCep.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(42, 20);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(81, 20);
            this.txtCep.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "UF";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(66, 46);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(165, 20);
            this.txtLogradouro.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Logradouro";
            // 
            // gpbTelefones
            // 
            this.gpbTelefones.Controls.Add(this.txtDdd);
            this.gpbTelefones.Controls.Add(this.ckbSelecionarTudo);
            this.gpbTelefones.Controls.Add(this.btnIncluirTelefone);
            this.gpbTelefones.Controls.Add(this.dgvTelefones);
            this.gpbTelefones.Controls.Add(this.btnExcluirTelefone);
            this.gpbTelefones.Controls.Add(this.txtTelefone);
            this.gpbTelefones.Controls.Add(this.label3);
            this.gpbTelefones.Location = new System.Drawing.Point(12, 149);
            this.gpbTelefones.Name = "gpbTelefones";
            this.gpbTelefones.Size = new System.Drawing.Size(275, 181);
            this.gpbTelefones.TabIndex = 54;
            this.gpbTelefones.TabStop = false;
            this.gpbTelefones.Text = "Telefones";
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(83, 17);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(33, 20);
            this.txtDdd.TabIndex = 48;
            // 
            // ckbSelecionarTudo
            // 
            this.ckbSelecionarTudo.AutoSize = true;
            this.ckbSelecionarTudo.Location = new System.Drawing.Point(11, 20);
            this.ckbSelecionarTudo.Name = "ckbSelecionarTudo";
            this.ckbSelecionarTudo.Size = new System.Drawing.Size(15, 14);
            this.ckbSelecionarTudo.TabIndex = 47;
            this.ckbSelecionarTudo.UseVisualStyleBackColor = true;
            // 
            // btnIncluirTelefone
            // 
            this.btnIncluirTelefone.Enabled = false;
            this.btnIncluirTelefone.Location = new System.Drawing.Point(220, 15);
            this.btnIncluirTelefone.Name = "btnIncluirTelefone";
            this.btnIncluirTelefone.Size = new System.Drawing.Size(49, 23);
            this.btnIncluirTelefone.TabIndex = 46;
            this.btnIncluirTelefone.Text = "Incluir";
            this.btnIncluirTelefone.UseVisualStyleBackColor = true;
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.AllowUserToAddRows = false;
            this.dgvTelefones.AllowUserToDeleteRows = false;
            this.dgvTelefones.AllowUserToOrderColumns = true;
            this.dgvTelefones.AllowUserToResizeColumns = false;
            this.dgvTelefones.AllowUserToResizeRows = false;
            this.dgvTelefones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodTelefone,
            this.colSelecionar,
            this.colTelefone});
            this.dgvTelefones.Location = new System.Drawing.Point(6, 44);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.RowHeadersVisible = false;
            this.dgvTelefones.Size = new System.Drawing.Size(263, 101);
            this.dgvTelefones.TabIndex = 45;
            // 
            // colCodTelefone
            // 
            this.colCodTelefone.HeaderText = "codTelefone";
            this.colCodTelefone.Name = "colCodTelefone";
            this.colCodTelefone.ReadOnly = true;
            this.colCodTelefone.Visible = false;
            // 
            // colSelecionar
            // 
            this.colSelecionar.HeaderText = "";
            this.colSelecionar.Name = "colSelecionar";
            this.colSelecionar.Width = 20;
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            // 
            // btnExcluirTelefone
            // 
            this.btnExcluirTelefone.Enabled = false;
            this.btnExcluirTelefone.Location = new System.Drawing.Point(194, 148);
            this.btnExcluirTelefone.Name = "btnExcluirTelefone";
            this.btnExcluirTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirTelefone.TabIndex = 44;
            this.btnExcluirTelefone.Text = "Excluir";
            this.btnExcluirTelefone.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(122, 17);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(92, 20);
            this.txtTelefone.TabIndex = 43;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(437, 336);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 55;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Nome de Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(111, 106);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtNomeUsuario.TabIndex = 62;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Location = new System.Drawing.Point(265, 110);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(38, 13);
            this.txtSenha.TabIndex = 63;
            this.txtSenha.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 64;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(412, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 65;
            this.label19.Text = "Conf. Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(482, 106);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(95, 20);
            this.txtConfirmarSenha.TabIndex = 66;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 366);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbTelefones);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFuncionario";
            this.ShowIcon = false;
            this.Text = "MultiCarbono -Gerenciar - Funcionários";
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbTelefones.ResumeLayout(false);
            this.gpbTelefones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRegiao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Button btnConsultarCep;
        private System.Windows.Forms.GroupBox gpbTelefones;
        private System.Windows.Forms.CheckBox ckbSelecionarTudo;
        private System.Windows.Forms.Button btnIncluirTelefone;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private System.Windows.Forms.Button btnExcluirTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodTelefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomeUsuario;
    }
}