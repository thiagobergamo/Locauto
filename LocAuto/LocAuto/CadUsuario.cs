using DaoMysql;
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
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtEmail.Text = "";
            TxtUsuario.Text = "";
            TxtSenha.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //String msg;
            Usuario usuario = new Usuario();
            usuario.Nome = TxtNome.Text;
            usuario.Email = TxtEmail.Text;
            usuario.Login = TxtUsuario.Text;
            usuario.Senha = TxtSenha.Text;

            if (!String.IsNullOrWhiteSpace(TxtNome.Text))
            {
                usuario.Nome = TxtNome.Text;
            }
            if (!String.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                usuario.Login = TxtUsuario.Text;
            }
            if (!String.IsNullOrWhiteSpace(TxtSenha.Text))
            {
                usuario.Senha = TxtSenha.Text;
            }
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            UsuarioService usuarioService = new UsuarioService(usuarioDAO);
            try
            {
                usuarioService.inserir(usuario);
                MessageBox.Show("Cadastro realizado com sucesso!");
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
    }
}
