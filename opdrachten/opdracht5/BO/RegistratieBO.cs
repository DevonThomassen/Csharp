using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    public class RegistratieBO
    {
        // Declaratie
        private int _chipnummerD201;
        private int _registratieTijd;
        private string _registratiePuntW501;
        private int _jaar;

        // Propeties
        public int ChipnummerD201 { get; set; }
        public int RegistratieTijd { get; set; }
        public string RegistratiePuntW501 { get; set; }
        public int Jaar { get; set; }

        // Constructor
        public RegistratieBO()
        {
            _jaar = 1970;
        }
    }
}
