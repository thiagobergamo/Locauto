using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface ITipoVeiculoDAO
    {
        void inserir(TipoVeiculo tipoVeiculo);
        void atualizar(TipoVeiculo tipoVeiculo);
        void apagar(int id);
        TipoVeiculo buscaPorId(int id);
        List<TipoVeiculo> buscaTodos();
    }
}
