using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.KorcsoportVezetőFunkciók;

namespace AdminFelulet.KorcsoportVezeto
{
    public partial class CsoportLista : Form
    {
        Korcsoport korcs;

        public CsoportLista()
        {
            InitializeComponent();
        }

        public CsoportLista(Korcsoport korcs)
        {
            this.korcs = korcs;
        }


    }
}
