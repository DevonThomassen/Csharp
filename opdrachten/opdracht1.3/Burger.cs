/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Burger.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Burger
    {
        // Declaratie
        public int bsnH201;

        // Constructor
        public Burger()
        {
            bsnH201 = 0;
        }

        // Functions
        public void Invoeren()
        {
            // Implementatie
            string input; 
            Console.Write("Voer je bsn in: ");
            input = Console.ReadLine();
            try
            {
                bsnH201 = Convert.ToInt32(input);
            }
            catch
            {
                bsnH201 = 0;
                Console.WriteLine("Geen geldig bsn ingevoederd.");
            }
        }
    }
}
