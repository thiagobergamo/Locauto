using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaoMysql;
using Services;
using Modelo;

namespace LocAuto
{
    public partial class ConsultaPessoaJuridica : Form
    {
        public ConsultaPessoaJuridica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PessoaJuridicaDAO pessoaJuridicaDAO = new PessoaJuridicaDAO();
            PessoaJuridicaService pessoaJuridicaService = new PessoaJuridicaService(pessoaJuridicaDAO);
            List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();
            if (String.IsNullOrWhiteSpace(txtNomePesquisa.Text) && String.IsNullOrWhiteSpace(txtCpfPesquisa.Text))
            {
                listaPessoaJuridica = pessoaJuridicaService.buscarTodos();
            }else
            {
                listaPessoaJuridica = pessoaJuridicaService.buscaPorNomeOuCnpj(txtNomePesquisa.Text, txtCpfPesquisa.Text);
            }
                
            dataGridView1.Rows.Clear();

            foreach (PessoaJuridica p in listaPessoaJuridica)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = p.Codigo;
                linhaTabela.Cells["razaosocial"].Value = p.RazaoSocial;
                linhaTabela.Cells["cnpj"].Value = p.Cnpj;
            }
        }

        private void ConsultaPessoaJuridica_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            PessoaJuridicaDAO pessoaJuridicaDAO = new PessoaJuridicaDAO();
            PessoaJuridicaService pessoaJuridicaService = new PessoaJuridicaService(pessoaJuridicaDAO);
            List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();
            listaPessoaJuridica = pessoaJuridicaService.buscarTodos();
            dataGridView1.Rows.Clear();
            foreach (PessoaJuridica p in listaPessoaJuridica)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = p.Codigo;
                linhaTabela.Cells["razaosocial"].Value = p.RazaoSocial;
                linhaTabela.Cells["cnpj"].Value = p.Cnpj;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadClienteJuridico c = new CadClienteJuridico();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            PessoaJuridicaDAO dao = new PessoaJuridicaDAO();
            dao.apagar(idSelecionado);
            MessageBox.Show("Cliente apagado com sucesso");
            carregaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            PessoaJuridica pessoaJuridicaSelecionada;
            PessoaJuridicaDAO dao = new PessoaJuridicaDAO();
            PessoaJuridicaService pessoaJuridicaService = new PessoaJuridicaService(dao);
            pessoaJuridicaSelecionada = pessoaJuridicaService.BuscarPorId(idSelecionado);
            CadClienteJuridico cadCliente = new CadClienteJuridico();
            cadCliente.pessoaJuridicaConsulta = pessoaJuridicaSelecionada;
            cadCliente.ShowDialog();
        }
    }
}
