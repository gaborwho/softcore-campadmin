using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CampLogic.KorcsoportVezetőFunkciók;
using AdminFelulet.TaborVezeto;

namespace AdminFelulet.KorcsoportVezeto
{
    public partial class KorcsoportLista : Form
    {
        KorcsoportKezelo korcsKezelo = new KorcsoportKezelo();

        UnitDetails korcsSzerkeszto;
        public KorcsoportLista()
        {
            InitializeComponent();
            listBoxKorcsoportlista.DataSource = korcsKezelo.Listaz();
        }

        public void UpdateViews()
        {
            listBoxKorcsoportlista.Invalidate();
            
        }

        private void buttonUjKorcs_Click(object sender, EventArgs e)
        {
            korcsSzerkeszto = new UnitDetails();
            korcsSzerkeszto.ShowDialog();
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

        private void buttonKorcsFeltolt_Click(object sender, EventArgs e)
        {
            Korcsoport korcs = (Korcsoport)listBoxKorcsoportlista.SelectedItem;
            if (korcs == null) MessageBox.Show("Válassz!");
            else
            {
                CsoportLista csoportSzerkeszto = new CsoportLista(korcs);
                csoportSzerkeszto.ShowDialog();

            }
        }
    }
}
