/************************** Module Header *******************************\
Project:        opdracht3
Auteur:         Devon Thomassen
Aanmaakdatum:   09-05-2019 
Module naam:    Deelnemer.cs

Omschrijving:   opdracht3

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3
{
    public class Deelnemer
    {
        // Declaratie
        private string _naam;
        private int _rugnummer;
        public int _chipnummerH201;

        // Properties
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Rugnummer
        {
            get { return _rugnummer; }
            set { _rugnummer = value; }
        }

        public int ChipnummerH201
        {
            get { return _chipnummerH201; }
            set { _chipnummerH201 = value; }
        }

        // Constructor
        public Deelnemer()
        { 
            _chipnummerH201= 0;
        }
    }
}
