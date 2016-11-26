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
     public class TipoTelefoneDAO : ITipoTelefoneDAO
    {
        public void inserir(TipoTelefone tipoTelefone)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO tipo_telefone ( "
                  + "descricao) "
                  + "VALUES (@descricao);";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("descricao", tipoTelefone.Descricao));
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

        public void atualizar(TipoTelefone tipoTelefone)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE tipo_telefone SET descricao = @descricao);";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", tipoTelefone.Codigo));
                cmd.Parameters.Add(new MySqlParameter("descricao", tipoTelefone.Descricao));
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
            String cmdText = "DELETE FROM tipo_telefone WHERE codigo = @id;";

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

        public TipoTelefone buscaPorId(int id)
        {
            TipoTelefone tipoTelefone = new TipoTelefone();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from tipo_telefone c " +
                             "where c.codigo = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    tipoTelefone.Codigo = Convert.ToInt32(leitor["codigo"]);
                    tipoTelefone.Descricao = leitor["descricao"].ToString();
                }
            }
            conn.Close();

            return tipoTelefone;
        }

        public List<TipoTelefone> buscaTodos()
        {
            List<TipoTelefone> tipoTelefones = new List<TipoTelefone>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from tipo_telefone c ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    TipoTelefone tipoTelefone = new TipoTelefone();
                    tipoTelefone.Codigo = Convert.ToInt32(leitor["codigo"]);
                    tipoTelefone.Descricao = leitor["descricao"].ToString();
                }
            }
            conn.Close();

            return tipoTelefones;
        }
    }
}

