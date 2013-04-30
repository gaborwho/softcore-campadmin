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
    public partial class TurnusLista : Form
    {
        public TurnusLista()
        {
            InitializeComponent();
        }


        private void TurnusLista_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < (FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusListazas().Count; i++)
            {
                Turnus t=(FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusListazas()[i];
                AktivitásBeállít(t);
            }
            lbTurnusok.Items.AddRange((FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusListazas().ToArray());
        }

        private static void AktivitásBeállít(Turnus t)
        {
            if (t.Aktív == true && t.Befejezes < DateTime.Today)
            {
                t.Aktív = false;
                (FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusModositas(t);
            }

            if (t.Aktív == true && t.Kezdes > DateTime.Today)
            {
                t.Aktív = false;
                (FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusModositas(t);
            }

            if (t.Aktív == false && t.Befejezes >= DateTime.Today && t.Kezdes <= DateTime.Today)
            {
                t.Aktív = true;
                (FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusModositas(t);
            }

        }

        private void btUjTurnus_Click(object sender, EventArgs e)
        {
            TurnusSzerkesztes SzerkesztoAblak = new TurnusSzerkesztes();
            SzerkesztoAblak.ShowDialog();
            lbTurnusok.Items.Clear();
            lbTurnusok.Items.AddRange((FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusListazas().ToArray());
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
            lbTurnusok.Items.AddRange((FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusListazas().ToArray());
        }
    }
}
