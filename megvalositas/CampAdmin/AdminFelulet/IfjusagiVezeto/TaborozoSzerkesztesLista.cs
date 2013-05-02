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
        Taborozo aktiv;

        public CamperList()
        {
            InitializeComponent();

            listBoxTaborozok.Items.AddRange(
                (FeluletHozzafero.Instance as IIfjusagiVezetoiKezelo).TaborozoListazas().ToArray());
        }

        private void buttonUjTaborozo_Click(object sender, EventArgs e)
        {
            try
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
            catch (FormatException ex)
            {
                MessageBox.Show("Érvénytelen dátum!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!");
            }
        }

        private void buttonRendeles_Click(object sender, EventArgs e)
        {
            TaborozoCsoporthozSzobahozRendeles ablak =
                new TaborozoCsoporthozSzobahozRendeles(aktiv);
            ablak.ShowDialog();
        }

        private void listBoxTaborozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTaborozok.SelectedIndex > 0)
            {
                aktiv = (Taborozo)listBoxTaborozok.SelectedItem;
                textBoxNev.Text = aktiv.Nev;
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            aktiv.Nev = textBoxNev.Text;
            listBoxTaborozok.Items[listBoxTaborozok.SelectedIndex] = aktiv;
            (FeluletHozzafero.Instance as IIfjusagiVezetoiKezelo).TaborozoModositasa(aktiv);
        }
    }
}
