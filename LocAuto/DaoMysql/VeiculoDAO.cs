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
    public class VeiculoDAO : IVeiculoDAO
    {
        public void inserir(Veiculo veiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO veiculo (codigo_tipo_veiculo, codigo_situacao_veiculo, marca, modelo, ano, placa, chassi, cor, observacao) values (@codigo_tipo_veiculo, @codigo_situacao_veiculo, @marca, @modelo, @ano, @placa, @chassi, @cor, @observacao);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_tipo_veiculo", veiculo.codigoTipoVeiculo));
                cmd.Parameters.Add(new MySqlParameter("codigo_situacao_veiculo", veiculo.codigoSituacaoVeiculo));
                cmd.Parameters.Add(new MySqlParameter("marca", veiculo.Marca));
                cmd.Parameters.Add(new MySqlParameter("modelo", veiculo.Modelo));
                cmd.Parameters.Add(new MySqlParameter("ano", veiculo.Ano));
                cmd.Parameters.Add(new MySqlParameter("placa", veiculo.Placa));
                cmd.Parameters.Add(new MySqlParameter("chassi", veiculo.Chassi));
                cmd.Parameters.Add(new MySqlParameter("cor", veiculo.Cor));
                cmd.Parameters.Add(new MySqlParameter("observacao", veiculo.Observacao));
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
}
