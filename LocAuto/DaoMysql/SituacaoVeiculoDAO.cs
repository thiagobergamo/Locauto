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
    public class SituacaoVeiculoDAO : ISituacaoVeiculoDAO
    {
        public void inserir(SituacaoVeiculo situacaoVeiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO situacao_veiculo (descricao) values (@descricao);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("descricao", situacaoVeiculo.Descricao));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
              //  return "Situacão do veiculo salvo com sucesso.";
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

        public void atualizar(SituacaoVeiculo situacaoVeiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE situacao_veiculo SET descricao = @descricao WHERE codigo = @id;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", situacaoVeiculo.Codigo));
                cmd.Parameters.Add(new MySqlParameter("descricao", situacaoVeiculo.Descricao));
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
            String cmdText = "DELETE FROM situacao_veiculo WHERE codigo = @id;";

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public SituacaoVeiculo buscaPorId(int id)
        {
            SituacaoVeiculo situacaoVeiculo = new SituacaoVeiculo();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from situacao_veiculo c " +
                             "where c.codigo = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    situacaoVeiculo.Codigo = Convert.ToInt32(leitor["codigo"]);
                    situacaoVeiculo.Descricao = leitor["descricao"].ToString();
                }
            }
            conn.Close();
            return situacaoVeiculo;
        }

        public List<SituacaoVeiculo> buscaTodos()
        {
            List<SituacaoVeiculo> situacaoVeiculos = new List<SituacaoVeiculo>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from situacao_veiculo c ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    SituacaoVeiculo situacaoVeiculo = new SituacaoVeiculo();
                    situacaoVeiculo.Codigo = Convert.ToInt32(leitor["codigo"]);
                    situacaoVeiculo.Descricao = leitor["descricao"].ToString();
                    situacaoVeiculos.Add(situacaoVeiculo);
                }
            }
            conn.Close();

            return situacaoVeiculos;
        }

    }
}
