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

        private void pessoaJuridícaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClienteJuridico cadClienteJuridico = new CadClienteJuridico();
            cadClienteJuridico.MdiParent = this;
            cadClienteJuridico.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoaFisícaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLocPf cadLocPf = new CadLocPf();
            cadLocPf.MdiParent = this;
            cadLocPf.Show();
        }

        private void pessoaJurídicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadLocPj cadLocPj = new CadLocPj();
            cadLocPj.MdiParent = this;
            cadLocPj.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuario cadUsuario = new CadUsuario();
            cadUsuario.MdiParent = this;
            cadUsuario.Show();
        }

        private void situaçãoDoVeículoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadSituacaoVeiculo cadSituacaoVeiculo = new CadSituacaoVeiculo();
            cadSituacaoVeiculo.MdiParent = this;
            cadSituacaoVeiculo.Show();
        }

        private void opcionaisLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadOpcional cadOpcional = new CadOpcional();
            cadOpcional.MdiParent = this;
            cadOpcional.Show();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClienteJuridico cadClienteJuridico = new CadClienteJuridico();
            cadClienteJuridico.MdiParent = this;
            cadClienteJuridico.Show();
        }

        private void cadastroVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVeiculo cadVeiculo = new CadVeiculo();
            cadVeiculo.MdiParent = this;
            cadVeiculo.Show();
        }

        private void grupoDoVeículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadTipoVeiculo cadTipoVeiculo = new CadTipoVeiculo();
            cadTipoVeiculo.MdiParent = this;
            cadTipoVeiculo.Show();
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_locacaoPf consulta_locacaoPf = new Consulta_locacaoPf();
            consulta_locacaoPf.MdiParent = this;
            consulta_locacaoPf.Show();
        }

        private void pessoaJurídicaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaLocacao consultaLocacao = new ConsultaLocacao();
            consultaLocacao.MdiParent = this;
            consultaLocacao.Show();
        }
    }
}
