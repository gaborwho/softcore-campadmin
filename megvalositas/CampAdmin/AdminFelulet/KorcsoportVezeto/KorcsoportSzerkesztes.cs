using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CampLogic.KorcsoportVezetoFunkciok;
using CampLogic.Borders;
using CampLogic.Db;


namespace AdminFelulet.TaborVezeto
{
    public partial class UnitDetails : Form
    {
        
        private Korcsoport korcs = new Korcsoport();
        bool edit = false;
        public UnitDetails()
        {
            InitializeComponent();
        }
        public UnitDetails(Korcsoport korcs)
        {
            InitializeComponent();
            this.korcs = korcs;
            edit = true;
            UpdateView();
        }

        private void UpdateView()
        {
            textBoxNev.Text = korcs.Nev;
            textBoxOrszag.Text = korcs.Orszag;
            textBoxAlsoKor.Text = korcs.KorosztalyAlsoKorlat.ToString();
            textBoxFelsoKor.Text = korcs.KorosztalyFelsoKorlat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            korcs.Nev = textBoxNev.Text;
            korcs.Orszag = textBoxOrszag.Text;
            try
            {
                korcs.KorosztalyAlsoKorlat = Convert.ToInt32(textBoxAlsoKor.Text);
                korcs.KorosztalyFelsoKorlat = Convert.ToInt32(textBoxFelsoKor.Text);
                if (korcs.KorosztalyAlsoKorlat > korcs.KorosztalyFelsoKorlat)
                {
                    MessageBox.Show("A alsó korhatár nem lehet nagyobb a felső korhatárnál");
                    return;
                }

                if (edit)
                {
                    (FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportModositas(korcs);
                }
                else
                {
                    (FeluletHozzafero.Instance as IKorcsoportVezetoiKezelo).KorcsoportLetrehozas(korcs);
                }
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("A korhatároknak számoknak kell lenniük");
            }
        }

        private void UnitDetails_Load(object sender, EventArgs e)
        {

        }


       
    }
}
