using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface IPessoaFisicaDAO
    {
        void inserir(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente);
        PessoaFisica Retornar(int codigo);
        List<PessoaFisica> buscarTodos();
        PessoaFisica BuscarPorId(int id);
        void apagar(int id);
        List<PessoaFisica> buscaPorNomeOuCpf(String nome, String cpf);
        void atualizar(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente);
    }
}
