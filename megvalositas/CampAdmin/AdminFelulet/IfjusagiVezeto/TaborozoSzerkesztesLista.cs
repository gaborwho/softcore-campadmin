using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CampLogic.Borders;
using CampLogic.IfjusagiVezetoFunkciok;

namespace AdminFelulet.IfjusagiVezeto
{
    public partial class CamperList : Form
    {
        public CamperList()
        {
            InitializeComponent();
        }

        private void buttonUjTaborozo_Click(object sender, EventArgs e)
        {
            Taborozo t = new Taborozo()
            {
                Nev = textBoxNev.Text,
                SzuletesiDatum = DateTime.Parse(textBoxSzuletes.Text),
                Orszag = comboBoxOrszag.Text,
                Elerhetosegek = textBoxElerhetosegek.Text,
                Betegsegek = textBoxBetegsegek.Text,
                Megjegyzes = textBoxMegjegyzesek.Text
            };

            if ((FeluletHozzafero.Instance as IIfjusagiVezetoiKezelo).UjTaborozo(t))
            {
                listBoxTaborozok.Items.Add(t);
            }
            else
            {
                MessageBox.Show("Ilyen nevű táborozó már létezik");
            }
        }
    }
}
