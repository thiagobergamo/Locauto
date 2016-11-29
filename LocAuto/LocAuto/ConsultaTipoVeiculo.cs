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
    public partial class ConsultaTipoVeiculo : Form
    {
        public ConsultaTipoVeiculo()
        {
            InitializeComponent();
        }

        private void ConsultaTipoVeiculo_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            TipoVeiculoDAO dao = new TipoVeiculoDAO();
            TipoVeiculoService service = new TipoVeiculoService(dao);
            List<TipoVeiculo> listaTipoVeiculo = new List<TipoVeiculo>();
            listaTipoVeiculo = service.buscaTodos();
            dataGridView1.Rows.Clear();
            foreach(TipoVeiculo t in listaTipoVeiculo)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = t.Codigo;
                linhaTabela.Cells["descricao"].Value = t.Descricao;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadTipoVeiculo cadTipoVeiculo = new CadTipoVeiculo();
            cadTipoVeiculo.ShowDialog();
            carregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            TipoVeiculoDAO dao = new TipoVeiculoDAO();
            TipoVeiculoService service = new TipoVeiculoService(dao);
            try
            {
                dao.apagar(idSelecionado);
                MessageBox.Show("Tipo de Veiculo apagado com sucesso");
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
            TipoVeiculo tipoVeiculoSelecionado;
            TipoVeiculoDAO dao = new TipoVeiculoDAO();
            TipoVeiculoService service = new TipoVeiculoService(dao);
            tipoVeiculoSelecionado = service.buscaPorId(idSelecionado);

            CadTipoVeiculo cadTipoVeiculo = new CadTipoVeiculo();
            cadTipoVeiculo.tipoVeiculoConsulta = tipoVeiculoSelecionado;
            cadTipoVeiculo.ShowDialog();
            carregarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
