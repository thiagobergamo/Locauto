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
    public partial class CadSituacaoVeiculo : Form
    {
        public CadSituacaoVeiculo()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtDescricao.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            String msg;
            SituacaoVeiculo situacaoVeiculo = new SituacaoVeiculo();
            situacaoVeiculo.Descricao = TxtDescricao.Text;

            SituacaoVeiculo1DAO situacaoVeiculoDAO = new SituacaoVeiculo1DAO();
            msg = situacaoVeiculoDAO.inserir(situacaoVeiculo);
            TxtDescricao.Text = "";
            MessageBox.Show(msg);
        }
    }
}
