using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomassen_Devon_IO2B4_Nepnieuws
{
    public class NepjournalistBO
    {
        // Declaratie
        private string _nepJournalistNaam;
        private int _journalistNummerH201;
        private string _geslachtW501;

        public string NepJournalistNaam { get; set; }
        public int JournalistNummerH201 { get; set; }
        public string GeslachtW501 { get; set; }

        // Constructor 
        public NepjournalistBO ()
        {
            _nepJournalistNaam = "nep_naam";
            _journalistNummerH201 = 0;
            _geslachtW501 = "W";
        }
    }
}
