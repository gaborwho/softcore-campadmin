using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.Db;
using CampLogic.Borders;
using System.Diagnostics;

namespace AdminFelulet
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
            TesztVezetők();
        }


        Vezetö vezető;

        public Vezetö Vezető
        {
            get { return vezető; }
            private set { vezető = value; }
        }

        VezetoModell vm = new VezetoModell();

        private void button1_Click(object sender, EventArgs e)
        {

            if ((vezető = vm.VezetőUserPassz(tbNev.Text, tbPass.Text)) == null)
            {
                MessageBox.Show("Rossz név vagy jelszó");
                return;
            }

            Close();
        }

        //Feltételes, csak a debug verzióba fordítja a JIT
        [Conditional("DEBUG")]
        private void TesztVezetők() {

            
            Vezetö vIfi = new Vezetö
            {
                Nev = "IfiTeszt",
                Jelszo = "teszt",
                Tipus = VezetoTípus.IfjúságiVezető
            };

            Vezetö vKcs = new Vezetö
            {
                Nev = "KcsTeszt",
                Jelszo = "teszt",
                Tipus = VezetoTípus.KorcsoportVezető
            };

            Vezetö vTb = new Vezetö
            {
                Nev = "TbTeszt",
                Jelszo = "teszt",
                Tipus = VezetoTípus.TáborVezető
            };

            Vezetö t = new Vezetö
            {
                Nev = "t",
                Jelszo = "t",
                Tipus = VezetoTípus.TáborVezető
            };

            vm.TesztCreateVezetőIfDontExists(vIfi);
            vm.TesztCreateVezetőIfDontExists(vKcs);
            vm.TesztCreateVezetőIfDontExists(vTb);
            vm.TesztCreateVezetőIfDontExists(t);

            MessageBox.Show("Tesztfelhasználók:\n IfiTeszt/teszt \n KcsTeszt/teszt \n TbTeszt/teszt");
        }

    }
}
