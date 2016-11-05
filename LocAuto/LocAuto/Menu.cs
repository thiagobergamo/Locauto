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
            cadClienteFisica.DesktopLocation = new Point(550, 100);
            cadClienteFisica.Show();
        }

       

        private void tipoDeTelefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadTipoTelefone cadTipoTelefone = new CadTipoTelefone();
            cadTipoTelefone.MdiParent = this;
            cadTipoTelefone.DesktopLocation = new Point(550, 100);
            cadTipoTelefone.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CadClienteFisica cadClienteFisica = new CadClienteFisica();
            //cadClienteFisica.MdiParent = this;
            //cadClienteFisica.DesktopLocation = new Point(550, 100);
            //cadClienteFisica.Show();
            ConsultaPessoaFisica consultaPessoaFisica = new ConsultaPessoaFisica();
            consultaPessoaFisica.MdiParent = this;
            consultaPessoaFisica.DesktopLocation = new Point(550, 100);
            consultaPessoaFisica.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void pessoaJuridícaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClienteJuridico cadClienteJuridico = new CadClienteJuridico();
            cadClienteJuridico.MdiParent = this;
            cadClienteJuridico.DesktopLocation = new Point(550, 100);
            cadClienteJuridico.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoaFisícaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLocPf cadLocPf = new CadLocPf();
            cadLocPf.MdiParent = this;
            cadLocPf.DesktopLocation = new Point(550, 100);
            cadLocPf.Show();
        }

        private void pessoaJurídicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadLocPj cadLocPj = new CadLocPj();
            cadLocPj.MdiParent = this;
            cadLocPj.DesktopLocation = new Point(550, 100);
            cadLocPj.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuario cadUsuario = new CadUsuario();
            cadUsuario.MdiParent = this;
            cadUsuario.DesktopLocation = new Point(550, 100);
            cadUsuario.Show();
        }

        private void situaçãoDoVeículoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadSituacaoVeiculo cadSituacaoVeiculo = new CadSituacaoVeiculo();
            cadSituacaoVeiculo.MdiParent = this;
            cadSituacaoVeiculo.DesktopLocation = new Point(550, 100);
            cadSituacaoVeiculo.Show();
        }

        private void opcionaisLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadOpcional cadOpcional = new CadOpcional();
            cadOpcional.MdiParent = this;
            cadOpcional.DesktopLocation = new Point(550, 100);
            cadOpcional.Show();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClienteJuridico cadClienteJuridico = new CadClienteJuridico();
            cadClienteJuridico.MdiParent = this;
            cadClienteJuridico.DesktopLocation = new Point(550, 100);
            cadClienteJuridico.Show();
        }

        private void cadastroVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVeiculo cadVeiculo = new CadVeiculo();
            cadVeiculo.MdiParent = this;
            cadVeiculo.DesktopLocation = new Point(550, 100);
            cadVeiculo.Show();
        }

        private void grupoDoVeículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadTipoVeiculo cadTipoVeiculo = new CadTipoVeiculo();
            cadTipoVeiculo.MdiParent = this;
            cadTipoVeiculo.DesktopLocation = new Point(550, 100);
            cadTipoVeiculo.Show();
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_locacaoPf consulta_locacaoPf = new Consulta_locacaoPf();
            consulta_locacaoPf.MdiParent = this;
            consulta_locacaoPf.DesktopLocation = new Point(550, 100);
            consulta_locacaoPf.Show();
        }

        private void pessoaJurídicaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaLocacao consultaLocacao = new ConsultaLocacao();
            consultaLocacao.MdiParent = this;
            consultaLocacao.DesktopLocation = new Point(550, 100);
            consultaLocacao.Show();
        }             
    }
}
