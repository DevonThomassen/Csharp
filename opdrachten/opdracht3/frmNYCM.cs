using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht3
{
    public partial class frmNYCM : Form
    {
        // Declaratie 
        private Deelnemer deelnemer;
        private Registratie registratie;

        // Constructor
        public frmNYCM()
        {
            InitializeComponent();

            // Constructie
            deelnemer = new Deelnemer();
            registratie = new Registratie();
        }

        // Methodes
        private void deelnemerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeelnemer f = new frmDeelnemer(deelnemer);
            f.MdiParent = this;
            f.Show();
        }

        private void registratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeerlinggegevens f = new frmLeerlinggegevens(deelnemer, registratie);
            f.MdiParent = this;
            f.Show();
        }
    }
}
