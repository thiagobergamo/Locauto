﻿using DaoMysql;
using Modelo;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaoInterface;

namespace LocAuto
{
    public partial class CadUsuario : Form
    {
        public Usuario usuarioConsulta { get; set; }
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }

        private void LimparTxt()
        {
            TxtNome.Text = "";
            TxtEmail.Text = "";
            TxtUsuario.Text = "";
            TxtSenha.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            UsuarioService usuarioService = new UsuarioService(usuarioDAO);
            if (!String.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                usuario.Codigo = Convert.ToInt32(TxtCodigo.Text);
            }
            usuario.Nome = TxtNome.Text;
            usuario.Email = TxtEmail.Text;
            usuario.Login = TxtUsuario.Text;
            usuario.Senha = TxtSenha.Text;
            
            try
            {
                if (usuario.Codigo == 0)
                {
                    usuarioService.inserir(usuario);
                }
                else
                {
                    usuarioService.atualizar(usuario);
                }
                MessageBox.Show("Cadastro salvo com sucesso!");
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Mensagem");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            if (usuarioConsulta != null)
            {
                TxtCodigo.Text = usuarioConsulta.Codigo.ToString();
                TxtNome.Text = usuarioConsulta.Nome;
                TxtEmail.Text = usuarioConsulta.Email;
                TxtUsuario.Text = usuarioConsulta.Login;
                TxtSenha.Text = usuarioConsulta.Senha;


            }
        }
    }
}
