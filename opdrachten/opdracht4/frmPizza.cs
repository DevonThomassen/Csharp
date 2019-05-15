/************************** Module Header *******************************\
Project:        opdracht4
Auteur:         Devon Thomassen
Aanmaakdatum:   14-05-2019 
Module naam:    frmPizza.cs

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
    public partial class frmPizza : Form
    {
        // Declaratie
        private List<Pizza> pizzaLijst;

        // Constructor
        public frmPizza(List<Pizza> pizzaLijst)
        {
            InitializeComponent();

            // Toekenning
            this.pizzaLijst = pizzaLijst;
        }

        // Methodes
        private void input_Click(object sender, EventArgs e)
        {
            // Add pizza obj in list
            Pizza p = new Pizza();
            p.pizzaNaamH201 = tbNaam.Text;
            pizzaLijst.Add(p);

            // Add item to listview
            ListViewItem item = new ListViewItem();
            item.Text = p.pizzaNaamH201;
            listView.Items.Add(item);

            // Clear
            tbNaam.Text = "";
        }

        private void frmLoad(object sender, EventArgs e)
        {
            // Add items to listview
            foreach (Pizza p in pizzaLijst)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.pizzaNaamH201;
                listView.Items.Add(item);
            }
        }
    }
}
