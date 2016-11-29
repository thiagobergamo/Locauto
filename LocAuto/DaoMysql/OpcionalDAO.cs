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
    public class OpcionalDAO : IOpcionalDAO
    {
        public void inserir(Opcional opcional)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO opcional (descricao, valor) values (@descricao, @valor);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("descricao", opcional.Descricao));
                cmd.Parameters.Add(new MySqlParameter("valor", opcional.Valor));
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

        public void atualizar(Opcional opcional)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE opcional SET descricao = @descricao, valor = @valor WHERE codigo = @id;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", opcional.Codigo));
                cmd.Parameters.Add(new MySqlParameter("descricao", opcional.Descricao));
                cmd.Parameters.Add(new MySqlParameter("valor", opcional.Valor));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
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
            String cmdText = " DELETE FROM opcional WHERE codigo = @id;";

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
                throw new Exception(ex.Number.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public Opcional buscaPorId(int id)
        {
            Opcional opcional = new Opcional();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from opcional c " +
                             "where c.codigo = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    opcional.Codigo = Convert.ToInt32(leitor["codigo"]);
                    opcional.Descricao = leitor["descricao"].ToString();
                    opcional.Valor = Convert.ToInt32(leitor["valor"]);
                }
            }
            conn.Close();

            return opcional;
        }

        public List<Opcional> buscaTodos()
        {
            List<Opcional> opcionais = new List<Opcional>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from opcional c ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    Opcional opcional = new Opcional();
                    opcional.Codigo = Convert.ToInt32(leitor["codigo"]);
                    opcional.Descricao = leitor["descricao"].ToString();
                    opcional.Valor = Convert.ToInt32(leitor["valor"]);
                    opcionais.Add(opcional);
                }
            }
            conn.Close();

            return opcionais;
        }
    }
}
