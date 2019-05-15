/************************** Module Header *******************************\
Project:        opdracht4
Auteur:         Devon Thomassen
Aanmaakdatum:   14-05-2019 
Module naam:    Bestelling.cs

Omschrijving:   opdracht4

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4
{
    public class Bestelling
    {
        private string _bestelcodeH202;
        private string _pizzaNaamD201;
        private string _pizzaGrootteType_w501;
        private string _pizzaBodemType_w502;
        private int _aantal;

        // Propeties
        public string BestelCodeH202 { get; set; }
        public string PizzaNaamD202 { get; set; }
        public string PizzaGrootteType_w501 { get; set; }
        public string PizzaBodemType_w502 { get; set; }
        public int Aantal { get; set; }

        // Constructor
        public Bestelling()
        {
            _bestelcodeH202 = "X";
            _pizzaGrootteType_w501 = "Medium";
            _pizzaBodemType_w502 = "Classic";
            _aantal = 1;
        }
    }
}
