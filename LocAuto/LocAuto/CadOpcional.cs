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
    public partial class CadOpcional : Form
    {
        public CadOpcional()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            String msg;
            Opcional opcional = new Opcional();
            opcional.Descricao = TxtDescricao.Text;
            opcional.Valor = Convert.ToDecimal(TxtValor.Text);

            OpcionalDAO opcionalDAO = new OpcionalDAO();
            msg = opcionalDAO.inserir(opcional);
            TxtDescricao.Text = "";
            TxtValor.Text = "";
            MessageBox.Show(msg);
        }
    }
}
