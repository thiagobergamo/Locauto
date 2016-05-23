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

namespace LocAuto
{
    public partial class CadLocPj : Form
    {
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
            string msg;
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
            LocacaoDAO dao = new LocacaoDAO();
            msg = dao.Inserir(locacao);
            MessageBox.Show(msg);
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
    }
}
