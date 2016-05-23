﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    public partial class ConsultaLocacao : Form
    {
        public ConsultaLocacao()
        {
            InitializeComponent();
        }

        private void ConsultaLocacao_Load(object sender, EventArgs e)
        {
            DgvConsultaPj.MultiSelect = false;
            DgvConsultaPj.AutoSize = true;
    //        DgvConsultaPj.Columns.Add("Id_loc", "ID Locação");
    //        DgvConsultaPj.Columns.Add("Nome", "Nome");
    //        DgvConsultaPj.Columns.Add("data_loc", "Data Locação");
    //        DgvConsultaPj.Columns.Add("data_prev", "Data Prev. Dev.");
    //        DgvConsultaPj.Columns.Add("Veiculo", "Veículo");
   //         DgvConsultaPj.Columns.Add("Valor_Total", "Valor Total");
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();
            String cmdText = "select *  from v_locpendpj";

            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    int index = DgvConsultaPj.Rows.Add();
                    DataGridViewRow linhaTabela = DgvConsultaPj.Rows[index];
                    linhaTabela.Cells["Id_loc"].Value = leitor["Id_loc"];
                    linhaTabela.Cells["Nome"].Value = leitor["Nome"];
                    linhaTabela.Cells["data_loc"].Value = leitor["data_loc"];
                    linhaTabela.Cells["data_prev"].Value = leitor["data_prev"];
                    linhaTabela.Cells["Veiculo"].Value = leitor["Veiculo"];
                    linhaTabela.Cells["Valor_Total"].Value = leitor["Valor_Total"];
                }
            }
        }



    }
}
