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

            SituacaoVeiculoDAO situacaoVeiculoDAO = new SituacaoVeiculoDAO();
            situacaoVeiculoDAO.inserir(situacaoVeiculo);
            TxtDescricao.Text = "";

            SituacaoVeiculoService situacaoVeiculoService = new SituacaoVeiculoService(situacaoVeiculoDAO);
            try
            {
                situacaoVeiculoService.inserir(situacaoVeiculo);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Mensagem");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
