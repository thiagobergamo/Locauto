using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class SituacaoVeiculo1DAO
    {
        public String inserir(SituacaoVeiculo situacaoVeiculo)
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
                return "Situacão do veiculo salvo com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar situacão do veiculo - " + ex;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
