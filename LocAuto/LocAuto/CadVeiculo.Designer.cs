﻿namespace LocAuto
{
    partial class CadVeiculo
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtChassi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCor = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CmbSituacao = new System.Windows.Forms.ComboBox();
            this.CmbGrupo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(115, 28);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(92, 22);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(115, 95);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(444, 22);
            this.TxtMarca.TabIndex = 3;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(115, 128);
            this.TxtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(444, 22);
            this.TxtModelo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(115, 258);
            this.TxtObs.Margin = new System.Windows.Forms.Padding(4);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(444, 85);
            this.TxtObs.TabIndex = 9;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(409, 191);
            this.TxtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(149, 22);
            this.TxtPlaca.TabIndex = 7;
            // 
            // TxtChassi
            // 
            this.TxtChassi.Location = new System.Drawing.Point(115, 226);
            this.TxtChassi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtChassi.Name = "TxtChassi";
            this.TxtChassi.Size = new System.Drawing.Size(444, 22);
            this.TxtChassi.TabIndex = 8;
            this.TxtChassi.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Placa";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chassi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Obs";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtCor
            // 
            this.TxtCor.Location = new System.Drawing.Point(115, 162);
            this.TxtCor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCor.Name = "TxtCor";
            this.TxtCor.Size = new System.Drawing.Size(219, 22);
            this.TxtCor.TabIndex = 5;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(352, 370);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 28);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(460, 370);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 28);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CmbSituacao
            // 
            this.CmbSituacao.FormattingEnabled = true;
            this.CmbSituacao.Location = new System.Drawing.Point(409, 60);
            this.CmbSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.CmbSituacao.Name = "CmbSituacao";
            this.CmbSituacao.Size = new System.Drawing.Size(149, 24);
            this.CmbSituacao.TabIndex = 2;
            // 
            // CmbGrupo
            // 
            this.CmbGrupo.FormattingEnabled = true;
            this.CmbGrupo.Location = new System.Drawing.Point(115, 60);
            this.CmbGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGrupo.Name = "CmbGrupo";
            this.CmbGrupo.Size = new System.Drawing.Size(219, 24);
            this.CmbGrupo.TabIndex = 1;
            this.CmbGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Situação";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Grupo";
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(115, 194);
            this.TxtAno.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(219, 22);
            this.TxtAno.TabIndex = 6;
            this.TxtAno.Validated += new System.EventHandler(this.TxtAno_Validated);
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbGrupo);
            this.Controls.Add(this.CmbSituacao);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtCor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtChassi);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Veículo";
            this.Load += new System.EventHandler(this.CadVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtChassi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCor;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox CmbSituacao;
        private System.Windows.Forms.ComboBox CmbGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtAno;
    }
}