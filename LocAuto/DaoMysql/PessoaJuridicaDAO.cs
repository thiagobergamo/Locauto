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

        public void atualizar(PessoaJuridica pessoaJuridica, List<TelefoneCliente> telefoneCliente)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE cliente SET email = @email, login_web = @login_web, senha_web = @senha_web, cnh = @cnh, validade_cnh = @validade_cnh, logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, cep = @cep, cidade = @cidade, estado = @estado WHERE codigo = @id;";
            long id;
            id = 0;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", pessoaJuridica.Codigo));
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

            cmdText = "UPDATE pessoa_juridica SET cnpj = @cnpj, insc_estadual = @insc_estadual, razao_social = @razao_social, nome_fantasia = @nome_fantasia, contato = @contato, nome_condutor = @nome_condutor;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_cliente", id));
                cmd.Parameters.Add(new MySqlParameter("cnpj", pessoaJuridica.Cnpj));
                cmd.Parameters.Add(new MySqlParameter("insc_estadual", pessoaJuridica.InscEstadual));
                cmd.Parameters.Add(new MySqlParameter("razao_social", pessoaJuridica.RazaoSocial));
                cmd.Parameters.Add(new MySqlParameter("nome_fantasia", pessoaJuridica.NomeFantasia));
                cmd.Parameters.Add(new MySqlParameter("contato", pessoaJuridica.Contato));
                cmd.Parameters.Add(new MySqlParameter("nome_condutor", pessoaJuridica.NomeCondutor));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            cmdText = "DELETE FROM telefone_cliente WHERE codigo_cliente = @id";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", pessoaJuridica.Codigo));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
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
                    cmd.Parameters.Add(new MySqlParameter("codigo_cliente", pessoaJuridica.Codigo));
                    cmd.Parameters.Add(new MySqlParameter("codigo_tipo_telefone", telefone.Tipo));
                    cmd.Parameters.Add(new MySqlParameter("telefone", telefone.Numero));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
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
        }

        public List<PessoaJuridica> buscarTodos()
        {
            List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = " select *, " +
                             " (select telefone from telefone_cliente where codigo_cliente = c.codigo and codigo_tipo_telefone = 1) celular" +
                             " from cliente c " +
                             " join pessoa_juridica j on j.codigo_cliente = c.codigo ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    PessoaJuridica pessoaJuridica = new PessoaJuridica();
                    //pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaJuridica.Codigo = Convert.ToInt32(leitor["codigo_cliente"].ToString());
                    pessoaJuridica.RazaoSocial = leitor["razao_social"].ToString();
                    pessoaJuridica.Cnpj = leitor["cnpj"].ToString();
                    listaPessoaJuridica.Add(pessoaJuridica);
                }
            }
            conn.Close();

            return listaPessoaJuridica;
        }

        public PessoaJuridica BuscarPorId(int id)
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
            cmd.Parameters.Add(new MySqlParameter("codigo", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    pessoaJuridica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaJuridica.Email = leitor["email"].ToString();
                    pessoaJuridica.LoginWeb = leitor["login_web"].ToString();
                    pessoaJuridica.SenhaWeb = leitor["senha_web"].ToString();
                    pessoaJuridica.Cnh = leitor["cnh"].ToString();
                    pessoaJuridica.ValidadeCnh = leitor["validade_cnh"].ToString();
                    pessoaJuridica.Logradouro = leitor["logradouro"].ToString();
                    pessoaJuridica.Numero = Convert.ToInt32(leitor["numero"].ToString());
                    pessoaJuridica.Complemento = leitor["complemento"].ToString();
                    pessoaJuridica.Bairro = leitor["bairro"].ToString();
                    pessoaJuridica.Cep = leitor["cep"].ToString();
                    pessoaJuridica.Cidade = leitor["cidade"].ToString();
                    pessoaJuridica.Estado = leitor["estado"].ToString();
                    pessoaJuridica.RazaoSocial = leitor["razao_social"].ToString();
                    pessoaJuridica.Cnpj = leitor["cnpj"].ToString();
                    pessoaJuridica.InscEstadual = leitor["insc_estadual"].ToString();

                }
            }
            List<TelefoneCliente> listaTelefoneCliente = new List<TelefoneCliente>();
            cmdText = "select * " +
                             "from telefone_cliente c " +
                             "where c.codigo_cliente = @id";


            cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", pessoaJuridica.Codigo));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    TelefoneCliente telefoneCliente = new TelefoneCliente();
                    telefoneCliente.codigo_cliente = Convert.ToInt32(leitor["codigo_cliente"]);
                    telefoneCliente.Tipo = Convert.ToInt32(leitor["codigo_tipo_telefone"]);
                    telefoneCliente.Numero = leitor["telefone"].ToString();
                    listaTelefoneCliente.Add(telefoneCliente);
                }
            }

            conn.Close();
            pessoaJuridica.Telefones = listaTelefoneCliente;
            return pessoaJuridica;
        }

        public void apagar(int id)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "DELETE FROM pessoa_juridica WHERE codigo_cliente = @id;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
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

        public List<PessoaJuridica> buscaPorNomeOuCnpj(String nome, String cnpj)
        {
            List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = " select *, " +
                             " (select telefone from telefone_cliente where codigo_cliente = c.codigo and codigo_tipo_telefone = 1) celular" +
                             " from cliente c " +
                             " join pessoa_juridica j on j.codigo_cliente = c.codigo " +
                             " where razao_social like @nome or cnpj = @cnpj";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("nome", nome));
            cmd.Parameters.Add(new MySqlParameter("cnpj", cnpj));
            cmd.Prepare();

            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    PessoaJuridica pessoaJuridica = new PessoaJuridica();
                    //pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaJuridica.Codigo = Convert.ToInt32(leitor["codigo_cliente"].ToString());
                    pessoaJuridica.RazaoSocial = leitor["razao_social"].ToString();
                    pessoaJuridica.Cnpj = leitor["cnpj"].ToString();
                    listaPessoaJuridica.Add(pessoaJuridica);
                }
            }
            conn.Close();

            return listaPessoaJuridica;
        }
    }
}
