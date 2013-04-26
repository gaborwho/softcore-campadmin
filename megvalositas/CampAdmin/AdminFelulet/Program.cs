using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminFelulet.IfjusagiVezeto;
using AdminFelulet.KorcsoportVezeto;
using AdminFelulet.TaborVezeto;

using Borders;

namespace AdminFelulet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var bej = new Bejelentkezes();
            Application.Run(bej);

            Vezető vezető = bej.Vezető;
            if (vezető == null)
            {
                return;
            }
    
            
            IfjusagiMenu ifm;
            KorcsoportHome kcsm;
            TaborVezetoMenu tvm;


            if ((int)vezető.Tipus >= 0)
            {
                ifm = new IfjusagiMenu();
                ifm.Show();
            }


            if ((int)vezető.Tipus >= 1)
            {
                kcsm = new KorcsoportHome();
                kcsm.Show();
            }

            if ((int)vezető.Tipus >= 2)
            {
                tvm = new TaborVezetoMenu();
                tvm.Show();
            }

        }
    }
}
