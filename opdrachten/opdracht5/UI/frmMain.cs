using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void deelnemerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Deelnemer")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmDeelnemer f = new frmDeelnemer();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void registratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Registratie")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmRegistratie f = new frmRegistratie();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
