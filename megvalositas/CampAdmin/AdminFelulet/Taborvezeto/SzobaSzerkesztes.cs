using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.TáborvezetőFunkciók;
using CampLogic.Borders;

namespace AdminFelulet.TaborVezeto
{
    public partial class SzobaSzerkesztes : Form
    {
        bool Modosit;
        Szoba sz;
        public SzobaSzerkesztes()
        {
            InitializeComponent();
            sz = new Szoba();
            cbHazak.Items.AddRange((FelületHozzáférő.Instance as ITáborvezetőiKezelő).HazListazas().ToArray());
            Modosit = false;
        }

        public SzobaSzerkesztes(Szoba szoba)
        {
            sz = szoba;
            InitializeComponent();
            tbSzobaSzam.Text = sz.Szobaszam;
            tbFerohely.Text = sz.Ferohely.ToString();
            cbHazak.Items.AddRange((FelületHozzáférő.Instance as ITáborvezetőiKezelő).HazListazas().ToArray());
            cbHazak.Text = sz.Ház.ToString();
            Modosit = true;
        }

        private void btMentes_Click(object sender, EventArgs e)
        {
            
                try
                {

                    sz.Szobaszam = tbSzobaSzam.Text;
                    sz.Ferohely = int.Parse(tbFerohely.Text);

                    if (Modosit)
                    {
                        (FelületHozzáférő.Instance as ITáborvezetőiKezelő).SzobaModositas(cbHazak.SelectedItem as Ház, sz);
                    }
                    else
                    {
                        (FelületHozzáférő.Instance as ITáborvezetőiKezelő).SzobaLetrehozas(cbHazak.SelectedItem as Ház, sz);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("MapX; MapY egész számok legyenek");
                }
                Close();
        }
    }
}
