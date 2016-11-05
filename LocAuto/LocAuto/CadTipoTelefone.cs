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
    public partial class CadTipoTelefone : Form
    {
        public CadTipoTelefone()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }

        private void LimparTxt()
        {
            TxtDescricao.Text = "";
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TipoTelefone tipoTelefone = new TipoTelefone();
            TipoTelefoneDAO dao = new TipoTelefoneDAO();
            TipoTelefoneService tipoTelefoneService = new TipoTelefoneService(dao);

            tipoTelefone.Descricao = TxtDescricao.Text;
            
            try
            {
                tipoTelefoneService.inserir(tipoTelefone);
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
    }
}
