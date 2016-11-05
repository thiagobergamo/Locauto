namespace LocAuto
{
    partial class ConsultaLocacao
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
            this.DgvConsultaPj = new System.Windows.Forms.DataGridView();
            this.Id_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDevolucao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaPj)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultaPj
            // 
            this.DgvConsultaPj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultaPj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_loc,
            this.Nome,
            this.data_loc,
            this.data_prev,
            this.Veiculo,
            this.Valor_Total});
            this.DgvConsultaPj.Location = new System.Drawing.Point(31, 26);
            this.DgvConsultaPj.Name = "DgvConsultaPj";
            this.DgvConsultaPj.Size = new System.Drawing.Size(789, 335);
            this.DgvConsultaPj.TabIndex = 0;
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
            this.data_prev.HeaderText = "Data Prev Devolução";
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
            this.BtnDevolucao.Location = new System.Drawing.Point(714, 385);
            this.BtnDevolucao.Name = "BtnDevolucao";
            this.BtnDevolucao.Size = new System.Drawing.Size(106, 30);
            this.BtnDevolucao.TabIndex = 2;
            this.BtnDevolucao.Text = "Devolução";
            this.BtnDevolucao.UseVisualStyleBackColor = true;
            this.BtnDevolucao.Click += new System.EventHandler(this.BtnDevolucao_Click);
            // 
            // ConsultaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 427);
            this.Controls.Add(this.BtnDevolucao);
            this.Controls.Add(this.DgvConsultaPj);
            this.Name = "ConsultaLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta Locação PJ";
            this.Load += new System.EventHandler(this.ConsultaLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultaPj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultaPj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.Button BtnDevolucao;
    }
}