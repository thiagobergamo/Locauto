using DaoMysql;
using Modelo;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocAuto
{
    public partial class ConsultaVeiculo : Form
    {
        public ConsultaVeiculo()
        {
            InitializeComponent();
        }

        private void ConsultaVeiculo_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            VeiculoDAO dao = new VeiculoDAO();
            VeiculoService service = new VeiculoService(dao);
            List<Veiculo> listaVeiculo = new List<Veiculo>();
            listaVeiculo = service.buscaTodos();
            dataGridView1.Rows.Clear();
            foreach (Veiculo t in listaVeiculo)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = t.Codigo;
                linhaTabela.Cells["modelo"].Value = t.Modelo;
                linhaTabela.Cells["ano"].Value = t.Ano;
                linhaTabela.Cells["placa"].Value = t.Placa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadVeiculo cadVeiculo = new CadVeiculo();
            cadVeiculo.ShowDialog();
            carregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            VeiculoDAO dao = new VeiculoDAO();
            VeiculoService service = new VeiculoService(dao);
            try
            {
                dao.apagar(idSelecionado);
                MessageBox.Show("Veiculo apagado com sucesso");
                carregarGrid();
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

        private void button3_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            Veiculo veiculoSelecionado;
            VeiculoDAO dao = new VeiculoDAO();
            VeiculoService service = new VeiculoService(dao);
            veiculoSelecionado = service.buscaPorId(idSelecionado);

            CadVeiculo cadVeiculo = new CadVeiculo();
            cadVeiculo.veiculoConsulta = veiculoSelecionado;
            cadVeiculo.ShowDialog();
            carregarGrid();
        }
    }
}
