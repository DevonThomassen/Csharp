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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nepjournalistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Nepjournalist")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmNepjournalist f = new frmNepjournalist();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void nepnieuwsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Nepnieuws")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmNepnieuws f = new frmNepnieuws();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
