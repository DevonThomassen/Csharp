using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomassen_Devon_IO2B4_Nepnieuws
{
    public class NepnieuwsBO
    {
        // Declaratie
        private int _datum;
        private int _nepJournalistNummerD201;
        private string _mediaNaam;
        private string _onderwerp;

        public int Datum { get; set; }
        public int NepJournalistNummerD201 { get; set; }
        public string MediaNaam { get; set; }
        public string Onderwerp { get; set; }

        // Constructor
        public NepnieuwsBO ()
        {
            // Leeg
        }

    }
}
