using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomassen_Devon_IO2B4_Nepnieuws
{
    public partial class frmNepjournalist : Form
    {
        public frmNepjournalist()
        {
            InitializeComponent();
        }

        private void invoeren_Click(object sender, EventArgs e)
        {
            NepjournalistBO n = new NepjournalistBO();

            int parse;

            n.NepJournalistNaam = tbNaam.Text;
            Int32.TryParse(tbNummer.Text, out parse);
            n.JournalistNummerH201 = parse;
            n.GeslachtW501 = cbSex.Text;

            lbOutput.Text = $"Nepjournalist {n.NepJournalistNaam} van het geslacht {n.GeslachtW501} staat geregisteerd onder het nepjournalistnummer {n.JournalistNummerH201}";
        }
    }
}
