using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class TipoVeiculoService
    {
        private ITipoVeiculoDAO tipoVeiculoDao;
        public TipoVeiculoService() { }
        public TipoVeiculoService(ITipoVeiculoDAO tipoVeiculoDao)
        {
            this.tipoVeiculoDao = tipoVeiculoDao;
        }
        public void inserir(TipoVeiculo tipoVeiculo)
        {
            ValidarTipoVeiculo(tipoVeiculo);
            tipoVeiculoDao.inserir(tipoVeiculo);
        }
        private void ValidarTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            if (String.IsNullOrEmpty(tipoVeiculo.Descricao))
            {
                throw new ArgumentNullException("Descrição", "Campo obrigatório não preenchido");
            }
            if (tipoVeiculo.ValorDiaria == 0)
            {
                throw new ArgumentNullException("Valor Diária", "Campo obrigatório não preenchido");
            }
        }
    }
}
