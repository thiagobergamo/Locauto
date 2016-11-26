using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface IOpcionalDAO
    {
        void inserir(Opcional opcional);
        void atualizar(Opcional usuario);
        void apagar(int id);
        Opcional buscaPorId(int id);
        List<Opcional> buscaTodos();
    }
}
