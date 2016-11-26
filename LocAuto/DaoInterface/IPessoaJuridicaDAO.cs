using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface IPessoaJuridicaDAO
    {
        void inserir(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente);
        PessoaJuridica Retornar(int codigo);
        List<PessoaJuridica> buscarTodos();
        PessoaJuridica BuscarPorId(int id);
        void apagar(int id);
        List<PessoaJuridica> buscaPorNomeOuCnpj(String nome, String cnpj);
        void atualizar(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente);
    }
}
