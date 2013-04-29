using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CampLogic.Borders;
using CampLogic.TáborvezetőFunkciók;

namespace AdminFelulet.TaborVezeto
{
    public partial class TurnusLista : Form
    {
        public TurnusLista()
        {
            InitializeComponent();

        }

        private void btUjTurnus_Click(object sender, EventArgs e)
        {
            TurnusSzerkesztes tsz = new TurnusSzerkesztes();

            tsz.ShowDialog();

            ResetListFromDb();
        }

        private void btTurnusModosit_Click(object sender, EventArgs e)
        {
            if (lbTurnusok.SelectedItem == null)
            {
                MessageBox.Show("Turnus módosításhoz válasszon ki egy turnust, a listából");

                return;
            }

            TurnusSzerkesztes tsz = new TurnusSzerkesztes(lbTurnusok.SelectedItem as Turnus);

            tsz.ShowDialog();

            ResetListFromDb();
        }

        private void lbTurnusok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TurnusLista_Load(object sender, EventArgs e)
        {
            ResetListFromDb();
        }

        private void ResetListFromDb()
        {
            lbTurnusok.Items.Clear();
            lbTurnusok.Items.AddRange((FelületHozzáférő.Instance as ITáborvezetőiKezelő).TurnusListazas().ToArray());
        }

    }
}
