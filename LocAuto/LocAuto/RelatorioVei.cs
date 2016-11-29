﻿using DaoMysql;
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
    public partial class RelatorioVei : Form
    {
        public RelatorioVei()
        {
            InitializeComponent();
        }

        private void RelatorioVei_Load(object sender, EventArgs e)
        {
            VeiculoBindingSource.DataSource = new VeiculoDAO().buscaTodos();
            this.reportViewer1.RefreshReport();
        }
    }
}
