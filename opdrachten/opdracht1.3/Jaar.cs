/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Jaar.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Jaar
    {
        // Declaratie
        public int jaarH203;

        // Constructor
        public Jaar()
        {
            jaarH203 = 1980;
        }

        // Functions
        public void InvoerenJaar()
        {
            // Implementatie
            string input;
            Console.Write("Voer het jaartal in: ");
            input = Console.ReadLine();
            try
            {
                jaarH203 = Convert.ToInt32(input);
            }
            catch
            {
                jaarH203 = 0;
                Console.Write("Geen geldig jaartal ingevoerd.");
            }
            Console.Write("\n\n");
        }
    }
}
