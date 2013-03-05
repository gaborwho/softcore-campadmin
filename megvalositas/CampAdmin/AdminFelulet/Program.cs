using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminFelulet.Ifivezeto;
using WindowsFormsApplication1.Unit;
using WindowsFormsApplication2;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Dir;

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
            //CamperEdit ablak = new CamperEdit();
            CamperGroup ablak = new CamperGroup();
            //CamperImport ablak = new CamperImport();
            //GroupEdit ablak = new GroupEdit();
            //UnitEdit ablak = new UnitEdit();
            //CamperEdit ablak = new CamperEdit();
            //WindowsFormsApplication1.UnitGroupList ablak = new WindowsFormsApplication1.UnitGroupList();
            //SessionEdit ablak = new SessionEdit();
            //SessionList ablak = new SessionList();
            //UnitDetails ablak = new UnitDetails();
            ablak.ShowDialog();
            //Application.Run(new Form1());
        }
    }
}
