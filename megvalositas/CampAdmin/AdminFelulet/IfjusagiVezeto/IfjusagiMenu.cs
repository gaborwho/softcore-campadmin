using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminFelulet.IfjusagiVezeto
{
    public partial class IfjusagiMenu : Form
    {
        public IfjusagiMenu()
        {
            InitializeComponent();
        }

        private void btTaborozok_Click(object sender, EventArgs e)
        {
            CamperList ablak = new CamperList();
            ablak.ShowDialog();
        }
    }
}
