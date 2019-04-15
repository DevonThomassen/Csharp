/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Stemmen.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Stemmen:Jaar
    {
        // Declaratie
        private int[] bsnStemmerBsnKandidaatVerkiezingsJaar = new int[3];

        // Constructor
        public Stemmen()
        { 
        }

        // Functions
        public void Invoeren(Stemmer stemmer, Kandidaat kandidaat)
        {
            // Implementatie
            bsnStemmerBsnKandidaatVerkiezingsJaar[0] = stemmer.bsnD201;
            bsnStemmerBsnKandidaatVerkiezingsJaar[1] = kandidaat.bsnD201;

            InvoerenJaar();
            bsnStemmerBsnKandidaatVerkiezingsJaar[2] = jaarH203;
        }

        public void Weergeven()
        {
            // UI
            Console.WriteLine($"Burgerservicenummer {bsnStemmerBsnKandidaatVerkiezingsJaar[0]} stemt op burgerservicenummer {bsnStemmerBsnKandidaatVerkiezingsJaar[1]} in het verkiesjaar {bsnStemmerBsnKandidaatVerkiezingsJaar[2]}\n");
        }
    }
}
