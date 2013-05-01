using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.IfjusagiVezetoFunkciok;

namespace AdminFelulet.IfjusagiVezeto
{
    public partial class TaborozoCsoporthozSzobahozRendeles : Form
    {
        Taborozo t;

        public TaborozoCsoporthozSzobahozRendeles(Taborozo t)
        {
            this.t = t;

            InitializeComponent();
            labelNev.Text = t.Nev;
        }
    }
}
