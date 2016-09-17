using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
     public class PessoaJuridicaService
    {
        private IPessoaJuridicaDAO pessoaJuridicaDAO;
        public PessoaJuridicaService() { }

        public PessoaJuridicaService( IPessoaJuridicaDAO pessoaJuridicaDAO)
        {
            this.pessoaJuridicaDAO = pessoaJuridicaDAO;
        }

        public void inserir(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente)
        {
            ValidarPessoaJuridica(pessoaJuridica);
            pessoaJuridicaDAO.inserir(pessoaJuridica, telefoneCliente);
        }

        private void ValidarPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            if (String.IsNullOrEmpty(pessoaJuridica.Cnpj))
            {
                throw new ArgumentNullException("CNPJ", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.RazaoSocial))
            {
                throw new ArgumentNullException("Razão Soc.", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.Logradouro))
            {
                throw new ArgumentNullException("Endereço", "Campo obrigatório não preenchido");
            }
            if (pessoaJuridica.Numero == 0 )
            {
                throw new ArgumentNullException("Numero", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.Bairro))
            {
                throw new ArgumentException("Bairro", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.Estado))
            {
                throw new ArgumentException("Estado", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.Cidade))
            {
                throw new ArgumentException("Cidade", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.Cep))
            {
                throw new ArgumentException("Cep", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.Cnh))
            {
                throw new ArgumentException("CNH", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.ValidadeCnh))
            {
                throw new ArgumentException("Val. CNH", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrEmpty(pessoaJuridica.NomeCondutor))
            {
                throw new ArgumentException("Condutor", "Campo obrigatório não preenchido");
            }

        }
    }
}
