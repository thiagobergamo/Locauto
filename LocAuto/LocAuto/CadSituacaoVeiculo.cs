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
        public SituacaoVeiculo situacaoVeiculoConsulta { get; set; }

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

            if (!String.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                situacaoVeiculo.Codigo = Convert.ToInt32(TxtCodigo.Text);
            }
            situacaoVeiculo.Descricao = TxtDescricao.Text;            
            
            try
            {
                if(situacaoVeiculo.Codigo == 0)
                {
                    situacaoVeiculoService.inserir(situacaoVeiculo);
                }
                else
                {
                    situacaoVeiculoService.atualizar(situacaoVeiculo);
                }                
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
            if (situacaoVeiculoConsulta != null)
            {
                TxtCodigo.Text = situacaoVeiculoConsulta.Codigo.ToString();
                TxtDescricao.Text = situacaoVeiculoConsulta.Descricao;
            }
        }
    }
}
