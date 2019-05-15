/************************** Module Header *******************************\
Project:        opdracht4
Auteur:         Devon Thomassen
Aanmaakdatum:   14-05-2019 
Module naam:    frmBezorging.cs

Omschrijving:   opdracht4

\************************************************************************/

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
    public partial class frmBezorging : Form
    {
        // Declaratie
        private List<Bezorging> bezorgingLijst;
        private List<Bestelling> bestellingLijst;

        // Constructor
        public frmBezorging(List<Bezorging> bezorgingLijst, List<Bestelling> bestellingLijst)
        {
            InitializeComponent();

            // Toekenning
            this.bezorgingLijst = bezorgingLijst;
            this.bestellingLijst = bestellingLijst;
        }

        // Methodes
        private void input_Click(object sender, EventArgs e)
        {
            // Initialisatie
            Bezorging b = new Bezorging();
            b.Postcode = tbZip.Text;

            try { b.Huisnummer = Convert.ToInt32(tbNumber.Text); }
            catch { b.Huisnummer = 1; }

            b.BezorgDag = tbDay.Text;
            b.BezorgTijd = tbTime.Text;
            b.BestelcodeD202 = cbCode.Text; // Toekenning
            b.Actiecode = tbSale.Text;

            bezorgingLijst.Add(b);

            // UI
            string[] array = new string[6];
            array[0] = b.Postcode;
            array[1] = b.Huisnummer.ToString(); ;
            array[2] = b.BezorgDag;
            array[3] = b.BezorgTijd;
            array[4] = b.BestelcodeD202;
            array[5] = b.Actiecode;

            ListViewItem item = new ListViewItem(array);
            listView.Items.Add(item);

            // Clear
            tbZip.Text = "";
            tbNumber.Text = "";
            tbDay.Text = "";
            tbTime.Text = "";
            tbSale.Text = "";
        }

        private void frmLoad(object sender, EventArgs e)
        {
            // Clear 
            cbCode.Items.Clear();
            listView.Items.Clear();

            // Add items to combobox
            foreach (Bestelling b in bestellingLijst)
            {
                cbCode.Items.Add(b.BestelCodeH202);
            }

            // Add items to listview
            foreach (Bezorging b in bezorgingLijst)
            {
                string[] array = new string[6];
                array[0] = b.Postcode;
                array[1] = b.Huisnummer.ToString(); ;
                array[2] = b.BezorgDag;
                array[3] = b.BezorgTijd;
                array[4] = b.BestelcodeD202;
                array[5] = b.Actiecode;

                ListViewItem item = new ListViewItem(array);
                listView.Items.Add(item);
            }

            // Select first item of combobox if more than 0 items
            if (cbCode.Items.Count > 0) cbCode.SelectedIndex = 0;
        }
    }
}
