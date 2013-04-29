using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CampLogic.TáborvezetőFunkciók;
using CampLogic.Borders;

namespace AdminFelulet.TaborVezeto
{
    public partial class TurnusSzerkesztes : Form
    {
        bool Szerkeszt = false;

        private Turnus turnus;

        public TurnusSzerkesztes()
        {
            InitializeComponent();
        }

        public TurnusSzerkesztes(CampLogic.TáborvezetőFunkciók.Turnus turnus):this()
        {
            // TODO: Complete member initialization
            Szerkeszt = true;
            this.turnus = turnus;
        }

        private void btMent_Click(object sender, EventArgs e)
        {
            try
            {
                turnus.Nev = tbNev.Text;
                turnus.Sorszam = int.Parse(tbSorszam.Text);

                turnus.Kezdes = dtpKezd.Value;
                turnus.Befejezes = dtBef.Value;

                if (Szerkeszt)
                {
                    (FelületHozzáférő.Instance as ITáborvezetőiKezelő).TurnusModositas(turnus);
                }
                else
                {
                    (FelületHozzáférő.Instance as ITáborvezetőiKezelő).TurnusLetrehozas(turnus);
                }

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Sorszám legyen szám");
            }
            
        }

        private void TurnusSzerkesztes_Load(object sender, EventArgs e)
        {
            if (turnus!=null)
            {
                tbNev.Text = turnus.Nev;
                tbSorszam.Text = turnus.Sorszam.ToString();

                dtpKezd.Value = turnus.Kezdes;
                dtBef.Value = turnus.Befejezes;

            }
            else
            {
                turnus = new Turnus();
            }


        }
    }
}
