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
            TesztVezetok();
        }

        Vezeto vezeto;

        public Vezeto Vezeto
        {
            get { return vezeto; }
            private set { vezeto = value; }
        }

        VezetoModell vm = new VezetoModell();

        private void button1_Click(object sender, EventArgs e)
        {

            if ((vezeto = vm.VezetoUserPass(tbNev.Text, tbPass.Text)) == null)
            {
                MessageBox.Show("Rossz név vagy jelszó");
                return;
            }

            Close();
        }

        //Feltételes, csak a debug verzióba fordítja a JIT
        [Conditional("DEBUG")]
        private void TesztVezetok() {

            
            Vezeto vIfi = new Vezeto
            {
                Nev = "IfiTeszt",
                Jelszo = "teszt",
                Tipus = VezetoTipus.IfjusagiVezeto
            };

            Vezeto vKcs = new Vezeto
            {
                Nev = "KcsTeszt",
                Jelszo = "teszt",
                Tipus = VezetoTipus.KorcsoportVezeto
            };

            Vezeto vTb = new Vezeto
            {
                Nev = "TbTeszt",
                Jelszo = "teszt",
                Tipus = VezetoTipus.TaborVezeto
            };

            Vezeto t = new Vezeto
            {
                Nev = "t",
                Jelszo = "t",
                Tipus = VezetoTipus.TaborVezeto
            };

            vm.TesztCreateVezetoIfDontExists(vIfi);
            vm.TesztCreateVezetoIfDontExists(vKcs);
            vm.TesztCreateVezetoIfDontExists(vTb);
            vm.TesztCreateVezetoIfDontExists(t);

            MessageBox.Show("Tesztfelhasználók:\n IfiTeszt/teszt \n KcsTeszt/teszt \n TbTeszt/teszt");
        }

    }
}
