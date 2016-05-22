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
            String msg;

            pessoaJuridica.RazaoSocial = TxtRazSocial.Text;
            pessoaJuridica.InscEstadual = TxtInsc.Text;
            pessoaJuridica.Cnpj = MskCnpj.Text;
            pessoaJuridica.NomeFantasia = TxtNomFantasia.Text;
            pessoaJuridica.Email = TxtEmail.Text;
            pessoaJuridica.Contato = TxtContato.Text;
            pessoaJuridica.Logradouro = TxtEndereco.Text;
            pessoaJuridica.Numero = Convert.ToInt32(TxtNumero);
            pessoaJuridica.Bairro = TxtBairro.Text;
            pessoaJuridica.Complemento = TxtComplemento.Text;
            pessoaJuridica.Cep = MskCep.Text;
            pessoaJuridica.Cidade = TxtCidade.Text;
            pessoaJuridica.Estado = CmbEstado.Text;
            pessoaJuridica.Cnh = TxtCnh.Text;
            pessoaJuridica.ValidadeCnh = MskValCnh.Text;
            pessoaJuridica.NomeCondutor = TxtNomCodutor.Text;
            pessoaJuridica.SenhaWeb = TxtSenha.Text;
            pessoaJuridica.LoginWeb = TxtLogin.Text;


            PessoaJuridicaDAO dao = new PessoaJuridicaDAO();
            msg = dao.inserir(pessoaJuridica);
            MessageBox.Show(msg);

        }
    }
}
