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
    }
}
