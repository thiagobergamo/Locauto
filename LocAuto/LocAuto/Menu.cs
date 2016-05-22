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
            CadClienteFisica cadClienteFisica = new CadClienteFisica();
            cadClienteFisica.MdiParent = this;
            cadClienteFisica.Show();
        }

        private void tipoDeTelefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadTipoTelefone cadTipoTelefone = new CadTipoTelefone();
            cadTipoTelefone.MdiParent = this;
            cadTipoTelefone.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClienteFisica cadClienteFisica = new CadClienteFisica();
            cadClienteFisica.MdiParent = this;
            cadClienteFisica.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
