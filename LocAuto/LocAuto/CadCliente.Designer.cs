﻿namespace LocAuto
{
    partial class CadClienteFisica
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
            this.TxtOutDocumento = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCnh = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MskDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MskCep = new System.Windows.Forms.MaskedTextBox();
            this.CEP = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MskValCnh = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtLoginWeb = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOutDocumento
            // 
            this.TxtOutDocumento.Location = new System.Drawing.Point(256, 48);
            this.TxtOutDocumento.Name = "TxtOutDocumento";
            this.TxtOutDocumento.Size = new System.Drawing.Size(288, 20);
            this.TxtOutDocumento.TabIndex = 15;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(181, 51);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(59, 13);
            this.Senha.TabIndex = 36;
            this.Senha.Text = "Outro Doc.";
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "CPF";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(56, 72);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(144, 20);
            this.TxtEmail.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 75);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 32;
            this.Email.Text = "Email";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(451, 474);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 19;
            this.BtnLimpar.TabStop = false;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(532, 474);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 18;
            this.BtnSalvar.TabStop = false;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(56, 20);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(57, 20);
            this.TxtCodigo.TabIndex = 29;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(56, 46);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(202, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "RG";
            // 
            // MskCpf
            // 
            this.MskCpf.Location = new System.Drawing.Point(56, 45);
            this.MskCpf.Mask = "999.999.999-99";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(105, 20);
            this.MskCpf.TabIndex = 14;
            this.MskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "CNH";
            // 
            // TxtCnh
            // 
            this.TxtCnh.Location = new System.Drawing.Point(256, 19);
            this.TxtCnh.Name = "TxtCnh";
            this.TxtCnh.Size = new System.Drawing.Size(105, 20);
            this.TxtCnh.TabIndex = 12;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(56, 19);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(105, 20);
            this.TxtRg.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Data Nasc.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Val. CNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskDtNascimento);
            this.groupBox1.Controls.Add(this.TxtNum);
            this.groupBox1.Controls.Add(this.TxtLog);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MskCep);
            this.groupBox1.Controls.Add(this.CEP);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtComplemento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Num);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 202);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cliente";
            // 
            // MskDtNascimento
            // 
            this.MskDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MskDtNascimento.Location = new System.Drawing.Point(347, 46);
            this.MskDtNascimento.Name = "MskDtNascimento";
            this.MskDtNascimento.Size = new System.Drawing.Size(82, 20);
            this.MskDtNascimento.TabIndex = 2;
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(347, 100);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(39, 20);
            this.TxtNum.TabIndex = 5;
            this.TxtNum.Text = "0";
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(56, 100);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(202, 20);
            this.TxtLog.TabIndex = 4;
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CmbEstado.Location = new System.Drawing.Point(347, 125);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(39, 21);
            this.CmbEstado.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Estado";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(56, 152);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(144, 20);
            this.TxtCidade.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Cidade";
            // 
            // MskCep
            // 
            this.MskCep.Location = new System.Drawing.Point(347, 152);
            this.MskCep.Mask = "99999-999";
            this.MskCep.Name = "MskCep";
            this.MskCep.Size = new System.Drawing.Size(69, 20);
            this.MskCep.TabIndex = 10;
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Location = new System.Drawing.Point(281, 155);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(28, 13);
            this.CEP.TabIndex = 55;
            this.CEP.Text = "CEP";
            this.CEP.Click += new System.EventHandler(this.CEP_Click);
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(56, 124);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(84, 20);
            this.TxtBairro.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Compl.";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(459, 103);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(84, 20);
            this.TxtComplemento.TabIndex = 7;
            this.TxtComplemento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Bairro";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(281, 103);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(29, 13);
            this.Num.TabIndex = 35;
            this.Num.Text = "Num";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "End.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MskValCnh);
            this.groupBox2.Controls.Add(this.Senha);
            this.groupBox2.Controls.Add(this.TxtOutDocumento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.MskCpf);
            this.groupBox2.Controls.Add(this.TxtRg);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtCnh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 99);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos";
            // 
            // MskValCnh
            // 
            this.MskValCnh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MskValCnh.Location = new System.Drawing.Point(460, 19);
            this.MskValCnh.Name = "MskValCnh";
            this.MskValCnh.Size = new System.Drawing.Size(84, 20);
            this.MskValCnh.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Login";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Senha";
            // 
            // TxtLoginWeb
            // 
            this.TxtLoginWeb.Location = new System.Drawing.Point(56, 26);
            this.TxtLoginWeb.Name = "TxtLoginWeb";
            this.TxtLoginWeb.Size = new System.Drawing.Size(100, 20);
            this.TxtLoginWeb.TabIndex = 16;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(56, 52);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TxtSenha);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TxtLoginWeb);
            this.groupBox3.Location = new System.Drawing.Point(26, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 93);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acesso WEB";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.numero});
            this.dataGridView1.Location = new System.Drawing.Point(326, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 101);
            this.dataGridView1.TabIndex = 54;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // CadClienteFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "CadClienteFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro Cliente PF";
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOutDocumento;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCnh;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IntNumero;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtLoginWeb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.DateTimePicker MskDtNascimento;
        private System.Windows.Forms.DateTimePicker MskValCnh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.MaskedTextBox MskCep;
    }
}