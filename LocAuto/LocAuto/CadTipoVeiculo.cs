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
    public partial class CadTipoVeiculo : Form
    {
        public CadTipoVeiculo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            String msg;
            TipoVeiculo tipoVeiculo = new TipoVeiculo();
            tipoVeiculo.Descricao = TxtGrupo.Text;
            tipoVeiculo.ArCondicionado = ChkArCondicionado.Checked.ToString();
            tipoVeiculo.VidroEletrico = ChkVidroEletrico.Checked.ToString();
            tipoVeiculo.TravaEletrica = ChkTravaEletrica.Checked.ToString();
            //tipoVeiculo.Portas = ChkPortas.Checked.ToString();
            tipoVeiculo.Abs = ChkAbs.Checked.ToString();
            tipoVeiculo.AirBag = ChkAirBag.Checked.ToString();
            tipoVeiculo.ValorDiaria = Convert.ToDecimal(TxtValorDiaria.Text);

            TipoVeiculoDAO tipoVeiculoDAO = new TipoVeiculoDAO();
            msg = tipoVeiculoDAO.inserir(tipoVeiculo);
            ChkArCondicionado.Checked = false;
            ChkVidroEletrico.Checked = false;
            ChkTravaEletrica.Checked = false;
            //ChkPortas.Checked = false;
            ChkAbs.Checked = false;
            ChkAirBag.Checked = false;
            TxtValorDiaria.Text = "";
            MessageBox.Show(msg);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtGrupo.Text = "";
            ChkArCondicionado.Checked = false;
            ChkVidroEletrico.Checked = false;
            ChkTravaEletrica.Checked = false;
            //ChkPortas.Checked = false;
            ChkAbs.Checked = false;
            ChkAirBag.Checked = false;
            TxtValorDiaria.Text = "";
        }
    }
}
