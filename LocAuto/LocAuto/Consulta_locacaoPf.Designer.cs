namespace LocAuto
{
    partial class Consulta_locacaoPf
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
            this.DgvConsultaPf = new System.Windows.Forms.DataGridView();
            this.Id_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDevolucao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaPf)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultaPf
            // 
            this.DgvConsultaPf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultaPf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_loc,
            this.Nome,
            this.data_loc,
            this.data_prev,
            this.Veiculo,
            this.Valor_Total});
            this.DgvConsultaPf.Location = new System.Drawing.Point(27, 29);
            this.DgvConsultaPf.Name = "DgvConsultaPf";
            this.DgvConsultaPf.Size = new System.Drawing.Size(792, 337);
            this.DgvConsultaPf.TabIndex = 0;
            // 
            // Id_loc
            // 
            this.Id_loc.HeaderText = "ID Locação";
            this.Id_loc.Name = "Id_loc";
            this.Id_loc.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // data_loc
            // 
            this.data_loc.HeaderText = "Data Locação";
            this.data_loc.Name = "data_loc";
            // 
            // data_prev
            // 
            this.data_prev.HeaderText = "Data Prev Dev";
            this.data_prev.Name = "data_prev";
            // 
            // Veiculo
            // 
            this.Veiculo.HeaderText = "Veículo";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.Width = 250;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.Width = 70;
            // 
            // BtnDevolucao
            // 
            this.BtnDevolucao.Location = new System.Drawing.Point(700, 381);
            this.BtnDevolucao.Name = "BtnDevolucao";
            this.BtnDevolucao.Size = new System.Drawing.Size(106, 30);
            this.BtnDevolucao.TabIndex = 1;
            this.BtnDevolucao.Text = "Devolução";
            this.BtnDevolucao.UseVisualStyleBackColor = true;
            this.BtnDevolucao.Click += new System.EventHandler(this.BtnDevolucao_Click);
            // 
            // Consulta_locacaoPf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 423);
            this.Controls.Add(this.BtnDevolucao);
            this.Controls.Add(this.DgvConsultaPf);
            this.Name = "Consulta_locacaoPf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta Locação PF";
            this.Load += new System.EventHandler(this.Consulta_locacaoPf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaPf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultaPf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.Button BtnDevolucao;
    }
}