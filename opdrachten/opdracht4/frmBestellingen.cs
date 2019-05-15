/************************** Module Header *******************************\
Project:        opdracht4
Auteur:         Devon Thomassen
Aanmaakdatum:   14-05-2019 
Module naam:    frmBestellingen.cs

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
    public partial class frmBestellingen : Form
    {
        // Declaratie
        private List<Bestelling> bestellingLijst;
        private List<Pizza> pizzaLijst;

        // Constructor
        public frmBestellingen(List<Bestelling> bestellingLijst, List<Pizza> pizzaLijst)
        {
            InitializeComponent();

            // Toekenning
            this.bestellingLijst = bestellingLijst;
            this.pizzaLijst = pizzaLijst;
        }

        // Methodes
        private void input_Click(object sender, EventArgs e)
        {
            // Initialisatie
            Bestelling b = new Bestelling();
            b.BestelCodeH202 = tbCode.Text;
            b.PizzaNaamD202 = cbPizza.Text; // Toekkening
            b.PizzaGrootteType_w501 = cbSize.Text;
            b.PizzaBodemType_w502 = cbBottom.Text;

            try { b.Aantal = Convert.ToInt32(tbAmount.Text); }
            catch { b.Aantal = 1; }

            bestellingLijst.Add(b);

            // UI
            string[] array = new string[5];
            array[0] = b.BestelCodeH202;
            array[1] = b.PizzaNaamD202;
            array[2] = b.PizzaGrootteType_w501;
            array[3] = b.PizzaBodemType_w502;
            array[4] = b.Aantal.ToString();

            ListViewItem item = new ListViewItem(array);
            listView.Items.Add(item);

            // Clear
            tbCode.Text = "";
            tbAmount.Text = "";
        }

        // UI
        private void frmLoad(object sender, EventArgs e)
        {
            // Clear 
            cbPizza.Items.Clear();
            listView.Items.Clear();

            // Add items to combobox 
            foreach (Pizza p in pizzaLijst)
            {
                cbPizza.Items.Add(p.pizzaNaamH201);
            }

            // Add items to listview
            foreach (Bestelling b in bestellingLijst)
            {
                string[] array = new string[5];
                array[0] = b.BestelCodeH202;
                array[1] = b.PizzaNaamD202;
                array[2] = b.PizzaGrootteType_w501;
                array[3] = b.PizzaBodemType_w502;
                array[4] = b.Aantal.ToString();

                // Clear
                ListViewItem item = new ListViewItem(array);
                listView.Items.Add(item);
            }

            // Select first item of combobox if more than 0 items
            if (cbPizza.Items.Count > 0) cbPizza.SelectedIndex = 0;
            if (cbSize.Items.Count > 0) cbSize.SelectedIndex = 0;
            if (cbBottom.Items.Count > 0) cbBottom.SelectedIndex = 0;
        }
    }
}
