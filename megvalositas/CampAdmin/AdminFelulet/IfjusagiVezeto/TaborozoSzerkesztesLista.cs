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

            ResetFromDb();
        }

        private void ResetFromDb() {
            listBoxTaborozok.Items.Clear();

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
                    SzuletesiDatum = dtpSzul.Value,
                    Orszag = tbOrszag.Text,
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

                ResetFromDb();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba történt!");
            }

        }

        private void buttonRendeles_Click(object sender, EventArgs e)
        {
            if (aktiv==null)
            {
                MessageBox.Show("Valaszon ki a listából egy táborozót.");
                return;
            }

            TaborozoCsoporthozSzobahozRendeles ablak =
                new TaborozoCsoporthozSzobahozRendeles(aktiv);
            ablak.ShowDialog();
        }

        private void listBoxTaborozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTaborozok.SelectedItem != null)
            {
                aktiv = (Taborozo)listBoxTaborozok.SelectedItem;

                textBoxNev.Text = aktiv.Nev;
                dtpSzul.Value = aktiv.SzuletesiDatum;
                tbOrszag.Text = aktiv.Orszag;

                textBoxElerhetosegek.Text = aktiv.Elerhetosegek;
                textBoxBetegsegek.Text = aktiv.Betegsegek;
                textBoxMegjegyzesek.Text = aktiv.Megjegyzes;


            }

        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (aktiv == null)
            {
                aktiv = new Taborozo();
            }

            aktiv.Nev = textBoxNev.Text;
            aktiv.SzuletesiDatum = dtpSzul.Value;
            aktiv.Orszag = tbOrszag.Text;

            aktiv.Elerhetosegek = textBoxElerhetosegek.Text;
            aktiv.Betegsegek = textBoxBetegsegek.Text;
            aktiv.Megjegyzes = textBoxMegjegyzesek.Text;

            (FeluletHozzafero.Instance as IIfjusagiVezetoiKezelo).TaborozoModositasa(aktiv);

            listBoxTaborozok.Items[listBoxTaborozok.SelectedIndex] = aktiv;
        }

        private void tbTörlés_Click(object sender, EventArgs e)
        {
            if (listBoxTaborozok.SelectedItem==null)
            {
                MessageBox.Show("Táborozó törléséhez válasszon ki egyet a listából");
            }
            else
            {
                FeluletHozzafero.Instance.TaborozoTorles(listBoxTaborozok.SelectedItem as Taborozo);
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (FeluletHozzafero.Instance.ImportFilebol(fd.FileName))
                {
                    ResetFromDb();

                    MessageBox.Show("Sikeres import");
                }
                else
                {
                    MessageBox.Show("Import meghiúsult");
                }
            }

        }
    }
}
