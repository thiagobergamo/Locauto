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
    }
}
