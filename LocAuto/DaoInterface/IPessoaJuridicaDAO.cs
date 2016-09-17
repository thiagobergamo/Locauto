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
    }
}
