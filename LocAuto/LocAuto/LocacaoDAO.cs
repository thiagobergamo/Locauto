using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace LocAuto
{
    class LocacaoDAO
    {
        public string Inserir(Locacao locacao)
        {
            string msg;
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();
            String cmdText = "INSERT INTO locacao (codigo_cliente, codigo_veiculo, data_locacao, data_prev_devolucao, forma_pagamento, valor_total, pago, valor_caucao, valor_opc) VALUES (@codigo_cliente, @codigo_veiculo, @data_locacao, @data_prev_devolucao, @forma_pagamento, @valor_total, @pago, @valor_caucao, @valor_opc)";
            long id;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Parameters.Add(new MySqlParameter("codigo_cliente", locacao.CodigoCliente));
                cmd.Parameters.Add(new MySqlParameter("codigo_veiculo", locacao.CodigoVeiculo));
                cmd.Parameters.Add(new MySqlParameter("data_locacao", locacao.DataLocacao));
                cmd.Parameters.Add(new MySqlParameter("data_prev_devolucao", locacao.DataPrevDevolucao));
                cmd.Parameters.Add(new MySqlParameter("forma_pagamento", locacao.FormaPagamento));
                cmd.Parameters.Add(new MySqlParameter("valor_total", locacao.ValorTotal));
                cmd.Parameters.Add(new MySqlParameter("pago", locacao.Pago));
                cmd.Parameters.Add(new MySqlParameter("valor_caucao", locacao.ValorCaucao));
                cmd.Parameters.Add(new MySqlParameter("valor_opc", locacao.ValorOpc));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
                msg = "Locação salva com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao salvar locação - " + ex;
            }
            finally
            {
                conn.Close();
            }

            return msg;

        }
    }
}
