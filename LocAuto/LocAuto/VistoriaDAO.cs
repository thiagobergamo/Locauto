using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    class VistoriaDAO
    {
        public String inserir(Vistoria vistoria)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO vistoria (codigo_locacao, codigo_usuario, km_loc, nivel_comb_loc, laudo_loc) values (@codigo_locacao, @codigo_usuario, @km_loc, @nivel_comb_loc, @laudo_loc);";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_locacao", vistoria.CodigoLocacao));
                cmd.Parameters.Add(new MySqlParameter("codigo_usuario", vistoria.CodigoUsuario));
                cmd.Parameters.Add(new MySqlParameter("km_loc", vistoria.KmLoc));
                cmd.Parameters.Add(new MySqlParameter("nivel_comb_loc", vistoria.LaudoLoc));
                cmd.Parameters.Add(new MySqlParameter("laudo_loc", vistoria.NivelCombLoc));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return "Vistoria salvo com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar vistoria - " + ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
