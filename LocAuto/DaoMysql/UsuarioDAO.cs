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
    public class UsuarioDAO : IUsuarioDAO
    {
        public void inserir(Usuario usuario)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO usuario (nome, email, login, senha) values (@nome, @email, @login, @senha);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("nome", usuario.Nome));
                cmd.Parameters.Add(new MySqlParameter("email", usuario.Email));
                cmd.Parameters.Add(new MySqlParameter("login", usuario.Login));
                cmd.Parameters.Add(new MySqlParameter("senha", usuario.Senha));
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

        public void atualizar(Usuario usuario)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE usuario SET nome = @nome, email = @email, login = @login, senha = @senha WHERE codigo = @id;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", usuario.Codigo));
                cmd.Parameters.Add(new MySqlParameter("nome", usuario.Nome));
                cmd.Parameters.Add(new MySqlParameter("email", usuario.Email));
                cmd.Parameters.Add(new MySqlParameter("login", usuario.Login));
                cmd.Parameters.Add(new MySqlParameter("senha", usuario.Senha));
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

        public void apagar(int id)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "DELETE usuario WHERE codigo = @id;";

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

        public Usuario buscaPorId(int id)
        {
            Usuario usuario = new Usuario();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from usuario c " +
                             "where c.codigo = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    usuario.Codigo = Convert.ToInt32(leitor["codigo"]);
                    usuario.Nome = leitor["nome"].ToString();
                    usuario.Email = leitor["email"].ToString();
                    usuario.Login = leitor["login"].ToString();
                    usuario.Senha = leitor["senha"].ToString();
                }
            }
            conn.Close();

            return usuario;
        }

        public List<Usuario> buscaTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from usuario c ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Codigo = Convert.ToInt32(leitor["codigo"]);
                    usuario.Nome = leitor["nome"].ToString();
                    usuario.Email = leitor["email"].ToString();
                    usuario.Login = leitor["login"].ToString();
                    usuario.Senha = leitor["senha"].ToString();
                    usuarios.Add(usuario);
                }
            }
            conn.Close();

            return usuarios;
        }
    }
}
