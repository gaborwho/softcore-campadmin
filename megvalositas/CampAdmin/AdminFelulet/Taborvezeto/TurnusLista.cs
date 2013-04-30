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
    public partial class TurnusLista : Form
    {
        public TurnusLista()
        {
            InitializeComponent();
        }


        private void TurnusLista_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusListazas().Count; i++)
            {
                Turnus t=(FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusListazas()[i];
                AktivitásBeállít(t);
            }
            lbTurnusok.Items.AddRange((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusListazas().ToArray());
        }

        private static void AktivitásBeállít(Turnus t)
        {
            if (t.Aktív == true && t.Befejezes < DateTime.Today)
            {
                t.Aktív = false;
                (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusModositas(t);
            }

            if (t.Aktív == true && t.Kezdes > DateTime.Today)
            {
                t.Aktív = false;
                (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusModositas(t);
            }

            if (t.Aktív == false && t.Befejezes >= DateTime.Today && t.Kezdes <= DateTime.Today)
            {
                t.Aktív = true;
                (FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusModositas(t);
            }

        }

        private void btUjTurnus_Click(object sender, EventArgs e)
        {
            TurnusSzerkesztes SzerkesztoAblak = new TurnusSzerkesztes();
            SzerkesztoAblak.ShowDialog();
            lbTurnusok.Items.Clear();
            lbTurnusok.Items.AddRange((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusListazas().ToArray());
        }

        private void btModosit_Click(object sender, EventArgs e)
        {
            Turnus t = null;
            if (lbTurnusok.SelectedItem == null)
            {
                MessageBox.Show("Modosításhoz jelöljön ki egy turnust a listából");

                return;
            }

            t = lbTurnusok.SelectedItem as Turnus;
            TurnusSzerkesztes SzerkesztoAblak = new TurnusSzerkesztes(t);
            SzerkesztoAblak.ShowDialog();
            lbTurnusok.Items.Clear();
            lbTurnusok.Items.AddRange((FeluletHozzáféro.Instance as ITáborvezetoiKezelo).TurnusListazas().ToArray());
        }
    }
}
