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
    public class TipoVeiculoDAO : ITipoVeiculoDAO
    {
        public void inserir(TipoVeiculo tipoVeiculo)
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
