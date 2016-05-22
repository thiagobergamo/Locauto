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
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtCodigoUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigoLocacao
            // 
            this.TxtCodigoLocacao.Enabled = false;
            this.TxtCodigoLocacao.Location = new System.Drawing.Point(101, 20);
            this.TxtCodigoLocacao.Name = "TxtCodigoLocacao";
            this.TxtCodigoLocacao.Size = new System.Drawing.Size(79, 20);
            this.TxtCodigoLocacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cód. Locação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vistoriador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Km";
            // 
            // TxtKmLoc
            // 
            this.TxtKmLoc.Location = new System.Drawing.Point(112, 30);
            this.TxtKmLoc.Name = "TxtKmLoc";
            this.TxtKmLoc.Size = new System.Drawing.Size(99, 20);
            this.TxtKmLoc.TabIndex = 7;
            // 
            // TxtKmDev
            // 
            this.TxtKmDev.Location = new System.Drawing.Point(111, 30);
            this.TxtKmDev.Name = "TxtKmDev";
            this.TxtKmDev.Size = new System.Drawing.Size(100, 20);
            this.TxtKmDev.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Km";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nivel Combustível";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nivel Combustível";
            // 
            // TxtNivelCombLoc
            // 
            this.TxtNivelCombLoc.Location = new System.Drawing.Point(112, 62);
            this.TxtNivelCombLoc.Name = "TxtNivelCombLoc";
            this.TxtNivelCombLoc.Size = new System.Drawing.Size(99, 20);
            this.TxtNivelCombLoc.TabIndex = 12;
            // 
            // TxtNivelCombDev
            // 
            this.TxtNivelCombDev.Location = new System.Drawing.Point(111, 62);
            this.TxtNivelCombDev.Name = "TxtNivelCombDev";
            this.TxtNivelCombDev.Size = new System.Drawing.Size(100, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 185);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locação";
            // 
            // TxtLaudoLoc
            // 
            this.TxtLaudoLoc.Location = new System.Drawing.Point(55, 101);
            this.TxtLaudoLoc.Multiline = true;
            this.TxtLaudoLoc.Name = "TxtLaudoLoc";
            this.TxtLaudoLoc.Size = new System.Drawing.Size(202, 72);
            this.TxtLaudoLoc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(318, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 185);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devolução";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Laudo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtLaudoDev
            // 
            this.TxtLaudoDev.Location = new System.Drawing.Point(67, 101);
            this.TxtLaudoDev.Multiline = true;
            this.TxtLaudoDev.Name = "TxtLaudoDev";
            this.TxtLaudoDev.Size = new System.Drawing.Size(196, 72);
            this.TxtLaudoDev.TabIndex = 14;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(526, 280);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(445, 280);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 17;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtCodigoUsuario
            // 
            this.TxtCodigoUsuario.FormattingEnabled = true;
            this.TxtCodigoUsuario.Location = new System.Drawing.Point(101, 48);
            this.TxtCodigoUsuario.Name = "TxtCodigoUsuario";
            this.TxtCodigoUsuario.Size = new System.Drawing.Size(121, 21);
            this.TxtCodigoUsuario.TabIndex = 18;
            // 
            // CadVistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 318);
            this.Controls.Add(this.TxtCodigoUsuario);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoLocacao);
            this.Name = "CadVistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.ComboBox TxtCodigoUsuario;
    }
}