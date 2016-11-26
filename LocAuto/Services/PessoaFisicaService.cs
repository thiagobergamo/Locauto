using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace Services
{
    public class PessoaFisicaService
    {
        private IPessoaFisicaDAO pessoaFisicaDao;
        public PessoaFisicaService() { }
        public PessoaFisicaService(IPessoaFisicaDAO pessoaFisicaDao)
        {
            this.pessoaFisicaDao = pessoaFisicaDao;
        }
        public void inserir(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente)
        {
            ValidarPessoaFisica(pessoaFisica);
            pessoaFisicaDao.inserir(pessoaFisica, telefoneCliente);
        }
        public void atualizar(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente)
        {
            ValidarPessoaFisica(pessoaFisica);
            pessoaFisicaDao.atualizar(pessoaFisica, telefoneCliente);
        }
        public PessoaFisica Retornar(int codigo)
        {
            PessoaFisica pessoaFisica = pessoaFisicaDao.Retornar(codigo);
            return pessoaFisica;
        }
        private void ValidarPessoaFisica(PessoaFisica pessoaFisica)
        {
            if (String.IsNullOrWhiteSpace(pessoaFisica.Nome))
            {
                throw new ArgumentNullException("Nome", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.DtNascimento))
            {
                throw new ArgumentNullException("Data Nascimento", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.Logradouro))
            {
                throw new ArgumentNullException("Endereço", "Campo obrigatório não preenchido");
            }
            if (pessoaFisica.Numero == 0)
            {
                throw new ArgumentNullException("Número", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.Bairro))
            {
                throw new ArgumentNullException("Bairro", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.Cidade))
            {
                throw new ArgumentNullException("Cidade", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.Cep))
            {
                throw new ArgumentNullException("CEP", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.Cnh))
            {
                throw new ArgumentNullException("CNH", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.ValidadeCnh))
            {
                throw new ArgumentNullException("Val. CNH", "Campo obrigatório não preenchido");
            }
            if (String.IsNullOrWhiteSpace(pessoaFisica.Cpf))
            {
                throw new ArgumentNullException("CPF", "Campo obrigatório não preenchido");
            }
        }
        public List<PessoaFisica> buscarTodos()
        {
            List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
            listaPessoaFisica = this.pessoaFisicaDao.buscarTodos();
           
            return listaPessoaFisica;
        }

        public PessoaFisica BuscarPorId(int id)
        {
            return this.pessoaFisicaDao.BuscarPorId(id);
        }

        public List<PessoaFisica> buscaPorNomeOuCpf(String nome, String cpf)
        {
            return this.pessoaFisicaDao.buscaPorNomeOuCpf(nome, cpf);
        }
    }
}
