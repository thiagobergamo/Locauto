using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class PessoaJuridicaDAO
    {
        public String inserir(PessoaJuridica pessoaJuridica)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO cliente ( email, login_web, senha_web, cnh, validade_cnh, logradouro, numero, complemento, bairro, cep, cidade, estado) values ( @email, @login_web, @senha_web, @cnh, @validade_cnh, @logradouro, @numero, @complemento, @bairro, @cep, @cidade, @estado);";
            long id;
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
            catch (Exception ex)
            {
                return "Erro ao salvar usuário - " + ex;
            }
            finally
            {
                conn.Close();
            }
            cmdText = "INSERT INTO pessoa_juridica ( cnpj, inscricao_estadual, razao_social, nome_fantasia, contato, nome_condutor) values ( @cnpj, @inscricao_estadual, @razao_social, @nome_fantasia, @contato, @nome_condutor);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("cnpj", pessoaJuridica.Cnpj));
                cmd.Parameters.Add(new MySqlParameter("inscricao_estadual", pessoaJuridica.InscEstadual));
                cmd.Parameters.Add(new MySqlParameter("razao_social", pessoaJuridica.RazaoSocial));
                cmd.Parameters.Add(new MySqlParameter("nome_fantasia", pessoaJuridica.NomeFantasia));
                cmd.Parameters.Add(new MySqlParameter("contato", pessoaJuridica.Contato));
                cmd.Parameters.Add(new MySqlParameter("nome_condutor", pessoaJuridica.NomeCondutor));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
                return "Usuário salvo com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar usuário - " + ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}