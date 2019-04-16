/************************** Module Header *******************************\
Project:        opdracht1.2
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Datum.cs

Omschrijving:   opdracht1.2

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._2
{
    class Datum
    {
        // Declaratie
        public int[] dagMaandJaar = new int[3];

        // Constructor
        public Datum()
        {
            dagMaandJaar[0] = 1;
            dagMaandJaar[2] = 1980;
        }
    }
}
