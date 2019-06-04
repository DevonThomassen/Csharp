using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    public class DeelnemerBO
    {
        // Declaratie
        private string _naam;
        private int _rugnummer;
        private int _chipnummerH201;

        // Propeties
        public string Naam { get; set; }
        public int Rugnummer { get; set; }
        public int ChipnummerH201 { get; set; }

        // Constructor
        public DeelnemerBO()
        {
            _chipnummerH201 = 0;
        }
    }
}
