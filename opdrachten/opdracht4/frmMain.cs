using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht4
{
    public partial class frmMain : Form
    {
        public List<Pizza> pizza;
        public List<Bestelling> bestelling;
        public List<Bezorging> bezorging;

        public frmMain()
        {
            InitializeComponent();
            pizza = new List<Pizza>();
            bestelling = new List<Bestelling>();
            bezorging = new List<Bezorging>();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Pizza's")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmPizza f = new frmPizza(pizza);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bestellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Bestellingen")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmBestellingen f = new frmBestellingen(bestelling, pizza);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bezorgingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "Bezorgingen")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmBezorging f = new frmBezorging(bezorging, bestelling);
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
