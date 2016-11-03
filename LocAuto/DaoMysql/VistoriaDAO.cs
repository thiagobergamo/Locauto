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
    public class VistoriaDAO : IVistoriaDAO
    {
        public void inserir(Vistoria vistoria)
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
                cmd.Parameters.Add(new MySqlParameter("nivel_comb_loc", vistoria.NivelCombLoc));
                cmd.Parameters.Add(new MySqlParameter("laudo_loc", vistoria.LaudoLoc));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
             //   return "Vistoria salvo com sucesso.";
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
        public void atualizar(Vistoria vistoria)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "UPDATE vistoria set km_dev = @km_dev, nivel_comb_dev = @nivel_comb_dev, laudo_dev = @laudo_dev where codigo_locacao = @codigo_locacao;" +
                             "UPDATE locacao set data_devolucao = now() where codigo = @codigo_locacao1;";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_locacao", vistoria.CodigoLocacao));
                cmd.Parameters.Add(new MySqlParameter("km_dev", vistoria.KmDev));
                cmd.Parameters.Add(new MySqlParameter("nivel_comb_dev", vistoria.NivelCombDev));
                cmd.Parameters.Add(new MySqlParameter("laudo_dev", vistoria.LaudoDev));
                cmd.Parameters.Add(new MySqlParameter("codigo_locacao1", vistoria.CodigoLocacao));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            //    return "Vistoria salvo com sucesso.";
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
        public Vistoria Retornar(int codigo)
        {
            Vistoria vistoria = new Vistoria();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * from vistoria where codigo_locacao = @codigo";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.Add(new MySqlParameter("codigo", codigo.ToString()));
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    vistoria.Codigo = Convert.ToInt32(leitor["codigo"]);
                    vistoria.KmLoc = Convert.ToInt32(leitor["km_loc"].ToString());
                    vistoria.NivelCombLoc = leitor["nivel_comb_loc"].ToString();
                    vistoria.LaudoLoc = leitor["laudo_loc"].ToString();

                }
            }
            conn.Close();

            return vistoria;
        }
    }
}
