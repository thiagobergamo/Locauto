using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace DaoMysql
{
    public class PessoaJuridicaDAO : IPessoaJuridicaDAO
    {
        public void inserir(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente)
        {

        }

        public PessoaJuridica Retornar(int codigo)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            return pessoaJuridica;
        }
    }
}
