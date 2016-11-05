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
            LimparTxt();
        }

        private void LimparTxt()
        {
            TxtDescricao.Text = "";
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoVeiculo situacaoVeiculo = new SituacaoVeiculo();
            SituacaoVeiculoDAO situacaoVeiculoDAO = new SituacaoVeiculoDAO();
            SituacaoVeiculoService situacaoVeiculoService = new SituacaoVeiculoService(situacaoVeiculoDAO);

            situacaoVeiculo.Descricao = TxtDescricao.Text;            
            
            try
            {
                situacaoVeiculoService.inserir(situacaoVeiculo);
                LimparTxt();
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

        private void CadSituacaoVeiculo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
