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
    public partial class CadClienteFisica : Form
    {
        public CadClienteFisica()
        {
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select codigo, descricao from tipo_telefone order by descricao";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.Tipo.DataSource = dtClientes;
            this.Tipo.ValueMember = "codigo";
            this.Tipo.DisplayMember = "descricao";

            conn.Close();

            TxtNome.Focus();
        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtEmail.Text = "";
            MskDtNascimento.Text = "";
            TxtLog.Text = "";
            TxtNum.Text = "";
            TxtComplemento.Text = "";
            TxtBairro.Text = "";
            MskCep.Text = "";
            TxtCidade.Text = "";
            CmbEstado.Text = "";
            TxtRg.Text = "";
            TxtCnh.Text = "";
            MskValCnh.Text = "";
            MskCpf.Text = "";
            TxtOutDocumento.Text = "";
            TxtLoginWeb.Text = "";
            TxtSenha.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            String msg;

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = TxtNome.Text;
            pessoaFisica.Email = TxtEmail.Text;
            pessoaFisica.DtNascimento = MskDtNascimento.Value.ToString("yyyy-MM-dd");
            pessoaFisica.Logradouro = TxtLog.Text;
            pessoaFisica.Numero = Convert.ToInt32 (TxtNum.Text);
            pessoaFisica.Complemento = TxtComplemento.Text;
            pessoaFisica.Bairro = TxtBairro.Text;
            pessoaFisica.Cep = MskCep.Text;
            pessoaFisica.Cidade = TxtCidade.Text;
            pessoaFisica.Estado = CmbEstado.Text;
            //pessoaFisica.Codigo = Convert.ToInt32(TxtCodigo.Text);
            pessoaFisica.Rg = TxtRg.Text;
            pessoaFisica.Cnh = TxtCnh.Text;
            pessoaFisica.ValidadeCnh = MskValCnh.Value.ToString("yyyy-MM-dd");
            pessoaFisica.Cpf = MskCpf.Text;
            pessoaFisica.OutroDocumento = TxtOutDocumento.Text;
            pessoaFisica.LoginWeb = TxtLoginWeb.Text;
            pessoaFisica.SenhaWeb = TxtSenha.Text;
            PessoaFisicaDAO dao = new PessoaFisicaDAO();

            List<TelefoneCliente> telefones = new List<TelefoneCliente>();
            foreach(DataGridViewRow linha in this.dataGridView1.Rows)
            {
                if (linha.Cells["Tipo"].Value != null)
                {
                    telefones.Add(new TelefoneCliente() { Tipo = Convert.ToInt32(linha.Cells["Tipo"].Value), Numero = linha.Cells["numero"].Value.ToString() });
                }
            }
             
            msg = dao.inserir(pessoaFisica, telefones);

            MessageBox.Show(msg);
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void CEP_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
