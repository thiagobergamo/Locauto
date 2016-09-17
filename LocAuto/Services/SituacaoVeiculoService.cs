using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class SituacaoVeiculoService
    {
        private ISituacaoVeiculoDAO situacaoVeiculoDao;
        public SituacaoVeiculoService() { }
        public SituacaoVeiculoService(ISituacaoVeiculoDAO situacaoVeiculoDao)
        {
            this.situacaoVeiculoDao = situacaoVeiculoDao;
        }
        public void inserir(SituacaoVeiculo situacaoVeiculo)
        {
            ValidarSituacaoVeiculo(situacaoVeiculo);
            situacaoVeiculoDao.inserir(situacaoVeiculo);
        }
        private void ValidarSituacaoVeiculo(SituacaoVeiculo situacaoVeiculo)
        {
            if (String.IsNullOrWhiteSpace(situacaoVeiculo.Descricao))
            {
                throw new ArgumentNullException("Descrição", "Campo obrigatório não preenchido");
            }
        }
    }
}
