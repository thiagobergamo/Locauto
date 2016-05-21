using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String msg;
            Usuario usuario = new Usuario();
            usuario.Nome = TxtNome.Text;
            usuario.Email = TxtEmail.Text;
            usuario.Login = TxtUsuario.Text;
            usuario.Senha = TxtSenha.Text;

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            msg = usuarioDAO.inserir(usuario);
            TxtNome.Text = "";
            TxtEmail.Text = "";
            TxtUsuario.Text = "";
            TxtSenha.Text = "";
            MessageBox.Show(msg);
        }
    }
}
