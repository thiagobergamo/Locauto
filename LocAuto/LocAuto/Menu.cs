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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliPf cadCliPf = new CadCliPf("teste param");
            cadCliPf.Show();
        }

        private void tipoDeTelefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadTipoTelefone cadTipoTelefone = new CadTipoTelefone();
            cadTipoTelefone.MdiParent = this;
            cadTipoTelefone.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuario cadUsuario = new CadUsuario();
            cadUsuario.MdiParent = this;
            cadUsuario.Show();
        }
    }
}
