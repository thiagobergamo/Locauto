using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class UsuarioService
    {
        private IUsuarioDAO usuarioDAO;
        public UsuarioService() { }
        public UsuarioService(IUsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }
        public void inserir(Usuario usuario)
        {
            ValidarUsuario(usuario);
            usuario.inserir(usuario);
        }

        private void ValidarUsuario(UsuarioService usuario)
        {
            if (String.IsNullOrWhiteSpace(usuario.Nome))
            {
                throw new ArgumentNullException("Nome", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(usuario.Email))
            {
                throw new ArgumentNullException("Email", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(usuario.Login))
            {
                throw new ArgumentNullException("Login", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(usuario.Senha))
            {
                throw new ArgumentNullException("Senha", "Campo obrigatório não preenchido");
            }

        }
    }
}

