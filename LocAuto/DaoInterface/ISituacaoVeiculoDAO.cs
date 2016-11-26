using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface ISituacaoVeiculoDAO
    {
        void inserir(SituacaoVeiculo situacaoVeiculo);
        void atualizar(SituacaoVeiculo situacaoVeiculo);
        void apagar(int id);
        SituacaoVeiculo buscaPorId(int id);
        List<SituacaoVeiculo> buscaTodos();
    }
}
