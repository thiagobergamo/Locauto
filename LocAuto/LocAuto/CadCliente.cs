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
    public partial class CadClienteFisica : Form
    {
        public CadClienteFisica()
        {
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {

        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

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
            pessoaFisica.DtNascimento = MskDtNascimento.Text;
            pessoaFisica.Logradouro = TxtLogradouro.Text;
            pessoaFisica.Numero = Convert.ToInt32 (IntNumero.Text);
            pessoaFisica.Complemento = TxtComplemento.Text;
            pessoaFisica.Bairro = TxtBairro.Text;
            pessoaFisica.Cep = MskCep.Text;
            pessoaFisica.Cidade = TxtCidade.Text;
            pessoaFisica.Estado = CmbEstado.Text;
            pessoaFisica.Codigo = Convert.ToInt32(TxtCodigo.Text);
            pessoaFisica.Rg = TxtRg.Text;
            pessoaFisica.Cnh = TxtCnh.Text;
            pessoaFisica.ValidadeCnh = MskValCnh.Text;
            pessoaFisica.Cpf = MskCpf.Text;
            pessoaFisica.OutroDocumento = TxtOutDocumento.Text;
            pessoaFisica.LoginWeb = TxtLoginWeb.Text;
            pessoaFisica.SenhaWeb = TxtSenha.Text;
            PessoaFisicaDAO dao = new PessoaFisicaDAO();
            msg = dao.inserir(pessoaFisica);
            MessageBox.Show(msg);
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
