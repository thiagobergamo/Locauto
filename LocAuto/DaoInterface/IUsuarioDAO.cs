using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface IUsuarioDAO
    {
        void inserir(Usuario usuario);
        void atualizar(Usuario usuario);
        void apagar(int id);
        Usuario buscaPorId(int id);
        List<Usuario> buscaTodos();
    }
}
