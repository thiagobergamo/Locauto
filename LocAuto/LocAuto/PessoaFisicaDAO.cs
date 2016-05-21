using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class PessoaFisicaDAO
    {
        public PessoaFisica Retornar(int codigo)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from cliente c " +
                             "join pessoa_fisica j on j.codigo_cliente = c.codigo " +
                             "where c.codigo = @codigo";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("codigo", codigo.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaFisica.Nome = leitor["nome"].ToString();
                    pessoaFisica.Cnh = leitor["cnh"].ToString();
                    pessoaFisica.Email = leitor["email"].ToString();
                    //  pessoaFisica

                }
            }
            return pessoaFisica;
        }
    }
}
