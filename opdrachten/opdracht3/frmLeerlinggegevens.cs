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
    public partial class frmLeerlinggegevens : Form
    {
        private Deelnemer deelnemer;
        private Registratie registratie;

        public frmLeerlinggegevens(Deelnemer deelnemer, Registratie registratie)
        {
            InitializeComponent();

            // Toekenning
            this.deelnemer = deelnemer;
            this.registratie = registratie;
        }

        private void frm_Load(object sender, EventArgs e)
        {
            // Toekenning
            registratie.ChipnummerD201 = deelnemer.ChipnummerH201;

            // UI
            lbChipnummer.Text = registratie.ChipnummerD201.ToString();
            tbRegistratieTijd.Text = registratie.RegistratieTijd.ToString();
            tbRegistratiePunt.Text = registratie.RegistratiePunt;
            tbJaar.Text = registratie.Jaar.ToString();
        }

        private void invoeren_Click(object sender, EventArgs e)
        {
            registratie.RegistratiePunt = tbRegistratiePunt.Text;

            try
            {
                registratie.RegistratieTijd = Convert.ToInt32(tbRegistratieTijd.Text);
            }
            catch
            {
                registratie.RegistratieTijd = 0;
            }

            try
            {
                registratie.Jaar = Convert.ToInt32(tbJaar.Text);
            }

            catch
            {
                registratie.Jaar = 0;
            }

            // UI
            display.Text = $"Chipnummer {registratie.ChipnummerD201} registreert voor NYCM in het jaartal {registratie.Jaar} " +
                $"bij het registratiepunt {registratie.RegistratiePunt} de registratietijd {registratie.RegistratieTijd}";
        }
    }
}
