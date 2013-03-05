using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminFelulet.Ifivezeto;
//using AdminFelulet.Korcsoportvezeto;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CamperEdit ablak=new CamperEdit();
            ablak.ShowDialog();
            //Application.Run(new Form1());
        }
    }
}
