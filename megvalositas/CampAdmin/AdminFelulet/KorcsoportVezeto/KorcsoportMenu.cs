using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminFelulet.KorcsoportVezeto
{
    public partial class KorcsoportHome : Form
    {
        public KorcsoportHome()
        {
            InitializeComponent();
        }

       

        private void btCsoportok_Click(object sender, EventArgs e)
        {
            CsoportLista ablak = new CsoportLista();
            ablak.ShowDialog();
        }

        private void btKorcsoportok_Click(object sender, EventArgs e)
        {
            KorcsoportLista ablak = new KorcsoportLista();
            ablak.ShowDialog();
        }
    }
}
