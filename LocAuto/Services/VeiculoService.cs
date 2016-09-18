using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class VeiculoService
    {
        private IVeiculoDAO veiculoDao;
        public VeiculoService() { }
        public VeiculoService(IVeiculoDAO veiculoDao)
        {
            this.veiculoDao = veiculoDao;
        }
        public void inserir(Veiculo veiculo)
        {
            ValidarVeiculo(veiculo);
            veiculoDao.inserir(veiculo);
        }
        private void ValidarVeiculo(Veiculo veiculo)
        {
            if (String.IsNullOrWhiteSpace(veiculo.Marca))
            {
                throw new ArgumentNullException("Marca", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(veiculo.Modelo))
            {
                throw new ArgumentNullException("Modelo", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(veiculo.Cor))
            {
                throw new ArgumentNullException("Cor", "Campo obrigatório não preenchido");
            }
            if (veiculo.Ano == 0)
            {
                throw new ArgumentNullException("Ano", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(veiculo.Placa))
            {
                throw new ArgumentNullException("Placa", "Campo obrigatório não preenchido");
            }
        }
    }
}
