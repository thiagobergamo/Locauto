﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DaoMysql;
using Services;

namespace LocAuto
{
    public partial class ConsultaPessoaFisica : Form
    {
        public ConsultaPessoaFisica()
        {
            InitializeComponent();
        }

        private void ConsultaPessoaFisica_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            PessoaFisicaDAO pessoaFisicaDao = new PessoaFisicaDAO();
            PessoaFisicaService pessoaFisicaService = new PessoaFisicaService(pessoaFisicaDao);
            List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
            listaPessoaFisica = pessoaFisicaService.buscarTodos();
            dataGridView1.Rows.Clear();
            foreach (PessoaFisica p in listaPessoaFisica)
            {
                int index =  dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = p.Codigo;
                linhaTabela.Cells["nome"].Value = p.Nome;
                linhaTabela.Cells["cpf"].Value = p.Cpf;
                linhaTabela.Cells["celular"].Value = p.celular;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadClienteFisica cadClienteFisica = new CadClienteFisica();
            //cadClienteFisica.MdiParent = this;
            cadClienteFisica.DesktopLocation = new Point(550, 100);
            cadClienteFisica.ShowDialog();
            carregaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PessoaFisicaDAO pessoaFisicaDao = new PessoaFisicaDAO();
            PessoaFisicaService pessoaFisicaService = new PessoaFisicaService(pessoaFisicaDao);
            List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
            if (String.IsNullOrWhiteSpace(txtNomePesquisa.Text) && String.IsNullOrWhiteSpace(txtCpfPesquisa.Text))
            {
                listaPessoaFisica = pessoaFisicaService.buscarTodos();
            }else
            {
                listaPessoaFisica = pessoaFisicaService.buscaPorNomeOuCpf(txtNomePesquisa.Text, txtCpfPesquisa.Text);
            }
            
            dataGridView1.Rows.Clear();
            foreach (PessoaFisica p in listaPessoaFisica)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = p.Codigo;
                linhaTabela.Cells["nome"].Value = p.Nome;
                linhaTabela.Cells["cpf"].Value = p.Cpf;
                linhaTabela.Cells["celular"].Value = p.celular;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            PessoaFisica pessoaFisicaSelecionada;
            PessoaFisicaDAO dao = new PessoaFisicaDAO();
            PessoaFisicaService pessoaFisicaService = new PessoaFisicaService(dao);
            pessoaFisicaSelecionada = pessoaFisicaService.BuscarPorId(idSelecionado);
            CadClienteFisica cadCliente = new CadClienteFisica();
            cadCliente.pessoaFisicaConsulta = pessoaFisicaSelecionada;
            cadCliente.ShowDialog();
            carregaGrid();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            PessoaFisicaDAO dao = new PessoaFisicaDAO();
            PessoaFisicaService pessoaFisicaService = new PessoaFisicaService(dao);
            try
            {
                pessoaFisicaService.apagar(idSelecionado);
                MessageBox.Show("Cliente apagado com sucesso");
                carregaGrid();
            }
            catch (Exception ex)
            {
                if (ex.Message == "1451")
                {
                    MessageBox.Show("Registro não pode ser apagado, pois tem registro relacionado", "Erro");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
        }
    }
}
