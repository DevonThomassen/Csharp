/************************** Module Header *******************************\
Project:        opdracht3
Auteur:         Devon Thomassen
Aanmaakdatum:   09-05-2019 
Module naam:    frmLeerlinggegevens.cs

Omschrijving:   opdracht3

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

namespace opdracht3
{
    public partial class frmDeelnemer : Form
    {
        private Deelnemer deelnemer;

        public frmDeelnemer(Deelnemer deelnemer)
        {
            InitializeComponent();
            this.deelnemer = deelnemer;
        }

        // Initialisatie
        private void invoeren_Click(object sender, EventArgs e)
        {
            deelnemer.Naam = tbDeelnemer.Text;

            try
            {
                deelnemer.Rugnummer = Convert.ToInt32(tbRugnummer.Text);
            }
            catch
            {
                Console.WriteLine($"Onbekende integer : {deelnemer.Rugnummer}");
                deelnemer.Rugnummer = 0;
            }

            try
            {
                deelnemer.ChipnummerH201 = Convert.ToInt32(tbChipnummer.Text);
            }
            catch
            {
                Console.WriteLine($"Onbekende integer: {deelnemer.ChipnummerH201}");
                deelnemer.ChipnummerH201 = 0;
            }

            display.Text = $"Deelnemer {deelnemer.Naam} heeft het rugnummer {deelnemer.Rugnummer} en het chipnummer {deelnemer.ChipnummerH201}";
        }

        private void frm_Load(object sender, EventArgs e)
        {
            tbDeelnemer.Text = deelnemer.Naam;
            tbRugnummer.Text = deelnemer.Rugnummer.ToString();
            tbChipnummer.Text = deelnemer.ChipnummerH201.ToString();
        }
    }
}
