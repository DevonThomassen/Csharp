/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    ProStemmergram.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Stemmer
    {
        // Declaratie
        public string stemmerH205;
        public int bsnD201;
        private string districtD202;

        // Constructor
        public Stemmer()
        {
            bsnD201 = 0;
            districtD202 = "onbekend";
        }

        // Functions
        public void Invoeren()
        {
            // Constructie
            Burger burger1 = new Burger();
            District district1 = new District();

            // Implementatie
            Console.Write("Voer de naam van de stemmer in: ");
            stemmerH205 = Console.ReadLine();

            burger1.Invoeren();
            bsnD201 = burger1.bsnH201;

            district1.Invoeren();
            districtD202 = district1.districtH202;
            Console.Write("\n\n");
        }

        public void Weergeven()
        {
            // UI
            Console.WriteLine($"Stemmer {stemmerH205} met het burgerservicenummer {bsnD201} woont in het district {districtD202}");
        }
    }
}
