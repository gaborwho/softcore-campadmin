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
            cbHazak.Items.AddRange((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).HazListazas().ToArray());
            Modosit = false;
        }

        public SzobaSzerkesztes(Szoba szoba)
        {
            sz = szoba;
            InitializeComponent();
            tbSzobaSzam.Text = sz.Szobaszam;
            tbFerohely.Text = sz.Ferohely.ToString();
            cbHazak.Items.AddRange((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).HazListazas().ToArray());
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
                        (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).SzobaModositas(cbHazak.SelectedItem as Ház, sz);
                    }
                    else
                    {
                        (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).SzobaLetrehozas(cbHazak.SelectedItem as Ház, sz);
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
