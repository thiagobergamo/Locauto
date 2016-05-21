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
            String msg;
            TipoTelefone tipoTelefone = new TipoTelefone();
            tipoTelefone.Descricao = TxtDescricao.Text;
            TipoTelefoneDAO dao = new TipoTelefoneDAO();
            msg = dao.inserir(tipoTelefone);
            TxtDescricao.Text = "";
            MessageBox.Show(msg);

        }
    }
}
