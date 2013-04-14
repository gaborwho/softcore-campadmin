using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminFelulet.IfjusagiVezeto;
using AdminFelulet.KorcsoportVezeto;
using AdminFelulet.TaborVezeto;

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

            //CamperList ablak = new CamperList();
            //CamperGroup ablak = new CamperGroup();

            //GroupList ablak = new GroupList();
            //UnitEdit ablak = new UnitEdit();
            //UnitGroupList ablak = new UnitGroupList();

            //HouseList ablak = new HouseList();
            //RoomEdit ablak = new RoomEdit();
            //RoomList ablak = new RoomList();
            //SessionEdit ablak = new SessionEdit();
            //SessionList ablak = new SessionList();
            //SessionUnitList ablak = new SessionUnitList();
            Statisztikak ablak = new Statisztikak();
            //UnitDetails ablak = new UnitDetails();

            Application.Run(ablak);
            //Application.Run(new Form1());
        }
    }
}
