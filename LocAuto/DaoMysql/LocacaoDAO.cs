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
    public class LocacaoDAO : ILocacaoDAO
    {
        public long Inserir(Locacao locacao)
        {
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
                return id;

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
        public List<RelLocacao> buscaTodos()
        {
            List<RelLocacao> relLocacaos = new List<RelLocacao>();
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            String cmdText = "select * from v_locpendpf union all select * from v_locpendpj";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    RelLocacao relLocacao = new RelLocacao();
                    relLocacao.Codigo = Convert.ToInt32(leitor["Id_loc"]);
                    relLocacao.Nome = leitor["Nome"].ToString();
                    relLocacao.DataLocacao = leitor["data_loc"].ToString();
                    relLocacao.DataPrevDevolucao = leitor["data_prev"].ToString();
                    relLocacao.Veiculo = leitor["Veiculo"].ToString();
                    relLocacao.ValorTotal = Convert.ToDecimal(leitor["Valor_Total"]);
                    relLocacaos.Add(relLocacao);
                }
            }
            conn.Close();

            return relLocacaos;
        }

    }
    }
