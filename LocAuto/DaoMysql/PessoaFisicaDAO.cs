﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DaoInterface;
using MySql.Data.MySqlClient;

namespace DaoMysql
{
    public class PessoaFisicaDAO : IPessoaFisicaDAO
    {
        public void inserir(PessoaFisica pessoaFisica, List<TelefoneCliente> telefoneCliente)
        {
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

            cmdText = "INSERT INTO pessoa_fisica (codigo_cliente, nome, cpf, rg, outro_documento, dt_nascimento) values ( @codigo_cliente, @nome, @cpf, @rg, @outro_documento, @dt_nascimento);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_cliente", id));
                cmd.Parameters.Add(new MySqlParameter("nome", pessoaFisica.Nome));
                cmd.Parameters.Add(new MySqlParameter("cpf", pessoaFisica.Cpf));
                cmd.Parameters.Add(new MySqlParameter("rg", pessoaFisica.Rg));
                cmd.Parameters.Add(new MySqlParameter("outro_documento", pessoaFisica.OutroDocumento));
                cmd.Parameters.Add(new MySqlParameter("dt_nascimento", pessoaFisica.DtNascimento));
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
                    cmd.Parameters.Add(new MySqlParameter("codigo_cliente", id));
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

        public List<PessoaFisica> buscarTodos()
        {
            List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = " select *, " +
                             " (select telefone from telefone_cliente where codigo_cliente = c.codigo and codigo_tipo_telefone = 1) celular" +
                             " from cliente c " +
                             " join pessoa_fisica j on j.codigo_cliente = c.codigo ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    PessoaFisica pessoaFisica = new PessoaFisica();
                    //pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo_cliente"].ToString());
                    pessoaFisica.Nome = leitor["nome"].ToString();
                    pessoaFisica.Cpf = leitor["cpf"].ToString();
                    pessoaFisica.celular = leitor["celular"].ToString();
                    listaPessoaFisica.Add(pessoaFisica);
                }
            }
            conn.Close();

            return listaPessoaFisica;
        }

        public PessoaFisica BuscarPorId(int id)
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
            cmd.Parameters.Add(new MySqlParameter("codigo", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaFisica.Email = leitor["email"].ToString();
                    pessoaFisica.LoginWeb = leitor["login_web"].ToString();
                    pessoaFisica.SenhaWeb = leitor["senha_web"].ToString();
                    pessoaFisica.Cnh = leitor["cnh"].ToString();
                    pessoaFisica.ValidadeCnh = leitor["validade_cnh"].ToString();
                    pessoaFisica.Logradouro = leitor["logradouro"].ToString();
                    pessoaFisica.Numero = Convert.ToInt32(leitor["numero"].ToString());
                    pessoaFisica.Complemento = leitor["complemento"].ToString();
                    pessoaFisica.Bairro = leitor["bairro"].ToString();
                    pessoaFisica.Cep = leitor["cep"].ToString();
                    pessoaFisica.Cidade = leitor["cidade"].ToString();
                    pessoaFisica.Estado = leitor["estado"].ToString();
                    pessoaFisica.Nome = leitor["nome"].ToString();
                    pessoaFisica.Cpf = leitor["cpf"].ToString();
                    pessoaFisica.Rg = leitor["rg"].ToString();
                    pessoaFisica.OutroDocumento = leitor["outro_documento"].ToString();
                    pessoaFisica.DtNascimento = leitor["dt_nascimento"].ToString();

                }
            }

            conn.Close();

            return pessoaFisica;
        }

        public void apagar(int id)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "DELETE FROM pessoa_fisica WHERE codigo_cliente = @id;";

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

        public List<PessoaFisica> buscaPorNomeOuCpf(String nome, String cpf)
        {
            List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = " select *, " +
                             " (select telefone from telefone_cliente where codigo_cliente = c.codigo and codigo_tipo_telefone = 1) celular" +
                             " from cliente c " +
                             " join pessoa_fisica j on j.codigo_cliente = c.codigo " +
                             " where nome like @nome or cpf = @cpf";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("@nome", nome));
            cmd.Parameters.Add(new MySqlParameter("@cpf", cpf));
            cmd.Prepare();

            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    PessoaFisica pessoaFisica = new PessoaFisica();
                    //pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo"]);
                    pessoaFisica.Codigo = Convert.ToInt32(leitor["codigo_cliente"].ToString());
                    pessoaFisica.Nome = leitor["nome"].ToString();
                    pessoaFisica.Cpf = leitor["cpf"].ToString();
                    pessoaFisica.celular = leitor["celular"].ToString();
                    listaPessoaFisica.Add(pessoaFisica);
                }
            }
            conn.Close();

            return listaPessoaFisica;
        }
    }

}
