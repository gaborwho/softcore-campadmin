using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using CampLogic.KorcsoportVezetőFunkciók;
using CampLogic.Borders;
using CampLogic.Db;


namespace AdminFelulet.TaborVezeto
{
    public partial class UnitDetails : Form
    {
        CampLogic.Db.MyDbConnection conn = new MyDbConnection();
        
        public Korcsoport korcs = new Korcsoport();
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
        }

        public void UpdateView()
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
            korcs.KorosztalyAlsoKorlat = Convert.ToInt32(textBoxAlsoKor.Text);
            korcs.KorosztalyFelsoKorlat = Convert.ToInt32(textBoxFelsoKor.Text);
            if (!edit)
            {
                (FeluletHozzáféro.Instance as IKorcsoportVezetoiKezelo).KorcsoportModositas(korcs);
            }
            else
            {
                (FeluletHozzáféro.Instance as IKorcsoportVezetoiKezelo).KorcsoportModositas(korcs);
            }
            conn.Dispose();
            Close();
        }


       
    }
}
