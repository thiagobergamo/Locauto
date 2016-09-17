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
        if (String.IsNullOrEmpty(usuario.))
            {
                throw new ArgumentNullException("CNPJ", "Campo obrigatório não preenchido");
    }
    //IsNullOrWhiteSpace
}
}
