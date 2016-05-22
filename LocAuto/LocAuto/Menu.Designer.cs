﻿namespace LocAuto
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeTelefonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaçãoDoVeículoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDoVeículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionaisLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaJurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaFisícaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaJurídicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.veículoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.geraisToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Usuário";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // geraisToolStripMenuItem
            // 
            this.geraisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeTelefonesToolStripMenuItem,
            this.situaçãoDoVeículoToolStripMenuItem2,
            this.opcionaisLocaçãoToolStripMenuItem});
            this.geraisToolStripMenuItem.Name = "geraisToolStripMenuItem";
            this.geraisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.geraisToolStripMenuItem.Text = "Gerais";
            // 
            // tipoDeTelefonesToolStripMenuItem
            // 
            this.tipoDeTelefonesToolStripMenuItem.Name = "tipoDeTelefonesToolStripMenuItem";
            this.tipoDeTelefonesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tipoDeTelefonesToolStripMenuItem.Text = "Tipo de Telefone";
            this.tipoDeTelefonesToolStripMenuItem.Click += new System.EventHandler(this.tipoDeTelefonesToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.usuáriosToolStripMenuItem.Text = "Cliente";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaFísicaToolStripMenuItem,
            this.pessoaJurídicaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // pessoaFísicaToolStripMenuItem
            // 
            this.pessoaFísicaToolStripMenuItem.Name = "pessoaFísicaToolStripMenuItem";
            this.pessoaFísicaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pessoaFísicaToolStripMenuItem.Text = "Pessoa Física";
            this.pessoaFísicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaFísicaToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaFisícaToolStripMenuItem,
            this.pessoaJurídicaToolStripMenuItem1});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // situaçãoDoVeículoToolStripMenuItem2
            // 
            this.situaçãoDoVeículoToolStripMenuItem2.Name = "situaçãoDoVeículoToolStripMenuItem2";
            this.situaçãoDoVeículoToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.situaçãoDoVeículoToolStripMenuItem2.Text = "Situação do Veículo";
            this.situaçãoDoVeículoToolStripMenuItem2.Click += new System.EventHandler(this.situaçãoDoVeículoToolStripMenuItem2_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroVeículoToolStripMenuItem,
            this.grupoDoVeículoToolStripMenuItem1});
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.veículoToolStripMenuItem.Text = "Veículo";
            // 
            // cadastroVeículoToolStripMenuItem
            // 
            this.cadastroVeículoToolStripMenuItem.Name = "cadastroVeículoToolStripMenuItem";
            this.cadastroVeículoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cadastroVeículoToolStripMenuItem.Text = "Cadastro Veículo";
            this.cadastroVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastroVeículoToolStripMenuItem_Click);
            // 
            // grupoDoVeículoToolStripMenuItem1
            // 
            this.grupoDoVeículoToolStripMenuItem1.Name = "grupoDoVeículoToolStripMenuItem1";
            this.grupoDoVeículoToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.grupoDoVeículoToolStripMenuItem1.Text = "Grupo do Veículo";
            this.grupoDoVeículoToolStripMenuItem1.Click += new System.EventHandler(this.grupoDoVeículoToolStripMenuItem1_Click);
            // 
            // opcionaisLocaçãoToolStripMenuItem
            // 
            this.opcionaisLocaçãoToolStripMenuItem.Name = "opcionaisLocaçãoToolStripMenuItem";
            this.opcionaisLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.opcionaisLocaçãoToolStripMenuItem.Text = "Opcionais Locação";
            this.opcionaisLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.opcionaisLocaçãoToolStripMenuItem_Click);
            // 
            // pessoaJurídicaToolStripMenuItem
            // 
            this.pessoaJurídicaToolStripMenuItem.Name = "pessoaJurídicaToolStripMenuItem";
            this.pessoaJurídicaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pessoaJurídicaToolStripMenuItem.Text = "Pessoa Jurídica";
            this.pessoaJurídicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaJurídicaToolStripMenuItem_Click);
            // 
            // pessoaFisícaToolStripMenuItem
            // 
            this.pessoaFisícaToolStripMenuItem.Name = "pessoaFisícaToolStripMenuItem";
            this.pessoaFisícaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pessoaFisícaToolStripMenuItem.Text = "Pessoa Física";
            this.pessoaFisícaToolStripMenuItem.Click += new System.EventHandler(this.pessoaFisícaToolStripMenuItem_Click);
            // 
            // pessoaJurídicaToolStripMenuItem1
            // 
            this.pessoaJurídicaToolStripMenuItem1.Name = "pessoaJurídicaToolStripMenuItem1";
            this.pessoaJurídicaToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.pessoaJurídicaToolStripMenuItem1.Text = "Pessoa Jurídica";
            this.pessoaJurídicaToolStripMenuItem1.Click += new System.EventHandler(this.pessoaJurídicaToolStripMenuItem1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 375);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "- Loc Auto -";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeTelefonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaçãoDoVeículoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opcionaisLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaJurídicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaFisícaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaJurídicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDoVeículoToolStripMenuItem1;
    }
}