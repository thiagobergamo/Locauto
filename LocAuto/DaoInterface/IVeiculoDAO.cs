using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface IVeiculoDAO
    {
        void inserir(Veiculo veiculo);
        void atualizar(Veiculo veiculo);
        void apagar(int id);
        Veiculo buscaPorId(int id);
        List<Veiculo> buscaTodos();
    }
}
