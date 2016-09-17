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
    }
}
