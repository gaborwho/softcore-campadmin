using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.TaborvezetoFunkciok;
using CampLogic.Borders;

namespace AdminFelulet.TaborVezeto
{
    public partial class TurnusSzerkesztes : Form
    {
        bool Modosit;
        Turnus t;

        public TurnusSzerkesztes()
        {
            InitializeComponent();
            t = new Turnus();
            Modosit = false;
        }

        public TurnusSzerkesztes(Turnus turnus)
        {
            InitializeComponent();
            t = turnus;
            tbNev.Text = t.Nev;
            tbSorszam.Text = t.Sorszam.ToString();
            dateKezdes.Value = t.Kezdes;
            dateBefejezes.Value = t.Befejezes;
            Modosit = true;
        }

        private void btMentes_Click(object sender, EventArgs e)
        {
            if (dateKezdes.Value > dateBefejezes.Value)
            {
                MessageBox.Show("A turnus befejezése nem lehet a kezdés előtt");
                return;
            }

            try
            {

                t.Nev = tbNev.Text;
                t.Sorszam = int.Parse(tbSorszam.Text);
                t.Kezdes = dateKezdes.Value;
                t.Befejezes = dateBefejezes.Value;
                if (t.Kezdes < DateTime.Today && t.Befejezes > DateTime.Today)
                {
                    t.Aktív = true;
                }
                else
                {
                    t.Aktív = false;
                }
                
                if (Modosit)
                {
                    (FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusModositas(t);
                }
                else
                {
                    (FeluletHozzafero.Instance as ITaborVezetoiKezelo).TurnusLetrehozas(t);
                }
                
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("A sorszámnak egész számnak kell lennie");
            }
            
        }

    }
}
