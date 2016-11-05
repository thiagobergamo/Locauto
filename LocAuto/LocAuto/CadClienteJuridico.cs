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
using Modelo;
using DaoMysql;
using Services;

namespace LocAuto
{
    public partial class CadClienteJuridico : Form
    {
        public CadClienteJuridico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtInsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            PessoaJuridicaDAO dao = new PessoaJuridicaDAO();
            PessoaJuridicaService pessoaJuridicaService = new PessoaJuridicaService(dao);

            pessoaJuridica.RazaoSocial = TxtRazSocial.Text;
            pessoaJuridica.InscEstadual = TxtInsc.Text;
            pessoaJuridica.Cnpj = MskCnpj.Text;
            pessoaJuridica.NomeFantasia = TxtNomFantasia.Text;
            pessoaJuridica.Email = TxtEmail.Text;
            pessoaJuridica.Contato = TxtContato.Text;
            pessoaJuridica.Logradouro = TxtEndereco.Text;
            pessoaJuridica.Numero = Convert.ToInt32(TxtNumero.Text);
            pessoaJuridica.Bairro = TxtBairro.Text;
            pessoaJuridica.Complemento = TxtComplemento.Text;
            pessoaJuridica.Cep = MskCep.Text;
            pessoaJuridica.Cidade = TxtCidade.Text;
            pessoaJuridica.Estado = CmbEstado.Text;
            pessoaJuridica.Cnh = TxtCnh.Text;
            pessoaJuridica.ValidadeCnh = MskValCnh.Value.ToString("yyyy-MM-dd"); ;
            pessoaJuridica.NomeCondutor = TxtNomCodutor.Text;
            pessoaJuridica.SenhaWeb = TxtSenha.Text;
            pessoaJuridica.LoginWeb = TxtLogin.Text;

            List<TelefoneCliente> telefones = new List<TelefoneCliente>();
            foreach (DataGridViewRow linha in this.dataGridView1.Rows)
            {
                if (linha.Cells["Tipo"].Value != null)
                {
                    telefones.Add(new TelefoneCliente() { Tipo = Convert.ToInt32(linha.Cells["Tipo"].Value), Numero = linha.Cells["numero"].Value.ToString() });
                }
            }            
            
            try
            {
                pessoaJuridicaService.inserir(pessoaJuridica, telefones);
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



        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }
        private void LimparTxt()
        {
            TxtRazSocial.Text = "";
            TxtInsc.Text = "";
            MskCnpj.Text = "";
            TxtNomFantasia.Text = "";
            TxtEmail.Text = "";
            TxtContato.Text = "";
            TxtEndereco.Text = "";
            TxtNumero.Text = "";
            TxtBairro.Text = "";
            TxtComplemento.Text = "";
            MskCep.Text = "";
            TxtCidade.Text = "";
            CmbEstado.Text = "";
            TxtCnh.Text = "";
            MskValCnh.Text = "";
            TxtNomCodutor.Text = "";
            TxtSenha.Text = "";
            TxtLogin.Text = "";
        }

        private void CadClienteJuridico_Load(object sender, EventArgs e)
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
        }
    }
}
