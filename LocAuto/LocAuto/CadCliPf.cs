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
    public partial class CadCliPf : Form
    {
        String pNome;
        public CadCliPf(String nome)
        {
            pNome = nome;
            InitializeComponent();
        }

        private void CadCliPf_Load(object sender, EventArgs e)
        {
            label1.Text = this.pNome;
        }
    }
}
