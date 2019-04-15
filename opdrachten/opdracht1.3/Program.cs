/************************** Module Header *******************************\
Project:        opdracht1.3
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Program.cs

Omschrijving:   opdracht1.3

\************************************************************************/

using System;

namespace opdracht1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructie
            Stemmer stemmer1 = new Stemmer();
            Kandidaat kandidaat1 = new Kandidaat();
            Hoogheemraadschap hoogheemraadschap1 = new Hoogheemraadschap();
            Stemmen stemmen1 = new Stemmen();

            // Functieaanroep
            stemmer1.Invoeren();
            kandidaat1.Invoeren();
            stemmen1.Invoeren(stemmer1, kandidaat1);
            hoogheemraadschap1.Invoeren();

            stemmer1.Weergeven();
            kandidaat1.Weergeven();
            stemmen1.Weergeven();
            hoogheemraadschap1.Weergeven();

            Console.ReadKey();
        }
    }
}
