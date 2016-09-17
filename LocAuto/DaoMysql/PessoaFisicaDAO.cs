using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;

namespace DaoMysql
{
    public class PessoaFisicaDAO:IPessoaFisicaDAO
    {
        public void inserir(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente);
        public PessoaFisica Retornar(int codigo);
    }
}
