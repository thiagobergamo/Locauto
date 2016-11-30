namespace LocAuto
{
    partial class CadVistoria
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
            this.TxtCodigoLocacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKmLoc = new System.Windows.Forms.TextBox();
            this.TxtKmDev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNivelCombLoc = new System.Windows.Forms.TextBox();
            this.TxtNivelCombDev = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtLaudoLoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLaudoDev = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtCodigoUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigoLocacao
            // 
            this.TxtCodigoLocacao.Enabled = false;
            this.TxtCodigoLocacao.Location = new System.Drawing.Point(135, 25);
            this.TxtCodigoLocacao.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoLocacao.Name = "TxtCodigoLocacao";
            this.TxtCodigoLocacao.Size = new System.Drawing.Size(104, 22);
            this.TxtCodigoLocacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cód. Locação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vistoriador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Km";
            // 
            // TxtKmLoc
            // 
            this.TxtKmLoc.Location = new System.Drawing.Point(149, 37);
            this.TxtKmLoc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKmLoc.Name = "TxtKmLoc";
            this.TxtKmLoc.Size = new System.Drawing.Size(131, 22);
            this.TxtKmLoc.TabIndex = 7;
            this.TxtKmLoc.Validated += new System.EventHandler(this.TxtKmLoc_Validated);
            // 
            // TxtKmDev
            // 
            this.TxtKmDev.Location = new System.Drawing.Point(148, 37);
            this.TxtKmDev.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKmDev.Name = "TxtKmDev";
            this.TxtKmDev.Size = new System.Drawing.Size(132, 22);
            this.TxtKmDev.TabIndex = 8;
            this.TxtKmDev.Validated += new System.EventHandler(this.TxtKmDev_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Km";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nivel Combustível";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nivel Combustível";
            // 
            // TxtNivelCombLoc
            // 
            this.TxtNivelCombLoc.Location = new System.Drawing.Point(149, 76);
            this.TxtNivelCombLoc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNivelCombLoc.Name = "TxtNivelCombLoc";
            this.TxtNivelCombLoc.Size = new System.Drawing.Size(131, 22);
            this.TxtNivelCombLoc.TabIndex = 12;
            // 
            // TxtNivelCombDev
            // 
            this.TxtNivelCombDev.Location = new System.Drawing.Point(148, 76);
            this.TxtNivelCombDev.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNivelCombDev.Name = "TxtNivelCombDev";
            this.TxtNivelCombDev.Size = new System.Drawing.Size(132, 22);
            this.TxtNivelCombDev.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtLaudoLoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtKmLoc);
            this.groupBox1.Controls.Add(this.TxtNivelCombLoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(32, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locação";
            // 
            // TxtLaudoLoc
            // 
            this.TxtLaudoLoc.Location = new System.Drawing.Point(73, 124);
            this.TxtLaudoLoc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLaudoLoc.Multiline = true;
            this.TxtLaudoLoc.Name = "TxtLaudoLoc";
            this.TxtLaudoLoc.Size = new System.Drawing.Size(268, 88);
            this.TxtLaudoLoc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Laudo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtLaudoDev);
            this.groupBox2.Controls.Add(this.TxtKmDev);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtNivelCombDev);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(424, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(377, 228);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devolução";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Laudo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtLaudoDev
            // 
            this.TxtLaudoDev.Location = new System.Drawing.Point(89, 124);
            this.TxtLaudoDev.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLaudoDev.Multiline = true;
            this.TxtLaudoDev.Name = "TxtLaudoDev";
            this.TxtLaudoDev.Size = new System.Drawing.Size(260, 88);
            this.TxtLaudoDev.TabIndex = 14;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(701, 345);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 28);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtCodigoUsuario
            // 
            this.TxtCodigoUsuario.FormattingEnabled = true;
            this.TxtCodigoUsuario.Location = new System.Drawing.Point(135, 59);
            this.TxtCodigoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoUsuario.Name = "TxtCodigoUsuario";
            this.TxtCodigoUsuario.Size = new System.Drawing.Size(160, 24);
            this.TxtCodigoUsuario.TabIndex = 18;
            // 
            // CadVistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 391);
            this.Controls.Add(this.TxtCodigoUsuario);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoLocacao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadVistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vistoria";
            this.Load += new System.EventHandler(this.CadVistoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCodigoLocacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKmLoc;
        private System.Windows.Forms.TextBox TxtKmDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNivelCombLoc;
        private System.Windows.Forms.TextBox TxtNivelCombDev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtLaudoLoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLaudoDev;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox TxtCodigoUsuario;
    }
}