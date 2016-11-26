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
    }
}
