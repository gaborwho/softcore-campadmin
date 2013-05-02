using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using CampLogic.KorcsoportVezetoFunkciok;
using AdminFelulet.TaborVezeto;
using CampLogic.Borders;

namespace AdminFelulet.KorcsoportVezeto
{
    public partial class KorcsoportLista : Form
    {
        KorcsoportKezelo korcsKezelo = new KorcsoportKezelo();

        UnitDetails korcsSzerkeszto;

        public KorcsoportLista()
        {
            InitializeComponent();
        }

        public void UpdateViews()
        {
            listBoxKorcsoportlista.Items.Clear();
            listBoxKorcsoportlista.Items.AddRange((FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportListazas().ToArray());
        }

        private void buttonUjKorcs_Click(object sender, EventArgs e)
        {
            korcsSzerkeszto = new UnitDetails();
            korcsSzerkeszto.ShowDialog();
            UpdateViews();
        }

        private void buttonKorcsSzerk_Click(object sender, EventArgs e)
        {
            Korcsoport korcs = (Korcsoport)listBoxKorcsoportlista.SelectedItem;
            if (korcs == null) MessageBox.Show("Válassz!");
            else
            {
                korcsSzerkeszto = new UnitDetails(korcs);
                korcsSzerkeszto.ShowDialog();
            }
            UpdateViews();
        }

       

        private void KorcsoportLista_Load(object sender, EventArgs e)
        {
            listBoxKorcsoportlista.Items.AddRange((FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportListazas().ToArray());
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (listBoxKorcsoportlista.SelectedItem == null)
            {
                MessageBox.Show("Törléshez jelöljön ki egy korcsoportot a listából");

                return;
            }

            (FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportTorles(listBoxKorcsoportlista.SelectedItem as Korcsoport);
            listBoxKorcsoportlista.Items.Remove(listBoxKorcsoportlista.SelectedItem);
        }

        private void listBoxKorcsoportlista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKorcsoportlista.SelectedItem != null)
            {
                lbNev.Text = (listBoxKorcsoportlista.SelectedItem as Korcsoport).Nev;
            }
        }
    }
}
