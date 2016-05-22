using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class TipoVeiculoDAO
    {
        public String inserir(TipoVeiculo tipoVeiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO tipo_veiculo (descricao, ar_condicionado, vidro_eletrico, trava_eletrica, portas, abs, air_bag, valor_diaria) values (@descricao, @ar_condicionado, @vidro_eletrico, @trava_eletrica, @portas, @abs, @air_bag, @valor_diaria);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("descricao", tipoVeiculo.Descricao));
                cmd.Parameters.Add(new MySqlParameter("ar_condicionado", tipoVeiculo.ArCondicionado));
                cmd.Parameters.Add(new MySqlParameter("vidro_eletrico", tipoVeiculo.VidroEletrico));
                cmd.Parameters.Add(new MySqlParameter("trava_eletrica", tipoVeiculo.TravaEletrica));
                cmd.Parameters.Add(new MySqlParameter("portas", tipoVeiculo.Portas));
                cmd.Parameters.Add(new MySqlParameter("abs", tipoVeiculo.Abs));
                cmd.Parameters.Add(new MySqlParameter("air_bag", tipoVeiculo.AirBag));
                cmd.Parameters.Add(new MySqlParameter("valor_diaria", tipoVeiculo.ValorDiaria));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return "Tipo veículo salvo com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar tipo veículo - " + ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
