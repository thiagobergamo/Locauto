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

namespace LocAuto
{
    public partial class CadClienteFisica : Form
    {
        public PessoaFisica pessoaFisicaConsulta { get; set; }

        public CadClienteFisica()
        {
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            CmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
                
            CarregarTiposTelefone();
            if (pessoaFisicaConsulta != null)
            {
                TxtCodigo.Text = pessoaFisicaConsulta.Codigo.ToString();
                TxtNome.Text = pessoaFisicaConsulta.Nome;
                MskDtNascimento.Text = pessoaFisicaConsulta.DtNascimento.ToString();
                TxtEmail.Text = pessoaFisicaConsulta.Email;
                TxtLog.Text = pessoaFisicaConsulta.Logradouro;
                TxtNum.Text = pessoaFisicaConsulta.Numero.ToString();
                TxtComplemento.Text = pessoaFisicaConsulta.Complemento;
                TxtBairro.Text = pessoaFisicaConsulta.Bairro;
                CmbEstado.Text = pessoaFisicaConsulta.Estado;
                TxtCidade.Text = pessoaFisicaConsulta.Cidade;
                MskCep.Text = pessoaFisicaConsulta.Cep;
                TxtRg.Text = pessoaFisicaConsulta.Rg;
                TxtCnh.Text = pessoaFisicaConsulta.Cnh;
                MskValCnh.Text = pessoaFisicaConsulta.ValidadeCnh.ToString();
                MskCpf.Text = pessoaFisicaConsulta.Cpf;
                TxtOutDocumento.Text = pessoaFisicaConsulta.OutroDocumento;
                TxtLoginWeb.Text = pessoaFisicaConsulta.LoginWeb;
                TxtSenha.Text = pessoaFisicaConsulta.SenhaWeb;

                dataGridView1.Rows.Clear();
                foreach (TelefoneCliente p in pessoaFisicaConsulta.Telefones)
                {
                    int index = dataGridView1.Rows.Add();
                    DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                    linhaTabela.Cells["Tipo"].Value = p.Tipo;
                    linhaTabela.Cells["numero"].Value = p.Numero;
                }

            }
            TxtNome.Focus();
        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void CarregarTiposTelefone()
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }

        public void LimparTxt()
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
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaFisicaDAO pessoaFisicaDao = new PessoaFisicaDAO();
            PessoaFisicaService pessoaFisicaService = new PessoaFisicaService(pessoaFisicaDao);

            if (!String.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                pessoaFisica.Codigo = Convert.ToInt32(TxtCodigo.Text);
            }
            pessoaFisica.Nome = TxtNome.Text;
            pessoaFisica.Email = TxtEmail.Text;
            pessoaFisica.DtNascimento = MskDtNascimento.Value.ToString("yyyy-MM-dd");
            pessoaFisica.Logradouro = TxtLog.Text;
            if (!String.IsNullOrWhiteSpace(TxtNum.Text))
            {
                pessoaFisica.Numero = Convert.ToInt32(TxtNum.Text);
            }            
            pessoaFisica.Complemento = TxtComplemento.Text;
            pessoaFisica.Bairro = TxtBairro.Text;
            pessoaFisica.Cep = MskCep.Text;
            pessoaFisica.Cidade = TxtCidade.Text;
            pessoaFisica.Estado = CmbEstado.Text;
            pessoaFisica.Rg = TxtRg.Text;
            pessoaFisica.Cnh = TxtCnh.Text;
            pessoaFisica.ValidadeCnh = MskValCnh.Value.ToString("yyyy-MM-dd");
            pessoaFisica.Cpf = MskCpf.Text;
            pessoaFisica.OutroDocumento = TxtOutDocumento.Text;
            pessoaFisica.LoginWeb = TxtLoginWeb.Text;
            pessoaFisica.SenhaWeb = TxtSenha.Text;            

            List<TelefoneCliente> telefones = new List<TelefoneCliente>();
            foreach(DataGridViewRow linha in this.dataGridView1.Rows)
            {
                if (linha.Cells["Tipo"].Value != null)
                {
                    telefones.Add(new TelefoneCliente() { Tipo = Convert.ToInt32(linha.Cells["Tipo"].Value), Numero = linha.Cells["numero"].Value.ToString() });
                }
            }
            
            try
            {
                if (pessoaFisica.Codigo == 0)
                {
                    pessoaFisicaService.inserir(pessoaFisica, telefones);
                }else
                {
                    pessoaFisicaService.atualizar(pessoaFisica, telefones);
                }
                
                MessageBox.Show("Cadastro salvo com sucesso!");
                this.Close();
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
