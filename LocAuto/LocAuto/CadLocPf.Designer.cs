namespace LocAuto
{
    partial class CadLocPf
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpDtValidade = new System.Windows.Forms.DateTimePicker();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCnh = new System.Windows.Forms.TextBox();
            this.CbxNome = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opcional = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ChkPago = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CbxFormaPagto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.TxtValorOpc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtValorDiaria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DtpDtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.DtpDtLocacao = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CbxVeiculo = new System.Windows.Forms.ComboBox();
            this.CbxPlaca = new System.Windows.Forms.ComboBox();
            this.CbxGrupo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.btnVistoria = new System.Windows.Forms.Button();
            this.TxtValorCaucao = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpDtValidade);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtCnh);
            this.groupBox1.Controls.Add(this.CbxNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(39, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(740, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cliente";
            // 
            // DtpDtValidade
            // 
            this.DtpDtValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDtValidade.Location = new System.Drawing.Point(363, 68);
            this.DtpDtValidade.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDtValidade.Name = "DtpDtValidade";
            this.DtpDtValidade.Size = new System.Drawing.Size(132, 22);
            this.DtpDtValidade.TabIndex = 3;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(613, 28);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(91, 22);
            this.TxtCodigo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "E-mail";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(363, 105);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(219, 22);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(89, 105);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(171, 22);
            this.TxtNumero.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Celular";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Validade";
            // 
            // TxtCnh
            // 
            this.TxtCnh.Location = new System.Drawing.Point(89, 68);
            this.TxtCnh.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCnh.Name = "TxtCnh";
            this.TxtCnh.Size = new System.Drawing.Size(171, 22);
            this.TxtCnh.TabIndex = 2;
            // 
            // CbxNome
            // 
            this.CbxNome.FormattingEnabled = true;
            this.CbxNome.Items.AddRange(new object[] {
            "-"});
            this.CbxNome.Location = new System.Drawing.Point(89, 31);
            this.CbxNome.Margin = new System.Windows.Forms.Padding(4);
            this.CbxNome.Name = "CbxNome";
            this.CbxNome.Size = new System.Drawing.Size(405, 24);
            this.CbxNome.TabIndex = 1;
            this.CbxNome.SelectedIndexChanged += new System.EventHandler(this.CbxNome_SelectedIndexChanged);
            this.CbxNome.Validated += new System.EventHandler(this.CbxNome_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "CNH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtValorCaucao);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.ChkPago);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.CbxFormaPagto);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TxtValorTotal);
            this.groupBox2.Controls.Add(this.TxtValorOpc);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxtValorDiaria);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.DtpDtDevolucao);
            this.groupBox2.Controls.Add(this.DtpDtLocacao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CbxVeiculo);
            this.groupBox2.Controls.Add(this.CbxPlaca);
            this.groupBox2.Controls.Add(this.CbxGrupo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(39, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(740, 346);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Locação";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(496, 79);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Opcionais";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(363, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 180);
            this.panel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opcional});
            this.dataGridView1.Location = new System.Drawing.Point(5, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(359, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // opcional
            // 
            this.opcional.HeaderText = "Opcional";
            this.opcional.Name = "opcional";
            this.opcional.Width = 200;
            // 
            // ChkPago
            // 
            this.ChkPago.AutoSize = true;
            this.ChkPago.Location = new System.Drawing.Point(556, 288);
            this.ChkPago.Margin = new System.Windows.Forms.Padding(4);
            this.ChkPago.Name = "ChkPago";
            this.ChkPago.Size = new System.Drawing.Size(63, 21);
            this.ChkPago.TabIndex = 9;
            this.ChkPago.Text = "Pago";
            this.ChkPago.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(303, 289);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Valor Caução";
            // 
            // CbxFormaPagto
            // 
            this.CbxFormaPagto.FormattingEnabled = true;
            this.CbxFormaPagto.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Faturado"});
            this.CbxFormaPagto.Location = new System.Drawing.Point(108, 286);
            this.CbxFormaPagto.Margin = new System.Windows.Forms.Padding(4);
            this.CbxFormaPagto.Name = "CbxFormaPagto";
            this.CbxFormaPagto.Size = new System.Drawing.Size(141, 24);
            this.CbxFormaPagto.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 289);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Forma Pgto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 254);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Valor Total";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Location = new System.Drawing.Point(145, 250);
            this.TxtValorTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(104, 22);
            this.TxtValorTotal.TabIndex = 13;
            this.TxtValorTotal.Text = "0";
            this.TxtValorTotal.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // TxtValorOpc
            // 
            this.TxtValorOpc.Enabled = false;
            this.TxtValorOpc.Location = new System.Drawing.Point(145, 218);
            this.TxtValorOpc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorOpc.Name = "TxtValorOpc";
            this.TxtValorOpc.Size = new System.Drawing.Size(104, 22);
            this.TxtValorOpc.TabIndex = 12;
            this.TxtValorOpc.Text = "0";
            this.TxtValorOpc.TextChanged += new System.EventHandler(this.TxtValorOpc_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Valor Total Opc.";
            // 
            // TxtValorDiaria
            // 
            this.TxtValorDiaria.Enabled = false;
            this.TxtValorDiaria.Location = new System.Drawing.Point(145, 186);
            this.TxtValorDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorDiaria.Name = "TxtValorDiaria";
            this.TxtValorDiaria.Size = new System.Drawing.Size(104, 22);
            this.TxtValorDiaria.TabIndex = 10;
            this.TxtValorDiaria.Text = "0";
            this.TxtValorDiaria.TextChanged += new System.EventHandler(this.TxtValorDiaria_TextChanged);
            this.TxtValorDiaria.Validated += new System.EventHandler(this.TxtValorDiaria_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 192);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Valor Diárias";
            // 
            // DtpDtDevolucao
            // 
            this.DtpDtDevolucao.CustomFormat = "";
            this.DtpDtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDtDevolucao.Location = new System.Drawing.Point(89, 143);
            this.DtpDtDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDtDevolucao.Name = "DtpDtDevolucao";
            this.DtpDtDevolucao.Size = new System.Drawing.Size(160, 22);
            this.DtpDtDevolucao.TabIndex = 6;
            this.DtpDtDevolucao.Validated += new System.EventHandler(this.DtpDtDevolucao_Validated);
            // 
            // DtpDtLocacao
            // 
            this.DtpDtLocacao.CustomFormat = "";
            this.DtpDtLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDtLocacao.Location = new System.Drawing.Point(89, 106);
            this.DtpDtLocacao.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDtLocacao.Name = "DtpDtLocacao";
            this.DtpDtLocacao.Size = new System.Drawing.Size(160, 22);
            this.DtpDtLocacao.TabIndex = 5;
            this.DtpDtLocacao.Value = new System.DateTime(2016, 11, 5, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dt. Dev.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Dt. Loc.";
            // 
            // CbxVeiculo
            // 
            this.CbxVeiculo.FormattingEnabled = true;
            this.CbxVeiculo.Location = new System.Drawing.Point(363, 33);
            this.CbxVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.CbxVeiculo.Name = "CbxVeiculo";
            this.CbxVeiculo.Size = new System.Drawing.Size(365, 24);
            this.CbxVeiculo.TabIndex = 3;
            this.CbxVeiculo.Validated += new System.EventHandler(this.CbxVeiculo_Validated);
            // 
            // CbxPlaca
            // 
            this.CbxPlaca.FormattingEnabled = true;
            this.CbxPlaca.Location = new System.Drawing.Point(89, 69);
            this.CbxPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.CbxPlaca.Name = "CbxPlaca";
            this.CbxPlaca.Size = new System.Drawing.Size(160, 24);
            this.CbxPlaca.TabIndex = 4;
            // 
            // CbxGrupo
            // 
            this.CbxGrupo.FormattingEnabled = true;
            this.CbxGrupo.Location = new System.Drawing.Point(89, 33);
            this.CbxGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.CbxGrupo.Name = "CbxGrupo";
            this.CbxGrupo.Size = new System.Drawing.Size(160, 24);
            this.CbxGrupo.TabIndex = 2;
            this.CbxGrupo.SelectedIndexChanged += new System.EventHandler(this.CbxGrupo_SelectedIndexChanged);
            this.CbxGrupo.Validated += new System.EventHandler(this.CbxGrupo_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Veículo";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(679, 578);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 28);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(571, 578);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 28);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVistoria
            // 
            this.btnVistoria.Location = new System.Drawing.Point(39, 578);
            this.btnVistoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnVistoria.Name = "btnVistoria";
            this.btnVistoria.Size = new System.Drawing.Size(100, 28);
            this.btnVistoria.TabIndex = 11;
            this.btnVistoria.Text = "Vistoria";
            this.btnVistoria.UseVisualStyleBackColor = true;
            this.btnVistoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtValorCaucao
            // 
            this.TxtValorCaucao.Location = new System.Drawing.Point(403, 289);
            this.TxtValorCaucao.Name = "TxtValorCaucao";
            this.TxtValorCaucao.Size = new System.Drawing.Size(125, 22);
            this.TxtValorCaucao.TabIndex = 22;
            this.TxtValorCaucao.Validated += new System.EventHandler(this.TxtValorCaucao_Validated);
            // 
            // CadLocPf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 622);
            this.Controls.Add(this.btnVistoria);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadLocPf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Locação Pessoa Física";
            this.Load += new System.EventHandler(this.CadLocPf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCnh;
        private System.Windows.Forms.ComboBox CbxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.TextBox TxtValorOpc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtValorDiaria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DtpDtDevolucao;
        private System.Windows.Forms.DateTimePicker DtpDtLocacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbxVeiculo;
        private System.Windows.Forms.ComboBox CbxPlaca;
        private System.Windows.Forms.ComboBox CbxGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkPago;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CbxFormaPagto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DtpDtValidade;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button btnVistoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn opcional;
        private System.Windows.Forms.TextBox TxtValorCaucao;
    }
}