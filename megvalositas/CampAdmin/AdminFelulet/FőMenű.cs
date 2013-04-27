using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdminFelulet.IfjusagiVezeto;
using AdminFelulet.KorcsoportVezeto;
using AdminFelulet.TaborVezeto;
using Borders;

namespace AdminFelulet
{
    public partial class FőMenű : Form
    {
        private Vezető vezető;

        public FőMenű()
        {
            InitializeComponent();
        }

        public FőMenű(Borders.Vezető vezető) :this()
        {
            this.vezető = vezető;
            Text = "Főprogram SoftCoreCampAdmin - Üdvözöljük:" + vezető.ToString();
        }

        private void FőMenű_Load(object sender, EventArgs e)
        {
            //A hozzáférő egy olyan singleton, melyen keresztül elérik a szükséges kezelő felületet az almenűk.
            FelületHozzáférő.SetByVezető(vezető);

            IfjusagiMenu ifm;
            KorcsoportHome kcsm;
            TaborVezetoMenu tvm;

            int alMenuWidth = this.Width/3;

            if ((int)vezető.Tipus >= 0)
            {
                ifm = new IfjusagiMenu();

                ifm.Width = alMenuWidth;
                ifm.Top = this.Bottom + 5;
                ifm.Left = this.Left;


                ifm.Show();
            }


            if ((int)vezető.Tipus >= 1)
            {
                kcsm = new KorcsoportHome();

                kcsm.Width = alMenuWidth;
                kcsm.Top = this.Bottom + 5;
                kcsm.Left = this.Left + alMenuWidth;

                kcsm.Show();
            }

            if ((int)vezető.Tipus >= 2)
            {
                tvm = new TaborVezetoMenu();

                tvm.Width = alMenuWidth;
                tvm.Top = this.Bottom + 5;
                tvm.Left = this.Left + alMenuWidth * 2;

                tvm.Show();
            }

        }
    }
}
