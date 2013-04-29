using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CampLogic.Borders;

namespace AdminFelulet.TaborVezeto
{
    public partial class Statisztikak : Form
    {
        public Statisztikak()
        {
            InitializeComponent();
        }

        private void btStatlek_Click(object sender, EventArgs e)
        {
            if (comboStatisztikaTipus.SelectedItem == null)
            {
                return;
            }


            if (comboStatisztikaTipus.SelectedItem.ToString() == "HanyOrszagPerTurnus")
            {
                var stat = (FelületHozzáférő.Instance as ITáborvezetőiKezelő).StatisztikaHanyOrszagPerTurnus();


                dataGridViewEredmeny.ColumnCount = stat.Oszlopnevek.Count;

                foreach (var cHeather in stat.Oszlopnevek)
                {
                    dataGridViewEredmeny.Columns.Add(cHeather, cHeather);
                }

                foreach (var sor in stat.Sorok)
                {
                    dataGridViewEredmeny.Rows.Add(sor.ToArray());
                }


            }
            else if (comboStatisztikaTipus.SelectedItem.ToString() == "HanyTaborozóPerTurnus")
            {
                var stat = (FelületHozzáférő.Instance as ITáborvezetőiKezelő).StatisztikaHanyTaborozóPerTurnus();
            }


        }

        private class TypeHelper
        {
            public string Display { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Value;
            }
        }

        private void Statisztikak_Load(object sender, EventArgs e)
        {


            comboStatisztikaTipus.Items.Add(
                new TypeHelper
                {
                    Display = "Turnusonként hány ország volt",
                    Value = "HanyOrszagPerTurnus"
                });


            comboStatisztikaTipus.Items.Add(
                new TypeHelper
                {
                    Display = "Turnusonként hány táborozó volt",
                    Value = "HanyTaborozóPerTurnus"
                });

            comboStatisztikaTipus.DisplayMember = "Display";
            comboStatisztikaTipus.ValueMember = "Value";

            comboStatisztikaTipus.SelectedIndex = 0;
        }
    }
}
