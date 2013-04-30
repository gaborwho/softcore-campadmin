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
using CampLogic.KorcsoportVezetőFunkciók;
namespace AdminFelulet.KorcsoportVezeto
{
    public partial class CsoportLista : Form
    {
        Korcsoport korcs;
        Csoport csoport;


        int csoportid;

        public CsoportLista()
        {
            InitializeComponent();
        }

        public CsoportLista(Korcsoport korcs):this()
        {
            this.korcs = korcs;
            LoadGui();
        }



        void LoadGui()
        {
            //ha rendbeszabtuk az adatbazist akkor utana: getifivezetok List<Vezeto> Ő nélkül!
            comboBoxIfi1.Items.AddRange(VezetoModell.GetIfiVezetok());
            comboBoxIfi2.Items.AddRange(VezetoModell.GetIfiVezetok());
            listBox1.DataSource = korcs.Csoportok;
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            csoport = new Csoport();
            csoport.Nev = textBoxNev.Text;
            //a vezető osztályom nincs meg mert nemtudom, a dani elmagyarazta. migralni kell.
            csoport.IfiVezeto1 = (Vezetö)comboBoxIfi1.SelectedItem;
            csoport.IfiVezeto2 = (Vezetö)comboBoxIfi2.SelectedItem;
            if (csoport.IfiVezeto1 == csoport.IfiVezeto2)
            {
                MessageBox.Show("A klónozást még nem találták fel!");
                return;
            }
            csoport.CoportId = (int)(korcs.Csoportok.Max(x => x.CoportId)) + 1;
            csoport.Korcsoport = korcs;
            korcs.Csoportok.Add(csoport);
            UpdateKorcs();
            
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            korcs.Csoportok.Remove((Csoport)listBox1.SelectedItem);
            UpdateKorcs();
        }

        void UpdateKorcs() {
            (FeluletHozzáféro.Instance as IKorcsoportVezetoiKezelo).KorcsoportModositas(korcs);
        }

    }
}
