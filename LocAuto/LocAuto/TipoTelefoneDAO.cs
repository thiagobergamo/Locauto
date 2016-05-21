using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    public class TipoTelefoneDAO
    {
        public String inserir(TipoTelefone tipoTelefone)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO tipo_telefone ( "
                  + "descricao) "
                  + "VALUES (@descricao);";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("descricao", tipoTelefone.Descricao));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return "Tipo de telefone salvo com sucesso.";
            }
            catch(Exception ex)
            {
                return "Erro ao salvar tipo de telefone - " + ex; 
            }

            finally
            {
                conn.Close();
            }
            
            
        }


    }
}
