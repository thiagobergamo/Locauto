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
    public partial class ConsultaTipoTelefone : Form
    {
        public ConsultaTipoTelefone()
        {
            InitializeComponent();
        }

        private void ConsultaTipoTelefone_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            TipoTelefoneDAO dao = new TipoTelefoneDAO();
            TipoTelefoneService service = new TipoTelefoneService(dao);
            List<TipoTelefone> listaTipoTelefone = new List<TipoTelefone>();
            listaTipoTelefone = service.buscaTodos();
            dataGridView1.Rows.Clear();
            foreach (TipoTelefone t in listaTipoTelefone)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = t.Codigo;
                linhaTabela.Cells["descricao"].Value = t.Descricao;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadTipoTelefone cadTipoTelefone = new CadTipoTelefone();
            cadTipoTelefone.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            TipoTelefoneDAO dao = new TipoTelefoneDAO();
            TipoTelefoneService service = new TipoTelefoneService(dao);

            dao.apagar(idSelecionado);

            MessageBox.Show("Tipo de Telefone apagado com sucesso");
            carregarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            TipoTelefone tipoTelefoneSelecionado;
            TipoTelefoneDAO dao = new TipoTelefoneDAO();
            TipoTelefoneService service = new TipoTelefoneService(dao);
            tipoTelefoneSelecionado = service.buscaPorId(idSelecionado);

            CadTipoTelefone cadTipoTelefone = new CadTipoTelefone();
            cadTipoTelefone.tipoTelefoneConsulta = tipoTelefoneSelecionado;
            cadTipoTelefone.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
