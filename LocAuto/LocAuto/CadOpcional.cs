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
            
            Modelo.Opcional opcional = new Modelo.Opcional();
            opcional.Descricao = TxtDescricao.Text;
            opcional.Valor = Convert.ToDecimal(TxtValor.Text);
            DaoMysql.OpcionalDAO opcionalDao = new DaoMysql.OpcionalDAO();
            OpcionalService opcionalService = new OpcionalService(opcionalDao);
            try{
                opcionalService.inserir(opcional);
                MessageBox.Show("Cadastro realizado com sucesso!");
            } catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Mensagem");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtDescricao.Text = "";
            TxtValor.Text = "";
        }
    }
}
