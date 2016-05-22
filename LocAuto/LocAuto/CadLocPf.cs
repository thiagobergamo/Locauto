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
    public partial class CadLocPf : Form
    {
        public CadLocPf()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadLocPf_Load(object sender, EventArgs e)
        {
            ConnectionFactory cf = new ConnectionFactory();
            MySqlConnection conn;
            conn = cf.ObterConexao();

            conn.Open();

            string mSQL = "Select codigo_cliente, nome from pessoa_fisica order by nome";

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtClientes = new DataTable();
            da.Fill(dtClientes);
            this.CbxNome.DataSource = dtClientes;
            this.CbxNome.ValueMember = "codigo_cliente";
            this.CbxNome.DisplayMember = "nome";

            conn.Close();

            conn.Open();

            mSQL = "select codigo, descricao from tipo_veiculo order by descricao";

            MySqlCommand cmd1 = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);

            DataTable dtTipoVeiculo = new DataTable();
            da1.Fill(dtTipoVeiculo);
            this.CbxGrupo.DataSource = dtTipoVeiculo;
            this.CbxGrupo.ValueMember = "codigo";
            this.CbxGrupo.DisplayMember = "descricao";

            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CbxNome_Validated(object sender, EventArgs e)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaFisicaDAO pessoaFisicaDao = new PessoaFisicaDAO();
            pessoaFisica = pessoaFisicaDao.Retornar(Convert.ToInt32(CbxNome.SelectedValue));
            TxtCodigo.Text = pessoaFisica.Codigo.ToString();
            TxtCnh.Text = pessoaFisica.Cnh.ToString();
            TxtEmail.Text = pessoaFisica.Email;

            CbxGrupo.Focus();
            
        }

        private void CbxGrupo_Validated(object sender, EventArgs e)
        {

        }
    }
}
