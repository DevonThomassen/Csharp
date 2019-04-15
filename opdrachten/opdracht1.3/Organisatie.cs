/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Organisatie.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Organisatie
    {
        // Declaratie
        public string organisatieH204;

        // Consructor
        public Organisatie()
        {
        }

        // Functions
        public void Invoeren()
        {
            // Implementatie
            Console.Write("Voer je organisatie in: ");
            organisatieH204 = Console.ReadLine();
        }
    }
}
