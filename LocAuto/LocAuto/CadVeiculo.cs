using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DaoMysql;
using Modelo;
using Services;
using DaoInterface;

namespace LocAuto
{
    public partial class CadVeiculo : Form
    {
        public CadVeiculo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            VeiculoDAO veiculoDao = new VeiculoDAO();
            VeiculoService veiculoService = new VeiculoService(veiculoDao);

            if (!String.IsNullOrWhiteSpace(CmbGrupo.Text))
            {
                veiculo.codigoTipoVeiculo = Convert.ToInt32(CmbGrupo.SelectedValue.ToString());
            }
            //veiculo.codigoTipoVeiculo = CmbGrupo.SelectedValue.ToString();
            if (!String.IsNullOrWhiteSpace(CmbSituacao.Text))
            {
                veiculo.codigoSituacaoVeiculo = Convert.ToInt32(CmbSituacao.SelectedValue.ToString());
            }
            //veiculo.codigoSituacaoVeiculo = CmbSituacao.SelectedValue.ToString();
            veiculo.Marca = TxtMarca.Text;
            veiculo.Modelo = TxtModelo.Text;
            if (!String.IsNullOrWhiteSpace(TxtAno.Text))
            {
                veiculo.Ano = Convert.ToInt32(TxtAno.Text);
            }
            veiculo.Placa = TxtPlaca.Text;
            veiculo.Chassi = TxtChassi.Text;
            veiculo.Cor = TxtCor.Text;
            veiculo.Observacao = TxtObs.Text;
            
            try
            {
                veiculoService.inserir(veiculo);
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

        private void CadVeiculo_Load(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select codigo, descricao from tipo_veiculo order by descricao";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.CmbGrupo.DataSource = dtClientes;
            this.CmbGrupo.ValueMember = "codigo";
            this.CmbGrupo.DisplayMember = "descricao";

            conn.Close();

            conn.Open();

            mSQL = "select codigo, descricao from situacao_veiculo";

            MySqlCommand cmd1 = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);

            DataTable dtSituacao = new DataTable();
            da1.Fill(dtSituacao);
            this.CmbSituacao.DataSource = dtSituacao;
            this.CmbSituacao.ValueMember = "codigo";
            this.CmbSituacao.DisplayMember = "descricao";

            conn.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }
        private void LimparTxt()
        {
            TxtMarca.Text = "";
            TxtModelo.Text = "";
            TxtAno.Text = "";
            TxtPlaca.Text = "";
            TxtChassi.Text = "";
            TxtCor.Text = "";
            TxtObs.Text = "";
        }
    }
}
