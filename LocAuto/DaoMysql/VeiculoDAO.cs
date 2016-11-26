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

        public void atualizar(Veiculo veiculo)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE veiculo SET codigo_tipo_veiculo = @codigo_tipo_veiculo, codigo_situacao_veiculo = @codigo_situacao_veiculo, marca = @marca, modelo = @modelo, ano = @ano, placa = @placa, chassi = @chassi, cor = @cor, observacao = @observacao;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("id", veiculo.Codigo));
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

        public void apagar(int id) {

            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "DELETE veiculo WHERE codigo = @id;";

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
        public Veiculo buscaPorId(int id) {

            Veiculo veiculo = new Veiculo();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from veiculo c " +
                             "where c.codigo = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("id", id.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    veiculo.Codigo = Convert.ToInt32(leitor["codigo"]);
                    veiculo.codigoTipoVeiculo = Convert.ToInt32(leitor["codigo_tipo_veiculo"]);
                    veiculo.codigoSituacaoVeiculo = Convert.ToInt32(leitor["codigo_situacao_veiculo"]);
                    veiculo.Marca = leitor["marca"].ToString();
                    veiculo.Modelo = leitor["modelo"].ToString();
                    veiculo.Ano = Convert.ToInt32(leitor["ano"]);
                    veiculo.Placa = leitor["placa"].ToString();
                    veiculo.Chassi = leitor["chassi"].ToString();
                    veiculo.Cor = leitor["cor"].ToString();
                    veiculo.Observacao = leitor["observacao"].ToString();
                }
            }
            conn.Close();

            return veiculo;
        }
        public List<Veiculo> buscaTodos() {

            List<Veiculo> veiculos = new List<Veiculo>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * " +
                             "from veiculo c ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    Veiculo veiculo = new Veiculo();
                    veiculo.Codigo = Convert.ToInt32(leitor["codigo"]);
                    veiculo.codigoTipoVeiculo = Convert.ToInt32(leitor["codigo_tipo_veiculo"]);
                    veiculo.codigoSituacaoVeiculo = Convert.ToInt32(leitor["codigo_situacao_veiculo"]);
                    veiculo.Marca = leitor["marca"].ToString();
                    veiculo.Modelo = leitor["modelo"].ToString();
                    veiculo.Ano = Convert.ToInt32(leitor["ano"]);
                    veiculo.Placa = leitor["placa"].ToString();
                    veiculo.Chassi = leitor["chassi"].ToString();
                    veiculo.Cor = leitor["cor"].ToString();
                    veiculo.Observacao = leitor["observacao"].ToString();
                    veiculos.Add(veiculo);
                }
            }
            conn.Close();

            return veiculos;
        }
    }
}
