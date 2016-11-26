using System;
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
    public partial class ConsultaOpcional : Form
    {
        public ConsultaOpcional()
        {
            InitializeComponent();
        }

        private void ConsultaOpcional_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            OpcionalDAO dao = new OpcionalDAO();
            OpcionalService service = new OpcionalService(dao);
            List<Opcional> listaOpcional = new List<Opcional>();
            listaOpcional = service.buscaTodos();
            dataGridView1.Rows.Clear();
            foreach (Opcional t in listaOpcional)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = t.Codigo;
                linhaTabela.Cells["descricao"].Value = t.Descricao;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadOpcional cadOpcional = new CadOpcional();
            cadOpcional.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            OpcionalDAO dao = new OpcionalDAO();
            OpcionalService service = new OpcionalService(dao);
            dao.apagar(idSelecionado);
            MessageBox.Show("Opcional apagado com sucesso");
            carregarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            Opcional opcionalSelecionado;
            OpcionalDAO dao = new OpcionalDAO();
            OpcionalService service = new OpcionalService(dao);
            opcionalSelecionado = service.buscaPorId(idSelecionado);

            CadOpcional cadOpcional = new CadOpcional();
            cadOpcional.opcionalConsulta = opcionalSelecionado;
            cadOpcional.Show();
        }
    }
}
