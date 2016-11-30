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
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(108, 25);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(88, 22);
            this.TxtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtGrupo
            // 
            this.TxtGrupo.Location = new System.Drawing.Point(108, 57);
            this.TxtGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.Size = new System.Drawing.Size(160, 22);
            this.TxtGrupo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkVidroEletrico);
            this.groupBox1.Controls.Add(this.ChkTravaEletrica);
            this.groupBox1.Controls.Add(this.ChkAirBag);
            this.groupBox1.Controls.Add(this.ChkAbs);
            this.groupBox1.Controls.Add(this.ChkArCondicionado);
            this.groupBox1.Location = new System.Drawing.Point(36, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(233, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcionais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ChkVidroEletrico
            // 
            this.ChkVidroEletrico.AutoSize = true;
            this.ChkVidroEletrico.Location = new System.Drawing.Point(8, 148);
            this.ChkVidroEletrico.Margin = new System.Windows.Forms.Padding(4);
            this.ChkVidroEletrico.Name = "ChkVidroEletrico";
            this.ChkVidroEletrico.Size = new System.Drawing.Size(114, 21);
            this.ChkVidroEletrico.TabIndex = 7;
            this.ChkVidroEletrico.Text = "Vidro Elétrico";
            this.ChkVidroEletrico.UseVisualStyleBackColor = true;
            // 
            // ChkTravaEletrica
            // 
            this.ChkTravaEletrica.AutoSize = true;
            this.ChkTravaEletrica.Location = new System.Drawing.Point(8, 119);
            this.ChkTravaEletrica.Margin = new System.Windows.Forms.Padding(4);
            this.ChkTravaEletrica.Name = "ChkTravaEletrica";
            this.ChkTravaEletrica.Size = new System.Drawing.Size(118, 21);
            this.ChkTravaEletrica.TabIndex = 6;
            this.ChkTravaEletrica.Text = "Trava Elétrica";
            this.ChkTravaEletrica.UseVisualStyleBackColor = true;
            // 
            // ChkAirBag
            // 
            this.ChkAirBag.AutoSize = true;
            this.ChkAirBag.Location = new System.Drawing.Point(8, 64);
            this.ChkAirBag.Margin = new System.Windows.Forms.Padding(4);
            this.ChkAirBag.Name = "ChkAirBag";
            this.ChkAirBag.Size = new System.Drawing.Size(76, 21);
            this.ChkAirBag.TabIndex = 3;
            this.ChkAirBag.Text = "Air Bag";
            this.ChkAirBag.UseVisualStyleBackColor = true;
            // 
            // ChkAbs
            // 
            this.ChkAbs.AutoSize = true;
            this.ChkAbs.Location = new System.Drawing.Point(8, 36);
            this.ChkAbs.Margin = new System.Windows.Forms.Padding(4);
            this.ChkAbs.Name = "ChkAbs";
            this.ChkAbs.Size = new System.Drawing.Size(57, 21);
            this.ChkAbs.TabIndex = 2;
            this.ChkAbs.Text = "ABS";
            this.ChkAbs.UseVisualStyleBackColor = true;
            // 
            // ChkArCondicionado
            // 
            this.ChkArCondicionado.AutoSize = true;
            this.ChkArCondicionado.Location = new System.Drawing.Point(8, 92);
            this.ChkArCondicionado.Margin = new System.Windows.Forms.Padding(4);
            this.ChkArCondicionado.Name = "ChkArCondicionado";
            this.ChkArCondicionado.Size = new System.Drawing.Size(134, 21);
            this.ChkArCondicionado.TabIndex = 4;
            this.ChkArCondicionado.Text = "Ar Condicionado";
            this.ChkArCondicionado.UseVisualStyleBackColor = true;
            // 
            // TxtValorDiaria
            // 
            this.TxtValorDiaria.Location = new System.Drawing.Point(121, 325);
            this.TxtValorDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorDiaria.Name = "TxtValorDiaria";
            this.TxtValorDiaria.Size = new System.Drawing.Size(147, 22);
            this.TxtValorDiaria.TabIndex = 8;
            this.TxtValorDiaria.Validated += new System.EventHandler(this.TxtValorDiaria_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Diária";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(61, 370);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 28);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(169, 370);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 28);
            this.BtnSalvar.TabIndex = 9;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CadTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 420);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtValorDiaria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadTipoVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro Tipo Veículo";
            this.Load += new System.EventHandler(this.CadTipoVeiculo_Load);
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
        private System.Windows.Forms.CheckBox ChkVidroEletrico;
        private System.Windows.Forms.CheckBox ChkTravaEletrica;
        private System.Windows.Forms.CheckBox ChkAirBag;
        private System.Windows.Forms.CheckBox ChkAbs;
        private System.Windows.Forms.TextBox TxtValorDiaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.CheckBox ChkArCondicionado;
    }
}