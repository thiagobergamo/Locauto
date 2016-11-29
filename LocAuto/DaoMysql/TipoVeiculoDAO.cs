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

        public void atualizar(TipoVeiculo tipoVeiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE tipo_veiculo SET descricao = @descricao, ar_condicionado = @ar_condicionado, vidro_eletrico = @vidro_eletrico, trava_eletrica = @trava_eletrica, portas = @portas, abs = @abs, air_bag = @air_bag, valor_diaria = @valor_diaria WHERE codigo = @id;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", tipoVeiculo.Codigo));
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
        public void apagar(int id)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "DELETE FROM tipo_veiculo WHERE codigo = @id;";

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

        public TipoVeiculo buscaPorId(int id) {

            TipoVeiculo tipoVeiculo = new TipoVeiculo();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from tipo_veiculo c " +
                             "where c.codigo = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    tipoVeiculo.Codigo = Convert.ToInt32(leitor["codigo"]);
                    tipoVeiculo.Descricao = leitor["descricao"].ToString();
                    tipoVeiculo.ArCondicionado = leitor["ar_condicionado"].ToString();
                    tipoVeiculo.VidroEletrico = leitor["vidro_eletrico"].ToString();
                    tipoVeiculo.TravaEletrica = leitor["trava_eletrica"].ToString();
                    tipoVeiculo.Portas = leitor["portas"].ToString();
                    tipoVeiculo.Abs = leitor["abs"].ToString();
                    tipoVeiculo.AirBag = leitor["air_bag"].ToString();
                    tipoVeiculo.ValorDiaria = Convert.ToDecimal(leitor["valor_diaria"]);
                }
            }
            conn.Close();

            return tipoVeiculo;
        }
        public List<TipoVeiculo> buscaTodos() {

            List<TipoVeiculo> tipoVeiculos = new List<TipoVeiculo>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from tipo_veiculo c ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    TipoVeiculo tipoVeiculo = new TipoVeiculo();
                    tipoVeiculo.Codigo = Convert.ToInt32(leitor["codigo"]);
                    tipoVeiculo.Descricao = leitor["descricao"].ToString();
                    tipoVeiculo.ArCondicionado = leitor["ar_condicionado"].ToString();
                    tipoVeiculo.VidroEletrico = leitor["vidro_eletrico"].ToString();
                    tipoVeiculo.TravaEletrica = leitor["trava_eletrica"].ToString();
                    tipoVeiculo.Portas = leitor["portas"].ToString();
                    tipoVeiculo.Abs = leitor["abs"].ToString();
                    tipoVeiculo.AirBag = leitor["air_bag"].ToString();
                    tipoVeiculo.ValorDiaria = Convert.ToDecimal(leitor["valor_diaria"]);
                    tipoVeiculos.Add(tipoVeiculo);
                }
            }
            conn.Close();

            return tipoVeiculos;
        }
    }
}
