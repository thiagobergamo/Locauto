using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class VeiculoDAO
    {
        public String inserir(Veiculo veiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO veiculo (marca, modelo, ano, placa, chassi, cor, observacao) values (@marca, @modelo, @ano, @placa, @chasse, @cor, @observacao);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("marca", veiculo.Marca));
                cmd.Parameters.Add(new MySqlParameter("modelo", veiculo.Modelo));
                cmd.Parameters.Add(new MySqlParameter("ano", veiculo.Ano));
                cmd.Parameters.Add(new MySqlParameter("placa", veiculo.Placa));
                cmd.Parameters.Add(new MySqlParameter("chassi", veiculo.Chassi));
                cmd.Parameters.Add(new MySqlParameter("cor", veiculo.Cor));
                cmd.Parameters.Add(new MySqlParameter("observacao", veiculo.Observacao));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return "Veículo salvo com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar Veículo - " + ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
