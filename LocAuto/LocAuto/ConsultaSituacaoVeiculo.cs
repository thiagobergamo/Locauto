using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Modelo;
using DaoMysql;

namespace LocAuto
{
    public partial class ConsultaSituacaoVeiculo : Form
    {
        public ConsultaSituacaoVeiculo()
        {
            InitializeComponent();
        }

        private void ConsultaSituacaoVeiculo_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void carregarGrid()
        {
            SituacaoVeiculoDAO dao = new SituacaoVeiculoDAO();
            SituacaoVeiculoService service = new SituacaoVeiculoService(dao);
            List<SituacaoVeiculo> listaSituacaoVeiculo = new List<SituacaoVeiculo>();
            listaSituacaoVeiculo = service.buscaTodos();
            dataGridView1.Rows.Clear();
            foreach (SituacaoVeiculo t in listaSituacaoVeiculo)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = t.Codigo;
                linhaTabela.Cells["descricao"].Value = t.Descricao;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadSituacaoVeiculo cadSituacaoVeiculo = new CadSituacaoVeiculo();
            cadSituacaoVeiculo.ShowDialog();
            carregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            SituacaoVeiculoDAO dao = new SituacaoVeiculoDAO();
            SituacaoVeiculoService service = new SituacaoVeiculoService(dao);
            try
            {
                dao.apagar(idSelecionado);
                MessageBox.Show("Situação de Veiculo apagado com sucesso");
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
            SituacaoVeiculo situacaoVeiculoSelecionado;
            SituacaoVeiculoDAO dao = new SituacaoVeiculoDAO();
            SituacaoVeiculoService service = new SituacaoVeiculoService(dao);
            situacaoVeiculoSelecionado = service.buscaPorId(idSelecionado);

            CadSituacaoVeiculo cadSituacaoVeiculo = new CadSituacaoVeiculo();
            cadSituacaoVeiculo.situacaoVeiculoConsulta = situacaoVeiculoSelecionado;
            //cadSituacaoVeiculo.Show();
            cadSituacaoVeiculo.ShowDialog();
            carregarGrid();
        }
    }
}
