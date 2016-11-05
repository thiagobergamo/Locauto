using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaoMysql;
using Modelo;
using Services;
using DaoInterface;

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
            
            Opcional opcional = new Opcional();
            OpcionalDAO opcionalDao = new OpcionalDAO();
            OpcionalService opcionalService = new OpcionalService(opcionalDao);

            opcional.Descricao = TxtDescricao.Text;
            if (!String.IsNullOrWhiteSpace(TxtValor.Text)){
                opcional.Valor = Convert.ToDecimal(TxtValor.Text);
            }
            
            try{
                opcionalService.inserir(opcional);
                LimparTxt();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Mensagem");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }

        private void LimparTxt()
        {
            TxtDescricao.Text = "";
            TxtValor.Text = "";
        }
    }
}
