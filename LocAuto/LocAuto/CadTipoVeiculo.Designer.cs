namespace LocAuto
{
    partial class CadTipoVeiculo
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGrupo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkPortas = new System.Windows.Forms.CheckBox();
            this.ChkVidroEletrico = new System.Windows.Forms.CheckBox();
            this.ChkTravaEletrica = new System.Windows.Forms.CheckBox();
            this.ChkAirBag = new System.Windows.Forms.CheckBox();
            this.ChkAbs = new System.Windows.Forms.CheckBox();
            this.ChkArCondicionado = new System.Windows.Forms.CheckBox();
            this.TxtValorDiaria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(69, 20);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(67, 20);
            this.TxtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtGrupo
            // 
            this.TxtGrupo.Location = new System.Drawing.Point(69, 46);
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.Size = new System.Drawing.Size(121, 20);
            this.TxtGrupo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkPortas);
            this.groupBox1.Controls.Add(this.ChkVidroEletrico);
            this.groupBox1.Controls.Add(this.ChkTravaEletrica);
            this.groupBox1.Controls.Add(this.ChkAirBag);
            this.groupBox1.Controls.Add(this.ChkAbs);
            this.groupBox1.Controls.Add(this.ChkArCondicionado);
            this.groupBox1.Location = new System.Drawing.Point(15, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcionais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ChkPortas
            // 
            this.ChkPortas.AutoSize = true;
            this.ChkPortas.Location = new System.Drawing.Point(6, 101);
            this.ChkPortas.Name = "ChkPortas";
            this.ChkPortas.Size = new System.Drawing.Size(56, 17);
            this.ChkPortas.TabIndex = 5;
            this.ChkPortas.Text = "Portas";
            this.ChkPortas.UseVisualStyleBackColor = true;
            // 
            // ChkVidroEletrico
            // 
            this.ChkVidroEletrico.AutoSize = true;
            this.ChkVidroEletrico.Location = new System.Drawing.Point(6, 147);
            this.ChkVidroEletrico.Name = "ChkVidroEletrico";
            this.ChkVidroEletrico.Size = new System.Drawing.Size(88, 17);
            this.ChkVidroEletrico.TabIndex = 5;
            this.ChkVidroEletrico.Text = "Vidro Elétrico";
            this.ChkVidroEletrico.UseVisualStyleBackColor = true;
            // 
            // ChkTravaEletrica
            // 
            this.ChkTravaEletrica.AutoSize = true;
            this.ChkTravaEletrica.Location = new System.Drawing.Point(6, 124);
            this.ChkTravaEletrica.Name = "ChkTravaEletrica";
            this.ChkTravaEletrica.Size = new System.Drawing.Size(92, 17);
            this.ChkTravaEletrica.TabIndex = 3;
            this.ChkTravaEletrica.Text = "Trava Elétrica";
            this.ChkTravaEletrica.UseVisualStyleBackColor = true;
            // 
            // ChkAirBag
            // 
            this.ChkAirBag.AutoSize = true;
            this.ChkAirBag.Location = new System.Drawing.Point(6, 52);
            this.ChkAirBag.Name = "ChkAirBag";
            this.ChkAirBag.Size = new System.Drawing.Size(60, 17);
            this.ChkAirBag.TabIndex = 2;
            this.ChkAirBag.Text = "Air Bag";
            this.ChkAirBag.UseVisualStyleBackColor = true;
            // 
            // ChkAbs
            // 
            this.ChkAbs.AutoSize = true;
            this.ChkAbs.Location = new System.Drawing.Point(6, 29);
            this.ChkAbs.Name = "ChkAbs";
            this.ChkAbs.Size = new System.Drawing.Size(47, 17);
            this.ChkAbs.TabIndex = 1;
            this.ChkAbs.Text = "ABS";
            this.ChkAbs.UseVisualStyleBackColor = true;
            // 
            // ChkArCondicionado
            // 
            this.ChkArCondicionado.AutoSize = true;
            this.ChkArCondicionado.Location = new System.Drawing.Point(6, 78);
            this.ChkArCondicionado.Name = "ChkArCondicionado";
            this.ChkArCondicionado.Size = new System.Drawing.Size(104, 17);
            this.ChkArCondicionado.TabIndex = 0;
            this.ChkArCondicionado.Text = "Ar Condicionado";
            this.ChkArCondicionado.UseVisualStyleBackColor = true;
            // 
            // TxtValorDiaria
            // 
            this.TxtValorDiaria.Location = new System.Drawing.Point(79, 284);
            this.TxtValorDiaria.Name = "TxtValorDiaria";
            this.TxtValorDiaria.Size = new System.Drawing.Size(111, 20);
            this.TxtValorDiaria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Diária";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(34, 325);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(115, 325);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CadTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 360);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtValorDiaria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Name = "CadTipoVeiculo";
            this.Text = "Cadastro Tipo Veículo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkPortas;
        private System.Windows.Forms.CheckBox ChkVidroEletrico;
        private System.Windows.Forms.CheckBox ChkTravaEletrica;
        private System.Windows.Forms.CheckBox ChkAirBag;
        private System.Windows.Forms.CheckBox ChkAbs;
        private System.Windows.Forms.CheckBox ChkArCondicionado;
        private System.Windows.Forms.TextBox TxtValorDiaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvar;
    }
}