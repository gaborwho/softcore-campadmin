using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminFelulet.IfjusagiVezeto;
using AdminFelulet.KorcsoportVezeto;
using AdminFelulet.TaborVezeto;

using CampLogic.Borders;

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
                MessageBox.Show("Hitelesítés meghiúsult, viszlát");
                return;
            }

            Application.Run(new FőMenű(vezető));

        }
    }
}
