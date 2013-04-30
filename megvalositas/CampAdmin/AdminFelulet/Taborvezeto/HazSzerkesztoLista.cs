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
    public partial class HazSzerkesztoLista : Form
    {
        public HazSzerkesztoLista()
        {
            InitializeComponent();
        }

        private void btUj_Click(object sender, EventArgs e)
        {
            Ház h = null;

            try
            {
                h = new Ház
                {
                    MapX = int.Parse(tbMapX.Text),
                    MapY = int.Parse(tbMapY.Text),
                    Név = tbNeve.Text
                };

                if ((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).HazLetrehozas(h))
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

            (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).HazTorles(lbHazak.SelectedItem as Ház);
            lbHazak.Items.Remove(lbHazak.SelectedItem);
        }

        private void btSzerkeszt_Click(object sender, EventArgs e)
        {
            if (lbHazak.SelectedItem == null)
            {
                MessageBox.Show("Modosításhoz jelöljön ki egy házat a listából");

                return;
            }


            Ház h = lbHazak.SelectedItem as Ház;

            try
            {

                h.MapX = int.Parse(tbMapX.Text);
                h.MapY = int.Parse(tbMapY.Text);
                h.Név = tbNeve.Text;

                lbHazak.Items.Remove(h);
                lbHazak.Items.Add(h);

                (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).HazModositas(h);
            }
            catch (FormatException)
            {
                MessageBox.Show("MapX; MapY egész számok legyenek");
            }


            
        }

        private void HazSzerkesztoLista_Load(object sender, EventArgs e)
        {
            lbHazak.Items.AddRange((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).HazListazas().ToArray());
        }

        private void lbHazak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHazak.SelectedItem == null)
            {
                return;
            }

            tbNeve.Text = (lbHazak.SelectedItem as Ház).Név;
            tbMapX.Text = (lbHazak.SelectedItem as Ház).MapX.ToString();
            tbMapY.Text = (lbHazak.SelectedItem as Ház).MapY.ToString();
        }
    }
}
