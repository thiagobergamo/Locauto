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
            if (String.IsNullOrEmpty(veiculo.Marca))
            {
                throw new ArgumentNullException("Marca", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(veiculo.Modelo))
            {
                throw new ArgumentNullException("Modelo", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(veiculo.Cor))
            {
                throw new ArgumentNullException("Cor", "Campo obrigatório não preenchido");
            }
            if (veiculo.Ano == null)
            {
                throw new ArgumentNullException("Ano", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(veiculo.Placa))
            {
                throw new ArgumentNullException("Placa", "Campo obrigatório não preenchido");
            }
        }
    }
}
