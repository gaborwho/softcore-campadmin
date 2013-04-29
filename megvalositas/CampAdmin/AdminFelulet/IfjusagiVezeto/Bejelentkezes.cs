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


        Vezető vezető;

        public Vezető Vezető
        {
            get { return vezető; }
            private set { vezető = value; }
        }

        VezetőModell vm = new VezetőModell();

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

            
            Vezető vIfi = new Vezető
            {
                Nev = "IfiTeszt",
                Jelszo = "teszt",
                Tipus = VezetőTípus.IfjúságiVezető
            };

            Vezető vKcs = new Vezető
            {
                Nev = "KcsTeszt",
                Jelszo = "teszt",
                Tipus = VezetőTípus.KorcsoportVezető
            };

            Vezető vTb = new Vezető
            {
                Nev = "TbTeszt",
                Jelszo = "teszt",
                Tipus = VezetőTípus.TáborVezető
            };

            Vezető t = new Vezető
            {
                Nev = "t",
                Jelszo = "t",
                Tipus = VezetőTípus.TáborVezető
            };

            vm.TesztCreateVezetőIfDontExists(vIfi);
            vm.TesztCreateVezetőIfDontExists(vKcs);
            vm.TesztCreateVezetőIfDontExists(vTb);
            vm.TesztCreateVezetőIfDontExists(t);

            MessageBox.Show("Tesztfelhasználók:\n IfiTeszt/teszt \n KcsTeszt/teszt \n TbTeszt/teszt");
        }

    }
}
