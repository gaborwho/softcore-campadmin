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
using CampLogic.KorcsoportVezetoFunkciok;
namespace AdminFelulet.KorcsoportVezeto
{
    public partial class CsoportLista : Form
    {
        Csoport csoport;
        Korcsoport korcsoport;

        public CsoportLista()
        {
            InitializeComponent();
        }


        void LoadGui()
        {
            comboBoxIfi1.Items.Clear();
            comboBoxIfi1.Items.AddRange(VezetoModell.GetIfiVezetok());

            comboBoxIfi2.Items.Clear();
            comboBoxIfi2.Items.AddRange(VezetoModell.GetIfiVezetok());

            cbKorcsoport.Items.Clear();
            cbKorcsoport.Items.AddRange((FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportListazas().ToArray());

            lbcsoportok.Items.Clear();
            lbcsoportok.Items.AddRange((FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).CsoportListazas().ToArray());

        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            csoport = new Csoport();
            csoport.Nev = textBoxNev.Text;
            csoport.IfiVezeto1 = (Vezeto)comboBoxIfi1.SelectedItem;
            csoport.IfiVezeto2 = (Vezeto)comboBoxIfi2.SelectedItem;
            korcsoport= (Korcsoport)cbKorcsoport.SelectedItem;
            
            if (csoport.IfiVezeto1 == csoport.IfiVezeto2)
            {
                MessageBox.Show("Két különböző ifjúsági vezetzőt kell a csoporthoz rendelni!");
                return;
            }
            

            (FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).CsoportLetrehozas(csoport, korcsoport);

            Close();
            
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
           
            csoport = lbcsoportok.SelectedItem as Csoport;
            if (csoport!=null)
            {
                (FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).CsoportTorles(csoport);
                UpdateKorcs();
            }

            LoadGui();
           
        }

        void UpdateKorcs() {
            (FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportModositas(korcsoport,csoport);
            
        }

        private void CsoportLista_Load(object sender, EventArgs e)
        {
            LoadGui();
        }

    }
}
