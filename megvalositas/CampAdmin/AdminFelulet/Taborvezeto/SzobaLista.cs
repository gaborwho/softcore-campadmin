using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.Borders;
using CampLogic.TáborvezetőFunkciók;

namespace AdminFelulet.TaborVezeto
{
    public partial class SzobaLista : Form
    {
        public SzobaLista()
        {
            InitializeComponent();
        }

        

        private void btUj_Click(object sender, EventArgs e)
        {
            SzobaSzerkesztes SzerkesztoAblak = new SzobaSzerkesztes();
            SzerkesztoAblak.ShowDialog();
            lbSzobak.Items.Clear();
            lbSzobak.Items.AddRange((FelületHozzáférő.Instance as ITáborvezetőiKezelő).SzobaListazas().ToArray());
        }

        private void btSzerkeszt_Click(object sender, EventArgs e)
        {
            Szoba sz = null;
            if (lbSzobak.SelectedItem == null)
            {
                MessageBox.Show("Modosításhoz jelöljön ki egy szobát a listából");

                return;
            }

            sz = lbSzobak.SelectedItem as Szoba;
            SzobaSzerkesztes SzerkesztoAblak = new SzobaSzerkesztes(sz);
            SzerkesztoAblak.ShowDialog();
            lbSzobak.Items.Clear();
            lbSzobak.Items.AddRange((FelületHozzáférő.Instance as ITáborvezetőiKezelő).SzobaListazas().ToArray());
        }

        private void SzobaLista_Load(object sender, EventArgs e)
        {
            lbSzobak.Items.AddRange((FelületHozzáférő.Instance as ITáborvezetőiKezelő).SzobaListazas().ToArray());
        }

        private void btTorol_Click(object sender, EventArgs e)
        {
            if (lbSzobak.SelectedItem == null)
            {
                MessageBox.Show("Törléshez jelöljön ki egy szobát a listából");

                return;
            }

            (FelületHozzáférő.Instance as ITáborvezetőiKezelő).SzobaTorol((lbSzobak.SelectedItem as Szoba).Ház, lbSzobak.SelectedItem as Szoba);
            lbSzobak.Items.Remove(lbSzobak.SelectedItem);

        }
    }
}
