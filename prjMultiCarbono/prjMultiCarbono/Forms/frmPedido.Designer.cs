namespace prjMultiCarbono.Forms
{
    partial class frmPedidoDeVenda
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
            this.components = new System.ComponentModel.Container();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtpCarregamento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.gpbItensPedido = new System.Windows.Forms.GroupBox();
            this.lblUnidadeItem = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.ckbSelTudo = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluirItemPedido = new System.Windows.Forms.Button();
            this.dgvItensPedido = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCfop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAliICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAliIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gpbPedido = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbFaturado = new System.Windows.Forms.CheckBox();
            this.gpbEntrega = new System.Windows.Forms.GroupBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairrro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnSelecionarEndereco = new System.Windows.Forms.Button();
            this.gpbNfe = new System.Windows.Forms.GroupBox();
            this.btnVisualizarNotaFiscal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ttpDica = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpbCliente.SuspendLayout();
            this.gpbItensPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).BeginInit();
            this.gpbPedido.SuspendLayout();
            this.gpbEntrega.SuspendLayout();
            this.gpbNfe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(217, 19);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(61, 23);
            this.btnConsultarCliente.TabIndex = 38;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CNPJ Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(111, 21);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(330, 21);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(231, 20);
            this.txtNomeCliente.TabIndex = 23;
            // 
            // dtpCarregamento
            // 
            this.dtpCarregamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCarregamento.Location = new System.Drawing.Point(257, 25);
            this.dtpCarregamento.Name = "dtpCarregamento";
            this.dtpCarregamento.Size = new System.Drawing.Size(96, 20);
            this.dtpCarregamento.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Dt. de Emissão";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(90, 20);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(106, 20);
            this.txtNumeroPedido.TabIndex = 19;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(311, 19);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(96, 20);
            this.dtpEmissao.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Dt. Carregamento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(687, 524);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnConsultarCliente);
            this.gpbCliente.Controls.Add(this.txtCliente);
            this.gpbCliente.Controls.Add(this.label2);
            this.gpbCliente.Controls.Add(this.txtNomeCliente);
            this.gpbCliente.Controls.Add(this.label4);
            this.gpbCliente.Location = new System.Drawing.Point(12, 158);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(737, 57);
            this.gpbCliente.TabIndex = 42;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // gpbItensPedido
            // 
            this.gpbItensPedido.Controls.Add(this.lblUnidadeItem);
            this.gpbItensPedido.Controls.Add(this.label11);
            this.gpbItensPedido.Controls.Add(this.txtQuantidade);
            this.gpbItensPedido.Controls.Add(this.label9);
            this.gpbItensPedido.Controls.Add(this.cmbProduto);
            this.gpbItensPedido.Controls.Add(this.ckbSelTudo);
            this.gpbItensPedido.Controls.Add(this.btnAdicionar);
            this.gpbItensPedido.Controls.Add(this.btnExcluirItemPedido);
            this.gpbItensPedido.Controls.Add(this.dgvItensPedido);
            this.gpbItensPedido.Location = new System.Drawing.Point(12, 337);
            this.gpbItensPedido.Name = "gpbItensPedido";
            this.gpbItensPedido.Size = new System.Drawing.Size(737, 181);
            this.gpbItensPedido.TabIndex = 43;
            this.gpbItensPedido.TabStop = false;
            this.gpbItensPedido.Text = "Itens";
            // 
            // lblUnidadeItem
            // 
            this.lblUnidadeItem.AutoSize = true;
            this.lblUnidadeItem.Location = new System.Drawing.Point(514, 16);
            this.lblUnidadeItem.Name = "lblUnidadeItem";
            this.lblUnidadeItem.Size = new System.Drawing.Size(27, 13);
            this.lblUnidadeItem.TabIndex = 24;
            this.lblUnidadeItem.Text = "unid";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(408, 14);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(79, 14);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(245, 21);
            this.cmbProduto.TabIndex = 12;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ckbSelTudo
            // 
            this.ckbSelTudo.AutoSize = true;
            this.ckbSelTudo.Location = new System.Drawing.Point(8, 18);
            this.ckbSelTudo.Name = "ckbSelTudo";
            this.ckbSelTudo.Size = new System.Drawing.Size(15, 14);
            this.ckbSelTudo.TabIndex = 11;
            this.ttpDica.SetToolTip(this.ckbSelTudo, "Selecionar Tudo");
            this.ckbSelTudo.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(594, 11);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar Item";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItemPedido
            // 
            this.btnExcluirItemPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirItemPedido.Location = new System.Drawing.Point(647, 152);
            this.btnExcluirItemPedido.Name = "btnExcluirItemPedido";
            this.btnExcluirItemPedido.Size = new System.Drawing.Size(84, 23);
            this.btnExcluirItemPedido.TabIndex = 9;
            this.btnExcluirItemPedido.Text = "Excluir Selec.";
            this.btnExcluirItemPedido.UseVisualStyleBackColor = true;
            // 
            // dgvItensPedido
            // 
            this.dgvItensPedido.AllowUserToAddRows = false;
            this.dgvItensPedido.AllowUserToDeleteRows = false;
            this.dgvItensPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItensPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.colCst,
            this.Column5,
            this.Column6,
            this.Column7,
            this.colVrDesconto,
            this.colCfop,
            this.colAliICMS,
            this.colAliIPI,
            this.Column8});
            this.dgvItensPedido.Location = new System.Drawing.Point(0, 41);
            this.dgvItensPedido.MultiSelect = false;
            this.dgvItensPedido.Name = "dgvItensPedido";
            this.dgvItensPedido.RowHeadersVisible = false;
            this.dgvItensPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensPedido.Size = new System.Drawing.Size(737, 108);
            this.dgvItensPedido.TabIndex = 8;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Width = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cód. Produto";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NCMSH";
            this.Column4.Name = "Column4";
            // 
            // colCst
            // 
            this.colCst.HeaderText = "CST";
            this.colCst.Name = "colCst";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unidade";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantidade";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Valor Unitário";
            this.Column7.Name = "Column7";
            // 
            // colVrDesconto
            // 
            this.colVrDesconto.HeaderText = "Valor Desconto";
            this.colVrDesconto.Name = "colVrDesconto";
            // 
            // colCfop
            // 
            this.colCfop.HeaderText = "CFOP";
            this.colCfop.Name = "colCfop";
            // 
            // colAliICMS
            // 
            this.colAliICMS.HeaderText = "Alíquota ICMS";
            this.colAliICMS.Name = "colAliICMS";
            // 
            // colAliIPI
            // 
            this.colAliIPI.HeaderText = "Alíquota IPI";
            this.colAliIPI.Name = "colAliIPI";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Subtotal";
            this.Column8.Name = "Column8";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(90, 49);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(455, 20);
            this.txtObs.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Observação";
            // 
            // gpbPedido
            // 
            this.gpbPedido.Controls.Add(this.label18);
            this.gpbPedido.Controls.Add(this.label17);
            this.gpbPedido.Controls.Add(this.label16);
            this.gpbPedido.Controls.Add(this.label15);
            this.gpbPedido.Controls.Add(this.dateTimePicker1);
            this.gpbPedido.Controls.Add(this.label13);
            this.gpbPedido.Controls.Add(this.comboBox1);
            this.gpbPedido.Controls.Add(this.label6);
            this.gpbPedido.Controls.Add(this.ckbFaturado);
            this.gpbPedido.Controls.Add(this.label1);
            this.gpbPedido.Controls.Add(this.txtObs);
            this.gpbPedido.Controls.Add(this.label10);
            this.gpbPedido.Controls.Add(this.txtNumeroPedido);
            this.gpbPedido.Controls.Add(this.dtpEmissao);
            this.gpbPedido.Controls.Add(this.label7);
            this.gpbPedido.Location = new System.Drawing.Point(12, 11);
            this.gpbPedido.Name = "gpbPedido";
            this.gpbPedido.Padding = new System.Windows.Forms.Padding(0);
            this.gpbPedido.Size = new System.Drawing.Size(561, 141);
            this.gpbPedido.TabIndex = 44;
            this.gpbPedido.TabStop = false;
            this.gpbPedido.Text = "Pedido";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(304, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = " R$ 00000,00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Valor Total Pedido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(304, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = " R$   0000,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Valor Frete";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 18, 12, 57, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Dt. de Entrega";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tipo de Frete";
            // 
            // ckbFaturado
            // 
            this.ckbFaturado.AutoSize = true;
            this.ckbFaturado.Location = new System.Drawing.Point(470, 19);
            this.ckbFaturado.Name = "ckbFaturado";
            this.ckbFaturado.Size = new System.Drawing.Size(68, 17);
            this.ckbFaturado.TabIndex = 30;
            this.ckbFaturado.Text = "Faturado";
            this.ckbFaturado.UseVisualStyleBackColor = true;
            // 
            // gpbEntrega
            // 
            this.gpbEntrega.Controls.Add(this.mtbCep);
            this.gpbEntrega.Controls.Add(this.txtNumero);
            this.gpbEntrega.Controls.Add(this.label3);
            this.gpbEntrega.Controls.Add(this.txtPais);
            this.gpbEntrega.Controls.Add(this.label8);
            this.gpbEntrega.Controls.Add(this.txtBairrro);
            this.gpbEntrega.Controls.Add(this.label14);
            this.gpbEntrega.Controls.Add(this.cmbUf);
            this.gpbEntrega.Controls.Add(this.label21);
            this.gpbEntrega.Controls.Add(this.label22);
            this.gpbEntrega.Controls.Add(this.txtCidade);
            this.gpbEntrega.Controls.Add(this.label23);
            this.gpbEntrega.Controls.Add(this.txtLogradouro);
            this.gpbEntrega.Controls.Add(this.label24);
            this.gpbEntrega.Controls.Add(this.btnSelecionarEndereco);
            this.gpbEntrega.Controls.Add(this.dtpCarregamento);
            this.gpbEntrega.Controls.Add(this.label5);
            this.gpbEntrega.Location = new System.Drawing.Point(12, 221);
            this.gpbEntrega.Name = "gpbEntrega";
            this.gpbEntrega.Size = new System.Drawing.Size(737, 110);
            this.gpbEntrega.TabIndex = 45;
            this.gpbEntrega.TabStop = false;
            this.gpbEntrega.Text = "Entrega";
            // 
            // mtbCep
            // 
            this.mtbCep.Enabled = false;
            this.mtbCep.Location = new System.Drawing.Point(39, 51);
            this.mtbCep.Mask = "00000-00";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(66, 20);
            this.mtbCep.TabIndex = 91;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(368, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 20);
            this.txtNumero.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nº";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(307, 77);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Pais";
            // 
            // txtBairrro
            // 
            this.txtBairrro.Enabled = false;
            this.txtBairrro.Location = new System.Drawing.Point(450, 52);
            this.txtBairrro.Name = "txtBairrro";
            this.txtBairrro.Size = new System.Drawing.Size(138, 20);
            this.txtBairrro.TabIndex = 83;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(413, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 82;
            this.label14.Text = "Bairro";
            // 
            // cmbUf
            // 
            this.cmbUf.Enabled = false;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(228, 77);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(36, 21);
            this.cmbUf.TabIndex = 81;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 79;
            this.label21.Text = "CEP";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(201, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 78;
            this.label22.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(56, 77);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(138, 20);
            this.txtCidade.TabIndex = 77;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 76;
            this.label23.Text = "Cidade";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(175, 52);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(165, 20);
            this.txtLogradouro.TabIndex = 75;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(111, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 13);
            this.label24.TabIndex = 74;
            this.label24.Text = "Logradouro";
            // 
            // btnSelecionarEndereco
            // 
            this.btnSelecionarEndereco.Location = new System.Drawing.Point(19, 22);
            this.btnSelecionarEndereco.Name = "btnSelecionarEndereco";
            this.btnSelecionarEndereco.Size = new System.Drawing.Size(134, 23);
            this.btnSelecionarEndereco.TabIndex = 30;
            this.btnSelecionarEndereco.Text = "Selecionar Endereço";
            this.btnSelecionarEndereco.UseVisualStyleBackColor = true;
            this.btnSelecionarEndereco.Click += new System.EventHandler(this.btnSelecionarEndereco_Click);
            // 
            // gpbNfe
            // 
            this.gpbNfe.Controls.Add(this.btnVisualizarNotaFiscal);
            this.gpbNfe.Controls.Add(this.label12);
            this.gpbNfe.Controls.Add(this.txtNotaFiscal);
            this.gpbNfe.Location = new System.Drawing.Point(579, 12);
            this.gpbNfe.Name = "gpbNfe";
            this.gpbNfe.Size = new System.Drawing.Size(170, 74);
            this.gpbNfe.TabIndex = 46;
            this.gpbNfe.TabStop = false;
            this.gpbNfe.Text = "NF-e";
            // 
            // btnVisualizarNotaFiscal
            // 
            this.btnVisualizarNotaFiscal.Location = new System.Drawing.Point(70, 39);
            this.btnVisualizarNotaFiscal.Name = "btnVisualizarNotaFiscal";
            this.btnVisualizarNotaFiscal.Size = new System.Drawing.Size(94, 23);
            this.btnVisualizarNotaFiscal.TabIndex = 2;
            this.btnVisualizarNotaFiscal.Text = "Visualizar";
            this.btnVisualizarNotaFiscal.UseVisualStyleBackColor = true;
            this.btnVisualizarNotaFiscal.Click += new System.EventHandler(this.btnVisualizarNotaFiscal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nota FIscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(70, 13);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(94, 20);
            this.txtNotaFiscal.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(619, 524);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(62, 23);
            this.btnConsultar.TabIndex = 39;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(529, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(579, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 57);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "CPF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            // 
            // frmPedidoDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpbNfe);
            this.Controls.Add(this.gpbEntrega);
            this.Controls.Add(this.gpbPedido);
            this.Controls.Add(this.gpbItensPedido);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoDeVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiCarbono - Vendas - Pedido de Venda";
            this.Load += new System.EventHandler(this.frPedidoDeVenda_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbItensPedido.ResumeLayout(false);
            this.gpbItensPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).EndInit();
            this.gpbPedido.ResumeLayout(false);
            this.gpbPedido.PerformLayout();
            this.gpbEntrega.ResumeLayout(false);
            this.gpbEntrega.PerformLayout();
            this.gpbNfe.ResumeLayout(false);
            this.gpbNfe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtpCarregamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox gpbItensPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.CheckBox ckbSelTudo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluirItemPedido;
        private System.Windows.Forms.DataGridView dgvItensPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCfop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAliICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAliIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpbPedido;
        private System.Windows.Forms.GroupBox gpbEntrega;
        private System.Windows.Forms.CheckBox ckbFaturado;
        private System.Windows.Forms.Button btnSelecionarEndereco;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairrro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox gpbNfe;
        private System.Windows.Forms.Button btnVisualizarNotaFiscal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblUnidadeItem;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ToolTip ttpDica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
    }
}