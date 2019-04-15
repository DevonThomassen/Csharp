/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Kandidaat.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Kandidaat
    {
        // Declaratie
        public string kandidaatH206;
        public int bsnD201;
        private string organisatieD204;
        private string districtD202;

        // Constructor
        public Kandidaat()
        {
            bsnD201 = 0;
            organisatieD204 = "onbekend";
            districtD202 = "onbekend";
        }

        // Functions
        public void Invoeren()
        {
            // Constructie
            Burger burger2 = new Burger();
            Organisatie organisatie1 = new Organisatie();
            District district2 = new District();

            // Implementatie
            Console.Write("Voer de naam van de kandidaat in: ");
            kandidaatH206 = Console.ReadLine();

            burger2.Invoeren();
            bsnD201 = burger2.bsnH201;

            organisatie1.Invoeren();
            organisatieD204 = organisatie1.organisatieH204;

            district2.Invoeren();
            districtD202 = district2.districtH202;
            Console.Write("\n\n");
        }

        public void Weergeven()
        {
            // UI
            Console.WriteLine($"Kandidaat {kandidaatH206} met burgerservicenummer {bsnD201} van de organisatie {organisatieD204} woont in het district {districtD202}\n");
        }
    }
}
