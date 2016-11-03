using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;
using MySql.Data.MySqlClient;

namespace DaoMysql
{
    public class PessoaJuridicaDAO : IPessoaJuridicaDAO
    {
        public void inserir(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO cliente ( email, login_web, senha_web, cnh, validade_cnh, logradouro, numero, complemento, bairro, cep, cidade, estado) values ( @email, @login_web, @senha_web, @cnh, @validade_cnh, @logradouro, @numero, @complemento, @bairro, @cep, @cidade, @estado);";
            long id;
            //String msg;
            id = 0;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("email", pessoaJuridica.Email));
                cmd.Parameters.Add(new MySqlParameter("login_web", pessoaJuridica.LoginWeb));
                cmd.Parameters.Add(new MySqlParameter("senha_web", pessoaJuridica.SenhaWeb));
                cmd.Parameters.Add(new MySqlParameter("cnh", pessoaJuridica.Cnh));
                cmd.Parameters.Add(new MySqlParameter("validade_cnh", pessoaJuridica.ValidadeCnh));
                cmd.Parameters.Add(new MySqlParameter("logradouro", pessoaJuridica.Logradouro));
                cmd.Parameters.Add(new MySqlParameter("numero", pessoaJuridica.Numero));
                cmd.Parameters.Add(new MySqlParameter("complemento", pessoaJuridica.Complemento));
                cmd.Parameters.Add(new MySqlParameter("bairro", pessoaJuridica.Bairro));
                cmd.Parameters.Add(new MySqlParameter("cep", pessoaJuridica.Cep));
                cmd.Parameters.Add(new MySqlParameter("cidade", pessoaJuridica.Cidade));
                cmd.Parameters.Add(new MySqlParameter("estado", pessoaJuridica.Estado));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
                //return "Usuário salvo com sucesso.";
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            cmdText = "INSERT INTO pessoa_juridica (codigo_cliente, cnpj, insc_estadual, razao_social, nome_fantasia, contato, nome_condutor) values (@codigo_cliente, @cnpj, @inscricao_estadual, @razao_social, @nome_fantasia, @contato, @nome_condutor);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_cliente", id));
                cmd.Parameters.Add(new MySqlParameter("cnpj", pessoaJuridica.Cnpj));
                cmd.Parameters.Add(new MySqlParameter("inscricao_estadual", pessoaJuridica.InscEstadual));
                cmd.Parameters.Add(new MySqlParameter("razao_social", pessoaJuridica.RazaoSocial));
                cmd.Parameters.Add(new MySqlParameter("nome_fantasia", pessoaJuridica.NomeFantasia));
                cmd.Parameters.Add(new MySqlParameter("contato", pessoaJuridica.Contato));
                cmd.Parameters.Add(new MySqlParameter("nome_condutor", pessoaJuridica.NomeCondutor));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                //msg = "Cliente salvo com sucesso.";
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            foreach (TelefoneCliente telefone in telefoneCliente)
            {
                cmdText = "INSERT INTO telefone_cliente (codigo_cliente, codigo_tipo_telefone, telefone) values (@codigo_cliente, @codigo_tipo_telefone, @telefone);";

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                    cmd.Parameters.Add(new MySqlParameter("codigo_cliente", id));
                    cmd.Parameters.Add(new MySqlParameter("codigo_tipo_telefone", telefone.Tipo));
                    cmd.Parameters.Add(new MySqlParameter("telefone", telefone.Numero));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    //msg = "Cliente salvo com sucesso.";
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

       //     return msg;
        }

        public PessoaJuridica Retornar(int codigo)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from cliente c " +
                             "join pessoa_juridica j on j.codigo_cliente = c.codigo " +
                             "where c.codigo = @codigo";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("codigo", codigo.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    pessoaJuridica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaJuridica.NomeFantasia = leitor["nome_fantasia"].ToString();
                    pessoaJuridica.Cnh = leitor["cnh"].ToString();
                    pessoaJuridica.Email = leitor["email"].ToString();
                    pessoaJuridica.NomeCondutor = leitor["nome_condutor"].ToString();
                }
            }
            conn.Close();

            return pessoaJuridica;
        }
    }
}
