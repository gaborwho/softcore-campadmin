using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminFelulet.TaborVezeto
{
    public partial class TaborVezetoMenu : Form
    {
        public TaborVezetoMenu()
        {
            InitializeComponent();
        }

        private void btHázak_Click(object sender, EventArgs e)
        {
            HazSzerkesztoLista ablak = new HazSzerkesztoLista();
            ablak.ShowDialog();
        }

        private void btSzobák_Click(object sender, EventArgs e)
        {
            SzobaLista ablak = new SzobaLista();
            ablak.ShowDialog();
        }

        private void btTurnusok_Click(object sender, EventArgs e)
        {
            TurnusLista ablak = new TurnusLista();
            ablak.ShowDialog();
        }

        private void btStatisztikák_Click(object sender, EventArgs e)
        {
            Statisztikak ablak = new Statisztikak();
            ablak.ShowDialog();
        }
    }
}
