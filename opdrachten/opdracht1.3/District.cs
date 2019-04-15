/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    District.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class District
    {
        // Declaratie
        public string districtH202;

        // Constructor
        public District()
        {
            districtH202 = "onbekend";
        }

        // Functions
        public void Invoeren()
        {
            // Implementatie
            Console.Write("Voer uw district in: ");
            districtH202 = Console.ReadLine();
        }
    }
}
