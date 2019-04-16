/************************** Module Header *******************************\
Project:        opdracht1.2
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Leerling.cs

Omschrijving:   opdracht1.2

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._2
{
    class Leerling:Datum
    {
        // Declaratie
        private string naam;
        public int[] nummerMobiel = new int[2];

        // Constructor
        public Leerling()
        {
            // Initialisatie
            naam = "onbekend";
            nummerMobiel[1] = 0612345678;
            dagMaandJaar[0] = 01;
            dagMaandJaar[1] = 01;
            dagMaandJaar[2] = 1980;
        }

        // Functions
        public void Invoeren()
        {
            // Initialisatie
            naam = "Luna";
            nummerMobiel[0] = 12345;
            nummerMobiel[1] = 612345678;
            dagMaandJaar[0] = 28;
            dagMaandJaar[1] = 03;
            dagMaandJaar[2] = 2013;
        }

        public void Weergeven()
        {
            // UI
            Console.WriteLine($"Leerling {naam} met leerlingnummer {nummerMobiel[0]} maakt gebruik van het mobiele nummer {nummerMobiel[1]}");
            Console.WriteLine($"Leerling {naam} is geboren op de datum {dagMaandJaar[0]}-{dagMaandJaar[1]}-{dagMaandJaar[2]}");
        }
    }
}
