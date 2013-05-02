using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.IfjusagiVezetoFunkciok;
using CampLogic.Borders;
using CampLogic.TaborvezetoFunkciok;
using CampLogic.KorcsoportVezetoFunkciok;

namespace AdminFelulet.IfjusagiVezeto
{
    public partial class TaborozoCsoporthozSzobahozRendeles : Form
    {
        Taborozo táborozó;

        public TaborozoCsoporthozSzobahozRendeles(Taborozo t)
        {
            this.táborozó = t;

            InitializeComponent();
            labelNev.Text = t.Nev;


            ITaborVezetoiKezelo tvF = new TaborvezetoiKezeloFelulet();
            comboCsoportok.Items.AddRange(tvF.CsoportListazas().ToArray());
            comboSzobak.Items.AddRange(tvF.SzobaListazas().ToArray());

        }

        private void btMent_Click(object sender, EventArgs e)
        {
            Szoba sz = comboSzobak.SelectedItem as Szoba;
            Csoport cs = comboCsoportok.SelectedItem as Csoport;

            if (cs != null)
            {
                FeluletHozzafero.Instance.TáborozóCsoporthozRendeles(táborozó, cs);
            }

            if (sz!=null)
            {
                FeluletHozzafero.Instance.
            }
        }
    }
}
