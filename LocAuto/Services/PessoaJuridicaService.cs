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
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Cnpj))
            {
                throw new ArgumentNullException("CNPJ", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.RazaoSocial))
            {
                throw new ArgumentNullException("Razão Soc.", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Logradouro))
            {
                throw new ArgumentNullException("Endereço", "Campo obrigatório não preenchido");
            }
            if (pessoaJuridica.Numero == 0 )
            {
                throw new ArgumentNullException("Numero", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Bairro))
            {
                throw new ArgumentException("Bairro", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Estado))
            {
                throw new ArgumentException("Estado", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Cidade))
            {
                throw new ArgumentException("Cidade", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Cep))
            {
                throw new ArgumentException("Cep", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.Cnh))
            {
                throw new ArgumentException("CNH", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.ValidadeCnh))
            {
                throw new ArgumentException("Val. CNH", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaJuridica.NomeCondutor))
            {
                throw new ArgumentException("Condutor", "Campo obrigatório não preenchido");
            }

        }
        public List<PessoaJuridica> buscarTodos()
        {
            return pessoaJuridicaDAO.buscarTodos();
        }
        public PessoaJuridica BuscarPorId(int id)
        {
            return pessoaJuridicaDAO.BuscarPorId(id);
        }
        public void apagar(int id)
        {
            pessoaJuridicaDAO.apagar(id);
        }
        public List<PessoaJuridica> buscaPorNomeOuCnpj(String nome, String cnpj)
        {
            return pessoaJuridicaDAO.buscaPorNomeOuCnpj(nome, cnpj);
        }

        public void atualizar(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente)
        {
            pessoaJuridicaDAO.atualizar(pessoaJuridica, telefoneCliente);
        }
    }
}
