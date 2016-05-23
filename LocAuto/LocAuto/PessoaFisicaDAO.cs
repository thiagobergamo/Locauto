using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LocAuto
{
    class PessoaFisicaDAO
    {
        public String inserir(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente)
        {
            String msg;
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO cliente ( email, login_web, senha_web, cnh, validade_cnh, logradouro, numero, complemento, bairro, cep, cidade, estado) values ( @email, @login_web, @senha_web, @cnh, @validade_cnh, @logradouro, @numero, @complemento, @bairro, @cep, @cidade, @estado);";
            long id;
            id = 0;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("email", pessoaFisica.Email));
                cmd.Parameters.Add(new MySqlParameter("login_web", pessoaFisica.LoginWeb));
                cmd.Parameters.Add(new MySqlParameter("senha_web", pessoaFisica.SenhaWeb));
                cmd.Parameters.Add(new MySqlParameter("cnh", pessoaFisica.Cnh));
                cmd.Parameters.Add(new MySqlParameter("validade_cnh", pessoaFisica.ValidadeCnh));
                cmd.Parameters.Add(new MySqlParameter("logradouro", pessoaFisica.Logradouro));
                cmd.Parameters.Add(new MySqlParameter("numero", pessoaFisica.Numero));
                cmd.Parameters.Add(new MySqlParameter("complemento", pessoaFisica.Complemento));
                cmd.Parameters.Add(new MySqlParameter("bairro", pessoaFisica.Bairro));
                cmd.Parameters.Add(new MySqlParameter("cep", pessoaFisica.Cep));
                cmd.Parameters.Add(new MySqlParameter("cidade", pessoaFisica.Cidade));
                cmd.Parameters.Add(new MySqlParameter("estado", pessoaFisica.Estado));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
                MessageBox.Show(id.ToString());
                //return "Usuário salvo com sucesso.";
            }
            catch (Exception ex)
            {
                msg = "Erro ao salvar cliente - " + ex;
            }
            finally
            {
                conn.Close();
            }

            cmdText = "INSERT INTO pessoa_fisica (codigo_cliente, nome, cpf, rg, outro_documento) values ( @codigo_cliente, @nome, @cpf, @rg, @outro_documento);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_cliente", id));
                cmd.Parameters.Add(new MySqlParameter("nome", pessoaFisica.Nome));
                cmd.Parameters.Add(new MySqlParameter("cpf", pessoaFisica.Cpf));
                cmd.Parameters.Add(new MySqlParameter("rg", pessoaFisica.Rg));
                cmd.Parameters.Add(new MySqlParameter("outro_documento", pessoaFisica.OutroDocumento));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                msg = "Cliente salvo com sucesso.";
            }
            catch (Exception ex)
            {
                msg = "Erro ao salvar cliente - " + ex;
            }
            finally
            {
                conn.Close();
            }

            foreach(TelefoneCliente telefone in telefoneCliente)
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
                    msg = "Cliente salvo com sucesso.";
                }
                catch (Exception ex)
                {
                    msg = "Erro ao salvar cliente - " + ex;
                }
                finally
                {
                    conn.Close();
                }

            }

            return msg;
        }

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
            conn.Close();

            return pessoaFisica;
        }


    }
}
