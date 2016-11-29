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
        public Opcional opcionalConsulta { get; set; }

        public CadOpcional()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            
            Opcional opcional = new Opcional();
            OpcionalDAO opcionalDao = new OpcionalDAO();
            OpcionalService opcionalService = new OpcionalService(opcionalDao);

            if (!String.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                opcional.Codigo = Convert.ToInt32(TxtCodigo.Text);
            }
            opcional.Descricao = TxtDescricao.Text;
            if (!String.IsNullOrWhiteSpace(TxtValor.Text)){
                opcional.Valor = Convert.ToDecimal(TxtValor.Text);
            }
            
            try{
                
                if(opcional.Codigo == 0)
                {
                    opcionalService.inserir(opcional);
                }
                else
                {
                    opcionalService.atualizar(opcional);
                }
                MessageBox.Show("Cadastro salvo com sucesso!");
                this.Close();
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

        private void CadOpcional_Load(object sender, EventArgs e)
        {
            if (opcionalConsulta != null)
            {
                TxtCodigo.Text = opcionalConsulta.Codigo.ToString();
                TxtDescricao.Text = opcionalConsulta.Descricao;
                TxtValor.Text = opcionalConsulta.Valor.ToString();
            }
        }
    }
}
