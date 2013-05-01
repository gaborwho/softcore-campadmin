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
using CampLogic.Borders;

namespace AdminFelulet
{
    public partial class FoMenu : Form
    {
        private Vezeto vezető;

        private IfjusagiMenu ifm;
        private KorcsoportHome kcsm;
        private TaborVezetoMenu tvm;

        public FoMenu()
        {
            InitializeComponent();
        }

        public FoMenu(CampLogic.Borders.Vezeto vezető) :this()
        {
            this.vezető = vezető;
            Text = "Főprogram SoftCoreCampAdmin - Üdvözöljük:" + vezető.ToString();
        }

       

        private void FőMenű_Load(object sender, EventArgs e)
        {
            //A hozzáférő egy olyan singleton, melyen keresztül elérik a szükséges kezelő felületet az almenűk.
            FeluletHozzafero.SetByVezető(vezető);

            

            int alMenuWidth = this.Width/3;

            ifm = new IfjusagiMenu();
            kcsm = new KorcsoportHome();

            if ((int)vezető.Tipus >= 0)
            {
                if ((int)vezető.Tipus == 0)
                {
                    this.Width = alMenuWidth + 10;
                }

                ifm.Width = alMenuWidth;
                ifm.Top = this.Bottom + 5;
                ifm.Left = this.Left;

                ifm.TopLevel = false;
                ifm.FormBorderStyle = FormBorderStyle.Fixed3D;
                ifm.Dock = DockStyle.Left;
                ifm.Visible = true;
                this.Controls.Add(ifm);
                ifm.Show();
            }


            if ((int)vezető.Tipus >= 1)
            {
                kcsm.TopLevel = false;
                this.Controls.Add(kcsm);
                kcsm.FormBorderStyle = FormBorderStyle.Fixed3D;
                kcsm.Width = alMenuWidth;
                kcsm.Top = ifm.Top;

                if ((int)vezető.Tipus == 2)
                {
                    kcsm.Left = (this.Width / 2 - kcsm.Width / 2) - 7;
                    kcsm.Height = ifm.Height;
                }
                else
                {
                    kcsm.Dock = DockStyle.Right;
                    this.Width = this.Width * 2 / 3 + 10;
                }
                kcsm.Visible = true;
                

                kcsm.Show();
            }

            if ((int)vezető.Tipus >= 2)
            {
                tvm = new TaborVezetoMenu();

                tvm.Width = alMenuWidth;
                tvm.Top = this.Bottom + 5;
                tvm.Left = this.Left + alMenuWidth * 2;

                tvm.TopLevel = false;
                tvm.FormBorderStyle = FormBorderStyle.Fixed3D;
                tvm.Dock = DockStyle.Right;
                tvm.Visible = true;
                this.Controls.Add(tvm);

                tvm.Show();
            }

        }

        private void FoMenu_Resize(object sender, EventArgs e)
        {
            if ((int)vezető.Tipus == 2)
            {
                kcsm.Left = (this.Width / 2 - kcsm.Width / 2) - 7;
                kcsm.Height = ifm.Height;
            }
        }
    }
}
