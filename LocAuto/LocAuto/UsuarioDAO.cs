using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class UsuarioDAO
    {
        public String inserir(Usuario usuario)
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
