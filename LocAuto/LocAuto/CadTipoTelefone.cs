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

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //String msg;
            TipoTelefone tipoTelefone = new TipoTelefone();
            tipoTelefone.Descricao = TxtDescricao.Text;

            TipoTelefoneDAO dao = new TipoTelefoneDAO();

            dao.inserir(tipoTelefone);
            TxtDescricao.Text = "";
            TipoTelefoneService tipoTelefoneService = new TipoTelefoneService(dao);
            try
            {
                tipoTelefoneService.inserir(tipoTelefone);
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
