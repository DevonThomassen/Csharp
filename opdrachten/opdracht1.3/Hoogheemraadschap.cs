/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Hoogheemraadschap.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Hoogheemraadschap
    {
        // Constructie
        District district2 = new District();

        // Declaratie
        public string hoogH208;
        private string districtD202;

        // Constructor
        public Hoogheemraadschap()
        {
            districtD202 = "onbekend";
        }

        // Functions
        public void Invoeren()
        {
            // Implementatie
            Console.Write("Voer je hoogheemraadschap in: ");
            hoogH208 = Console.ReadLine();

            district2.Invoeren();
            districtD202 = district2.districtH202;
            Console.Write("\n\n");
        }

        public void Weergeven()
        {
            // UI
            Console.WriteLine($"Het hoogheemraadschap {hoogH208} beheert het water in het district {districtD202}");
        }
    }
}
