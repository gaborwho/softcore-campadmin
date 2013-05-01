using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CampLogic.Borders;
using CampLogic.TaborvezetoFunkciok;

namespace AdminFelulet.TaborVezeto
{
    public partial class HazSzerkesztoLista : Form
    {
        public HazSzerkesztoLista()
        {
            InitializeComponent();
        }

        private void btUj_Click(object sender, EventArgs e)
        {
            Haz h = null;

            try
            {
                h = new Haz
                {
                    MapX = int.Parse(tbMapX.Text),
                    MapY = int.Parse(tbMapY.Text),
                    Nev = tbNeve.Text
                };

                if ((FeluletHozzafero.Instance as ITaborVezetoiKezelo).HazLetrehozas(h))
                {
                    lbHazak.Items.Add(h);
                }
                else
                {
                    MessageBox.Show("Ilyen nevű ház már létezik");
                }
                
                
            }
            catch (FormatException)
            {
                MessageBox.Show("MapX; MapY egész számok legyenek");
            }

        }

        private void btTorol_Click(object sender, EventArgs e)
        {
            if (lbHazak.SelectedItem == null)
            {
                MessageBox.Show("Törléshez jelöljön ki egy házat a listából");

                return;
            }

            (FeluletHozzafero.Instance as ITaborVezetoiKezelo).HazTorles(lbHazak.SelectedItem as Haz);
            lbHazak.Items.Remove(lbHazak.SelectedItem);
        }

        private void btSzerkeszt_Click(object sender, EventArgs e)
        {
            if (lbHazak.SelectedItem == null)
            {
                MessageBox.Show("Modosításhoz jelöljön ki egy házat a listából");

                return;
            }


            Haz h = lbHazak.SelectedItem as Haz;

            try
            {

                h.MapX = int.Parse(tbMapX.Text);
                h.MapY = int.Parse(tbMapY.Text);
                h.Nev = tbNeve.Text;

                lbHazak.Items.Remove(h);
                lbHazak.Items.Add(h);

                (FeluletHozzafero.Instance as ITaborVezetoiKezelo).HazModositas(h);
            }
            catch (FormatException)
            {
                MessageBox.Show("MapX; MapY egész számok legyenek");
            }


            
        }

        private void HazSzerkesztoLista_Load(object sender, EventArgs e)
        {
            lbHazak.Items.AddRange((FeluletHozzafero.Instance as ITaborVezetoiKezelo).HazListazas().ToArray());
        }

        private void lbHazak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHazak.SelectedItem == null)
            {
                return;
            }

            tbNeve.Text = (lbHazak.SelectedItem as Haz).Nev;
            tbMapX.Text = (lbHazak.SelectedItem as Haz).MapX.ToString();
            tbMapY.Text = (lbHazak.SelectedItem as Haz).MapY.ToString();
        }
    }
}
