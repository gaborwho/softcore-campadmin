using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Db;

namespace AdminFelulet
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
        }


        Borders.Vezető vezető;

        public Borders.Vezető Vezető
        {
            get { return vezető; }
            private set { vezető = value; }
        }

        VezetőModell vm = new VezetőModell();

        private void button1_Click(object sender, EventArgs e)
        {

            if ((vezető = vm.VezetőUserPassz(tbNev.Text, tbPass.Text)) == null)
            {
                MessageBox.Show("Rossz név vagy jelszó");
                return;
            }

            Close();
        }
    }
}
