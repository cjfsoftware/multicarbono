namespace prjMultiCarbono.Forms
{
    partial class frmNotaFiscal
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
            this.gpbItensNotaFiscal = new System.Windows.Forms.GroupBox();
            this.dgvItensNota = new System.Windows.Forms.DataGridView();
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
            this.gpbPedido = new System.Windows.Forms.GroupBox();
            this.ckbFaturado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChaveAcesso = new System.Windows.Forms.TextBox();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEmissaoNota = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbNotaFiscal = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.txtCnpjTransportador = new System.Windows.Forms.TextBox();
            this.gpbTransportador = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtValorFrete = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTipoFrete = new System.Windows.Forms.TextBox();
            this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtNumeracao = new System.Windows.Forms.TextBox();
            this.txtValorSeguro = new System.Windows.Forms.TextBox();
            this.txtQtdEmbalagens = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.btnEmitirNotaFiscal = new System.Windows.Forms.Button();
            this.btnExibirPedido = new System.Windows.Forms.Button();
            this.btnVisualizarNotaFiscal = new System.Windows.Forms.Button();
            this.gpbItensNotaFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensNota)).BeginInit();
            this.gpbPedido.SuspendLayout();
            this.gpbNotaFiscal.SuspendLayout();
            this.gpbTransportador.SuspendLayout();
            this.gpbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbItensNotaFiscal
            // 
            this.gpbItensNotaFiscal.Controls.Add(this.dgvItensNota);
            this.gpbItensNotaFiscal.Location = new System.Drawing.Point(12, 148);
            this.gpbItensNotaFiscal.Name = "gpbItensNotaFiscal";
            this.gpbItensNotaFiscal.Size = new System.Drawing.Size(737, 137);
            this.gpbItensNotaFiscal.TabIndex = 44;
            this.gpbItensNotaFiscal.TabStop = false;
            this.gpbItensNotaFiscal.Text = "Itens";
            // 
            // dgvItensNota
            // 
            this.dgvItensNota.AllowUserToAddRows = false;
            this.dgvItensNota.AllowUserToDeleteRows = false;
            this.dgvItensNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItensNota.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItensNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvItensNota.Location = new System.Drawing.Point(0, 19);
            this.dgvItensNota.MultiSelect = false;
            this.dgvItensNota.Name = "dgvItensNota";
            this.dgvItensNota.RowHeadersVisible = false;
            this.dgvItensNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensNota.Size = new System.Drawing.Size(737, 108);
            this.dgvItensNota.TabIndex = 8;
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
            // gpbPedido
            // 
            this.gpbPedido.Controls.Add(this.ckbFaturado);
            this.gpbPedido.Controls.Add(this.label2);
            this.gpbPedido.Controls.Add(this.txtNumero);
            this.gpbPedido.Controls.Add(this.dtpEmissao);
            this.gpbPedido.Controls.Add(this.label7);
            this.gpbPedido.Location = new System.Drawing.Point(12, 92);
            this.gpbPedido.Name = "gpbPedido";
            this.gpbPedido.Size = new System.Drawing.Size(737, 50);
            this.gpbPedido.TabIndex = 45;
            this.gpbPedido.TabStop = false;
            this.gpbPedido.Text = "Pedido";
            // 
            // ckbFaturado
            // 
            this.ckbFaturado.AutoSize = true;
            this.ckbFaturado.Location = new System.Drawing.Point(445, 20);
            this.ckbFaturado.Name = "ckbFaturado";
            this.ckbFaturado.Size = new System.Drawing.Size(68, 17);
            this.ckbFaturado.TabIndex = 30;
            this.ckbFaturado.Text = "Faturado";
            this.ckbFaturado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(70, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 20);
            this.txtNumero.TabIndex = 19;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(336, 17);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(96, 20);
            this.dtpEmissao.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Dt. de Emissão";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Nota FIscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(70, 19);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(86, 20);
            this.txtNotaFiscal.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Chave de Acesso";
            // 
            // txtChaveAcesso
            // 
            this.txtChaveAcesso.Location = new System.Drawing.Point(259, 19);
            this.txtChaveAcesso.Name = "txtChaveAcesso";
            this.txtChaveAcesso.Size = new System.Drawing.Size(122, 20);
            this.txtChaveAcesso.TabIndex = 48;
            // 
            // cmbOperacao
            // 
            this.cmbOperacao.FormattingEnabled = true;
            this.cmbOperacao.Location = new System.Drawing.Point(445, 18);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacao.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Operação";
            // 
            // dtpEmissaoNota
            // 
            this.dtpEmissaoNota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissaoNota.Location = new System.Drawing.Point(641, 19);
            this.dtpEmissaoNota.Name = "dtpEmissaoNota";
            this.dtpEmissaoNota.Size = new System.Drawing.Size(80, 20);
            this.dtpEmissaoNota.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dt. Emissão";
            // 
            // gpbNotaFiscal
            // 
            this.gpbNotaFiscal.Controls.Add(this.label8);
            this.gpbNotaFiscal.Controls.Add(this.dtpSaida);
            this.gpbNotaFiscal.Controls.Add(this.label6);
            this.gpbNotaFiscal.Controls.Add(this.txtProtocolo);
            this.gpbNotaFiscal.Controls.Add(this.label5);
            this.gpbNotaFiscal.Controls.Add(this.dtpEmissaoNota);
            this.gpbNotaFiscal.Controls.Add(this.label4);
            this.gpbNotaFiscal.Controls.Add(this.cmbOperacao);
            this.gpbNotaFiscal.Controls.Add(this.label3);
            this.gpbNotaFiscal.Controls.Add(this.txtChaveAcesso);
            this.gpbNotaFiscal.Controls.Add(this.label12);
            this.gpbNotaFiscal.Controls.Add(this.txtNotaFiscal);
            this.gpbNotaFiscal.Location = new System.Drawing.Point(12, 12);
            this.gpbNotaFiscal.Name = "gpbNotaFiscal";
            this.gpbNotaFiscal.Size = new System.Drawing.Size(737, 74);
            this.gpbNotaFiscal.TabIndex = 54;
            this.gpbNotaFiscal.TabStop = false;
            this.gpbNotaFiscal.Text = "Nota FIscal";
            this.gpbNotaFiscal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Dt e Hr Saída";
            // 
            // dtpSaida
            // 
            this.dtpSaida.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(259, 45);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(103, 20);
            this.dtpSaida.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Protocolo";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Location = new System.Drawing.Point(70, 45);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(100, 20);
            this.txtProtocolo.TabIndex = 54;
            // 
            // txtCnpjTransportador
            // 
            this.txtCnpjTransportador.Location = new System.Drawing.Point(115, 19);
            this.txtCnpjTransportador.Name = "txtCnpjTransportador";
            this.txtCnpjTransportador.Size = new System.Drawing.Size(100, 20);
            this.txtCnpjTransportador.TabIndex = 65;
            // 
            // gpbTransportador
            // 
            this.gpbTransportador.Controls.Add(this.label17);
            this.gpbTransportador.Controls.Add(this.txtValorFrete);
            this.gpbTransportador.Controls.Add(this.label16);
            this.gpbTransportador.Controls.Add(this.txtTipoFrete);
            this.gpbTransportador.Controls.Add(this.txtPlacaVeiculo);
            this.gpbTransportador.Controls.Add(this.label10);
            this.gpbTransportador.Controls.Add(this.label15);
            this.gpbTransportador.Controls.Add(this.txtCnpjTransportador);
            this.gpbTransportador.Location = new System.Drawing.Point(12, 291);
            this.gpbTransportador.Name = "gpbTransportador";
            this.gpbTransportador.Size = new System.Drawing.Size(737, 48);
            this.gpbTransportador.TabIndex = 66;
            this.gpbTransportador.TabStop = false;
            this.gpbTransportador.Text = "Transportador e Frete";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(551, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "Valor Frete";
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(615, 19);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Size = new System.Drawing.Size(100, 20);
            this.txtValorFrete.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Tipo Frete";
            // 
            // txtTipoFrete
            // 
            this.txtTipoFrete.Location = new System.Drawing.Point(445, 19);
            this.txtTipoFrete.Name = "txtTipoFrete";
            this.txtTipoFrete.Size = new System.Drawing.Size(100, 20);
            this.txtTipoFrete.TabIndex = 69;
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(313, 19);
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(68, 20);
            this.txtPlacaVeiculo.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Placa Veículo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "CNPJ Transportador";
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.label1);
            this.gpbInformacoes.Controls.Add(this.txtEspecie);
            this.gpbInformacoes.Controls.Add(this.txtNumeracao);
            this.gpbInformacoes.Controls.Add(this.txtValorSeguro);
            this.gpbInformacoes.Controls.Add(this.txtQtdEmbalagens);
            this.gpbInformacoes.Controls.Add(this.label14);
            this.gpbInformacoes.Controls.Add(this.label13);
            this.gpbInformacoes.Controls.Add(this.label11);
            this.gpbInformacoes.Controls.Add(this.label9);
            this.gpbInformacoes.Controls.Add(this.txtValorDesconto);
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 345);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(737, 76);
            this.gpbInformacoes.TabIndex = 68;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Outras Informações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Espécie";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(413, 19);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 73;
            // 
            // txtNumeracao
            // 
            this.txtNumeracao.Location = new System.Drawing.Point(342, 45);
            this.txtNumeracao.Name = "txtNumeracao";
            this.txtNumeracao.Size = new System.Drawing.Size(100, 20);
            this.txtNumeracao.TabIndex = 72;
            // 
            // txtValorSeguro
            // 
            this.txtValorSeguro.Location = new System.Drawing.Point(87, 19);
            this.txtValorSeguro.Name = "txtValorSeguro";
            this.txtValorSeguro.Size = new System.Drawing.Size(100, 20);
            this.txtValorSeguro.TabIndex = 71;
            // 
            // txtQtdEmbalagens
            // 
            this.txtQtdEmbalagens.Location = new System.Drawing.Point(165, 45);
            this.txtQtdEmbalagens.Name = "txtQtdEmbalagens";
            this.txtQtdEmbalagens.Size = new System.Drawing.Size(100, 20);
            this.txtQtdEmbalagens.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Quantidade de Embalagens";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "Numeração";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Desconto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Valor Seguro";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(255, 19);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtValorDesconto.TabIndex = 65;
            // 
            // btnEmitirNotaFiscal
            // 
            this.btnEmitirNotaFiscal.Location = new System.Drawing.Point(674, 427);
            this.btnEmitirNotaFiscal.Name = "btnEmitirNotaFiscal";
            this.btnEmitirNotaFiscal.Size = new System.Drawing.Size(75, 23);
            this.btnEmitirNotaFiscal.TabIndex = 69;
            this.btnEmitirNotaFiscal.Text = "Emitir NF-e";
            this.btnEmitirNotaFiscal.UseVisualStyleBackColor = true;
            this.btnEmitirNotaFiscal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExibirPedido
            // 
            this.btnExibirPedido.Location = new System.Drawing.Point(438, 427);
            this.btnExibirPedido.Name = "btnExibirPedido";
            this.btnExibirPedido.Size = new System.Drawing.Size(122, 23);
            this.btnExibirPedido.TabIndex = 70;
            this.btnExibirPedido.Text = "Exibir Pedido da NF-e";
            this.btnExibirPedido.UseVisualStyleBackColor = true;
            this.btnExibirPedido.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVisualizarNotaFiscal
            // 
            this.btnVisualizarNotaFiscal.Location = new System.Drawing.Point(566, 427);
            this.btnVisualizarNotaFiscal.Name = "btnVisualizarNotaFiscal";
            this.btnVisualizarNotaFiscal.Size = new System.Drawing.Size(102, 23);
            this.btnVisualizarNotaFiscal.TabIndex = 71;
            this.btnVisualizarNotaFiscal.Text = "Visualizar NF-e";
            this.btnVisualizarNotaFiscal.UseVisualStyleBackColor = true;
            this.btnVisualizarNotaFiscal.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.Controls.Add(this.btnVisualizarNotaFiscal);
            this.Controls.Add(this.btnExibirPedido);
            this.Controls.Add(this.btnEmitirNotaFiscal);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.gpbTransportador);
            this.Controls.Add(this.gpbNotaFiscal);
            this.Controls.Add(this.gpbPedido);
            this.Controls.Add(this.gpbItensNotaFiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotaFiscal";
            this.ShowIcon = false;
            this.Text = "MultiCarbono - Vendas - Nota Fiscal";
            this.Load += new System.EventHandler(this.frNotaFiscal_Load);
            this.gpbItensNotaFiscal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensNota)).EndInit();
            this.gpbPedido.ResumeLayout(false);
            this.gpbPedido.PerformLayout();
            this.gpbNotaFiscal.ResumeLayout(false);
            this.gpbNotaFiscal.PerformLayout();
            this.gpbTransportador.ResumeLayout(false);
            this.gpbTransportador.PerformLayout();
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbItensNotaFiscal;
        private System.Windows.Forms.DataGridView dgvItensNota;
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
        private System.Windows.Forms.GroupBox gpbPedido;
        private System.Windows.Forms.CheckBox ckbFaturado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChaveAcesso;
        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEmissaoNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbNotaFiscal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.TextBox txtCnpjTransportador;
        private System.Windows.Forms.GroupBox gpbTransportador;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtValorFrete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTipoFrete;
        private System.Windows.Forms.TextBox txtPlacaVeiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtNumeracao;
        private System.Windows.Forms.TextBox txtValorSeguro;
        private System.Windows.Forms.TextBox txtQtdEmbalagens;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.Button btnEmitirNotaFiscal;
        private System.Windows.Forms.Button btnExibirPedido;
        private System.Windows.Forms.Button btnVisualizarNotaFiscal;
    }
}