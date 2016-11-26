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
using Services;
using Modelo;

namespace LocAuto
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void carregarGrid()
        {
            UsuarioDAO dao = new UsuarioDAO();
            UsuarioService service = new UsuarioService(dao);
            List<Usuario> listaUsuario = new List<Usuario>();
            listaUsuario = service.buscaTodos();
            dataGridView1.Rows.Clear();
            foreach (Usuario t in listaUsuario)
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linhaTabela = dataGridView1.Rows[index];
                linhaTabela.Cells["codigo"].Value = t.Codigo;
                linhaTabela.Cells["nome"].Value = t.Nome;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadUsuario cadUsuario = new CadUsuario();
            cadUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            UsuarioDAO dao = new UsuarioDAO();
            UsuarioService service = new UsuarioService(dao);
            try
            {
                dao.apagar(idSelecionado);
                MessageBox.Show("Usuário apagado com sucesso");
                carregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value);
            Usuario usuarioSelecionado;
            UsuarioDAO dao = new UsuarioDAO();
            UsuarioService service = new UsuarioService(dao);
            usuarioSelecionado = service.buscaPorId(idSelecionado);

            CadUsuario cadUsuario = new CadUsuario();
            cadUsuario.usuarioConsulta = usuarioSelecionado;
            cadUsuario.Show();
        }
    }
}
