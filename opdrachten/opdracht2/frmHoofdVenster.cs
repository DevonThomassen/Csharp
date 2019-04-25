using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace opdracht2
{
    public partial class frmHoofdVenster : Form
    {
        public frmHoofdVenster()
        {
            InitializeComponent();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bovenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuHoofd.Dock = DockStyle.Top;
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuHoofd.Dock = DockStyle.Left;
        }

        private void rechtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuHoofd.Dock = DockStyle.Right;
        }

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuHoofd.Dock = DockStyle.Bottom;
        }

        private void persoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            foreach (Form x in this.MdiChildren)
            {
                if (x.Text == "frmPersoon")
                {
                    x.Activate();
                    gevonden = true;
                    break;
                }
            }

            if (gevonden == false)
            {
                frmPersoon f = new frmPersoon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void hardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHardware f = new frmHardware();
            f.MdiParent = this;
            f.Show();
        }

        private void ladenConfiguratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void opslaanConfiguratieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(Path.Combine(Application.StartupPath, saveFileDialog1.FileName));
            string inhoud = Convert.ToString(menuHoofd.Dock);
            streamWriter.Write(inhoud);
            streamWriter.Flush();
            streamWriter.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    DockStyle result;

                    if (Enum.TryParse<DockStyle>(sr.ReadLine(), out result))
                    {
                        menuHoofd.Dock = result;
                    }
                    else
                    {
                        Console.WriteLine("Unknown dockstyle position");
                        menuHoofd.Dock = DockStyle.Top;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(error.Message);
            }
        }

        private void trapgewijsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void onderElkaarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void naastelkaarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void alleVensterSluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            { 
                frm.Dispose();
                frm.Close();
            }
        }
    }
}
