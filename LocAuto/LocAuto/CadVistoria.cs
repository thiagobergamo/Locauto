using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LocAuto
{
    public partial class CadVistoria : Form
    {
        public int codLocacao { get; set; }
        public CadVistoria()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            String msg;
            Vistoria vistoria = new Vistoria();
            vistoria.CodigoLocacao = Convert.ToInt32(TxtCodigoLocacao.Text);
            vistoria.CodigoUsuario = Convert.ToInt32(TxtCodigoUsuario.SelectedValue.ToString());
            vistoria.KmLoc = Convert.ToInt32(TxtKmLoc.Text);
            vistoria.LaudoLoc = TxtLaudoLoc.Text;
            vistoria.NivelCombLoc = TxtNivelCombLoc.Text;
            


            if (TxtLaudoDev.Text == "")
            {
                VistoriaDAO vistoriaDAO = new VistoriaDAO();
                msg = vistoriaDAO.inserir(vistoria);
                TxtKmLoc.Text = "";
                TxtNivelCombLoc.Text = "";
                TxtNivelCombLoc.Text = "";
                MessageBox.Show(msg);
                this.Close();
            }
            else
            {
                vistoria.KmDev = Convert.ToInt32(TxtKmDev.Text);
                vistoria.NivelCombDev = TxtNivelCombDev.Text;
                vistoria.LaudoDev = TxtLaudoDev.Text;
                VistoriaDAO vistoriaDAO = new VistoriaDAO();
                msg = vistoriaDAO.atualizar(vistoria);
                MessageBox.Show(msg);
                this.Close();
            }



        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtKmLoc.Text = "";
            TxtNivelCombLoc.Text = "";
            TxtNivelCombLoc.Text = "";
        }

        private void CadVistoria_Load(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "select codigo, nome from usuario order by nome desc";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.TxtCodigoUsuario.DataSource = dtClientes;
            this.TxtCodigoUsuario.ValueMember = "codigo";
            this.TxtCodigoUsuario.DisplayMember = "nome";

            conn.Close();

            TxtCodigoLocacao.Text = codLocacao.ToString();

            Vistoria vistoria = new Vistoria();
            VistoriaDAO dao = new VistoriaDAO();
            vistoria = dao.Retornar(codLocacao);
            try
            {
                TxtKmLoc.Text = vistoria.KmLoc.ToString();
                TxtNivelCombLoc.Text = vistoria.NivelCombLoc.ToString();
                TxtLaudoLoc.Text = vistoria.LaudoLoc.ToString();
            }
            catch { }

        }
    }
}
