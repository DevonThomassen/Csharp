/************************** Module Header *******************************\
Project:        opdracht4
Auteur:         Devon Thomassen
Aanmaakdatum:   14-05-2019 
Module naam:    frmPizza.cs

Omschrijving:   opdracht4

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    public class Bezorging
    {
        private string _postcode;
        private int _huisnummer;
        private string _bezorgDag;
        private string _bezorgTijd;
        private string _bestelcodeD202;
        private string _actiecode;

        // Propeties
        public string Postcode { get; set; }
        public int Huisnummer { get; set; }
        public string BezorgDag { get; set; }
        public string BezorgTijd { get; set; }
        public string BestelcodeD202 { get; set; }
        public string Actiecode { get; set; }

        // Constructor
        public Bezorging()
        {
            _postcode = "1234AB";
            _huisnummer = 1;
            _bestelcodeD202 = "X";
            _actiecode = "Korting10";
        }
    }
}
