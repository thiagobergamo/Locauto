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
    public partial class CadLocPj : Form
    {
        public int idLocacao { get; set; }
        public CadLocPj()
        {
            InitializeComponent();
        }

        private void CadLocPj_Load(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select codigo_cliente, nome_fantasia from pessoa_juridica order by nome_fantasia desc";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.CbxNomeFantasia.DataSource = dtClientes;
            this.CbxNomeFantasia.ValueMember = "codigo_cliente";
            this.CbxNomeFantasia.DisplayMember = "nome_fantasia";

            conn.Close();

            conn.Open();

            mSQL = "select codigo, descricao from tipo_veiculo order by descricao";

            MySqlCommand cmd1 = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);

            DataTable dtTipoVeiculo = new DataTable();
            da1.Fill(dtTipoVeiculo);
            this.CbxGrupo.DataSource = dtTipoVeiculo;
            this.CbxGrupo.ValueMember = "codigo";
            this.CbxGrupo.DisplayMember = "descricao";

            conn.Close();

            conn.Open();

            mSQL = "select valor from opcional where codigo = 1";

            cmd = new MySqlCommand(mSQL, conn);
            label18.Text = "R$ " + cmd.ExecuteScalar().ToString();

            mSQL = "select valor from opcional where codigo = 2";

            cmd = new MySqlCommand(mSQL, conn);
            label19.Text = "R$ " + cmd.ExecuteScalar().ToString();

            mSQL = "select valor from opcional where codigo = 3";

            cmd = new MySqlCommand(mSQL, conn);
            label20.Text = "R$ " + cmd.ExecuteScalar().ToString();

            mSQL = "select valor from opcional where codigo = 4";

            cmd = new MySqlCommand(mSQL, conn);
            label21.Text = "R$ " + cmd.ExecuteScalar().ToString();

            mSQL = "select valor from opcional where codigo = 5";

            cmd = new MySqlCommand(mSQL, conn);
            label22.Text = "R$ " + cmd.ExecuteScalar().ToString();
            
            conn.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao();
            locacao.CodigoCliente = Convert.ToInt32(CbxNomeFantasia.SelectedValue.ToString());
            locacao.CodigoVeiculo = Convert.ToInt32(CbxPlaca.SelectedValue.ToString());
            locacao.DataLocacao = DtpDtLocacao.Value.ToString("yyyy-MM-dd");
            locacao.DataPrevDevolucao = DtpDtDevolucao.Value.ToString("yyyy-MM-dd");
            locacao.FormaPagamento = CbxFormaPagto.Text;
            locacao.ValorTotal = Convert.ToDecimal(TxtValorTotal.Text);
            locacao.ValorOpc = Convert.ToDecimal(TxtValorOpc.Text);
            locacao.ValorCaucao = Convert.ToDecimal(TxtValorCaucao.Text);
            locacao.Pago = Convert.ToInt32(ChkPago.Checked).ToString();
            LocacaoDAO locacaoDao = new LocacaoDAO();
            LocacaoService locacaoService = new LocacaoService(locacaoDao);
            try
            {
                locacaoService.inserir(locacao);
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            CbxFormaPagto.Text = "";
            TxtValorTotal.Text = "";
            TxtValorOpc.Text = "";
            TxtValorCaucao.Text = "";
            ChkPago.Checked = false;
        }

        private void CbxNomeFantasia_Validated(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            PessoaJuridicaDAO pessoaJuridicaDao = new PessoaJuridicaDAO();
            pessoaJuridica = pessoaJuridicaDao.Retornar(Convert.ToInt32(CbxNomeFantasia.SelectedValue));
            TxtCodigo.Text = pessoaJuridica.Codigo.ToString();
            TxtCnh.Text = pessoaJuridica.Cnh.ToString();
            TxtEmail.Text = pessoaJuridica.Email;
            TxtNomeCondutor.Text = pessoaJuridica.NomeCondutor;
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            String mSQL;

            conn = cf.ObterConexao();

            conn.Open();
            mSQL = "select telefone from telefone_cliente where codigo_cliente = @codigo and codigo_tipo_telefone = 1 limit 1";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            cmd.Parameters.Add(new MySqlParameter("codigo", CbxNomeFantasia.SelectedValue.ToString()));


            try
            {
                TxtNumero.Text = cmd.ExecuteScalar().ToString();
            }
            catch { }


            conn.Close();
            CbxGrupo.Focus();
        }

        private void ChkCoberturaCarro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkAssentoElevacao_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAssentoElevacao.Checked == true)
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) + Convert.ToDouble(label18.Text.Replace("R$", ""))).ToString();
            }
            else
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) - Convert.ToDouble(label18.Text.Replace("R$", ""))).ToString();
            }
        }

        private void ChkCadeiraBebe_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCadeiraBebe.Checked == true)
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) + Convert.ToDouble(label19.Text.Replace("R$", ""))).ToString();
            }
            else
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) - Convert.ToDouble(label19.Text.Replace("R$", ""))).ToString();
            }
        }

        private void ChkCoberturaCarro_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ChkCoberturaCarro.Checked == true)
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) + Convert.ToDouble(label20.Text.Replace("R$", ""))).ToString();
            }
            else
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) - Convert.ToDouble(label20.Text.Replace("R$", ""))).ToString();
            }
        }

        private void ChkCoberturaTerceiros_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCoberturaTerceiros.Checked == true)
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) + Convert.ToDouble(label21.Text.Replace("R$", ""))).ToString();
            }
            else
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) - Convert.ToDouble(label21.Text.Replace("R$", ""))).ToString();
            }
        }

        private void ChkNavegadorGps_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNavegadorGps.Checked == true)
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) + Convert.ToDouble(label22.Text.Replace("R$", ""))).ToString();
            }
            else
            {
                TxtValorOpc.Text = (Convert.ToDouble(TxtValorOpc.Text) - Convert.ToDouble(label22.Text.Replace("R$", ""))).ToString();
            }
        }

        private void DtpDtDevolucao_Validated(object sender, EventArgs e)
        {
            DateTime diaLoc = DtpDtLocacao.Value.Date;
            DateTime diaDev = DtpDtDevolucao.Value.Date;


            TimeSpan dias = diaDev - diaLoc;

            double totDias = dias.TotalDays;

            double num = 10 * totDias;

            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select valor_diaria from tipo_veiculo where codigo = @grupo";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            cmd.Parameters.Add(new MySqlParameter("grupo", CbxGrupo.SelectedValue.ToString()));

            double valorDiarias = Convert.ToDouble(cmd.ExecuteScalar()) * totDias;
            TxtValorDiaria.Text = valorDiarias.ToString();
            conn.Close();
        }

        private void CbxGrupo_Validated(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select  min(codigo) codigo_veiculo, concat_ws(' - ',marca, modelo, cor) modelos from veiculo where codigo_tipo_veiculo = @grupo group by marca, modelo, cor";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            cmd.Parameters.Add(new MySqlParameter("grupo", CbxGrupo.SelectedValue.ToString()));
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.CbxVeiculo.DataSource = dtClientes;
            this.CbxVeiculo.ValueMember = "codigo_veiculo";
            this.CbxVeiculo.DisplayMember = "modelos";

            conn.Close();
        }

        private void CbxVeiculo_Validated(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select codigo, placa  from veiculo where marca = (select marca from veiculo where codigo = @codigo) and modelo = (select modelo from veiculo where codigo = @codigo) and cor = (select cor from veiculo where codigo = @codigo)";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            cmd.Parameters.Add(new MySqlParameter("codigo", CbxVeiculo.SelectedValue.ToString()));
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.CbxPlaca.DataSource = dtClientes;
            this.CbxPlaca.ValueMember = "codigo";
            this.CbxPlaca.DisplayMember = "placa";

            conn.Close();
        }

        private void TxtValorDiaria_TextChanged(object sender, EventArgs e)
        {
            TxtValorTotal.Text = (Convert.ToDouble(TxtValorDiaria.Text) + Convert.ToDouble(TxtValorOpc.Text)).ToString();
        }

        private void TxtValorOpc_TextChanged(object sender, EventArgs e)
        {
            TxtValorTotal.Text = (Convert.ToDouble(TxtValorDiaria.Text) + Convert.ToDouble(TxtValorOpc.Text)).ToString();
        }

        private void BtnVistoria_Click(object sender, EventArgs e)
        {
            CadVistoria cadVistoria = new CadVistoria();
            cadVistoria.codLocacao = idLocacao;
            cadVistoria.Show();
        }
    }
}
