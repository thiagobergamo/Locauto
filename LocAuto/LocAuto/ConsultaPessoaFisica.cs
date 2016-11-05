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
            dataGridView1.DataSource = pessoaFisicaService.buscarTodos();
        }
    }
}
