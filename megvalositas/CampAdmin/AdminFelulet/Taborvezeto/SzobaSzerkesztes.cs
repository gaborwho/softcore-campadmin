using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.TaborvezetoFunkciok;
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
            cbHazak.Items.AddRange((FeluletHozzafero.Instance as ITaborVezetoiKezelo).HazListazas().ToArray());
            Modosit = false;
        }

        public SzobaSzerkesztes(Szoba szoba)
        {
            sz = szoba;
            InitializeComponent();
            tbSzobaSzam.Text = sz.Szobaszam;
            tbFerohely.Text = sz.Ferohely.ToString();
            cbHazak.Items.AddRange((FeluletHozzafero.Instance as ITaborVezetoiKezelo).HazListazas().ToArray());
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
                        (FeluletHozzafero.Instance as ITaborVezetoiKezelo).SzobaModositas(cbHazak.SelectedItem as Haz, sz);
                    }
                    else
                    {
                        (FeluletHozzafero.Instance as ITaborVezetoiKezelo).SzobaLetrehozas(cbHazak.SelectedItem as Haz, sz);
                    }

                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Férőhelyek száma szám kell, hogy legyen");
                }
                
        }
    }
}
