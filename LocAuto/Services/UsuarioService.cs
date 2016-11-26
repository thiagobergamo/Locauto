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
        private IUsuarioDAO usuarioDao;
        public UsuarioService() { }
        public UsuarioService(IUsuarioDAO usuarioDao)
        {
            this.usuarioDao = usuarioDao;
        }
        public void inserir(Usuario usuario)
        {
            ValidarUsuario(usuario);
            usuarioDao.inserir(usuario);
        }
        private void ValidarUsuario(Usuario usuario)
        {
            if (String.IsNullOrWhiteSpace(usuario.Nome))
            {
                throw new ArgumentNullException("Nome", "Campo obrigatório não preenchido");
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

        public void atualizar(Usuario usuario)
        {
            ValidarUsuario(usuario);
            usuarioDao.atualizar(usuario);
        }
        public void apagar(int id)
        {
            usuarioDao.apagar(id);
        }
        public Usuario buscaPorId(int id)
        {
            return usuarioDao.buscaPorId(id);
        }
        public List<Usuario> buscaTodos()
        {
            return usuarioDao.buscaTodos();
        }
    }
}
