using DaoMysql;
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
    public partial class RelatorioLoc : Form
    {

        public RelatorioLoc()
        {
            InitializeComponent();
        }

        private void RelatorioLoc_Load(object sender, EventArgs e)
        {
            RelLocacaoBindingSource.DataSource = new LocacaoDAO().buscaTodos(); 
            this.reportViewer1.RefreshReport();
        }
    }
}
