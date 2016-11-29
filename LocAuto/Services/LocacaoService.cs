using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class LocacaoService
    {
        private ILocacaoDAO locacaoDao;
        public LocacaoService() { }
        public LocacaoService(ILocacaoDAO locacaoDao)
        {
            this.locacaoDao = locacaoDao;
        }
        public long inserir(Locacao locacao)
        {
            ValidarLocacao(locacao);
            return locacaoDao.Inserir(locacao);
        }
        private void ValidarLocacao(Locacao locacao)
        {
            
            if (locacao.CodigoVeiculo == 0)
            {
                throw new ArgumentNullException("Veículo", "Dados do veículo incompletos");
            }
            if (String.IsNullOrEmpty(locacao.DataLocacao))
            {
                throw new ArgumentNullException("Data Locação", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(locacao.DataPrevDevolucao))
            {
                throw new ArgumentNullException("Data Prev. Devolução", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(locacao.FormaPagamento))
            {
                throw new ArgumentNullException("Forma Pagamento", "Campo obrigatório não preenchido");
            }
            if (locacao.ValorTotal == 0)
            {
                throw new ArgumentNullException("Data Locação", "Campo obrigatório não preenchido");
            }
        }
    }
}
