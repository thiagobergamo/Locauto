using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface ITipoTelefoneDAO
    {
        void inserir(TipoTelefone tipoTelefone);
        void atualizar(TipoTelefone tipoTelefone);
        void apagar(int id);
        TipoTelefone buscaPorId(int id);
        List<TipoTelefone> buscaTodos();
    }
}
