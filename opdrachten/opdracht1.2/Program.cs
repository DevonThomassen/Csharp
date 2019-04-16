/************************** Module Header *******************************\
Project:        opdracht1.2
Auteur:         Devon Thomassen
Aanmaakdatum:   10-04-2019 
Module naam:    Program.cs

Omschrijving:   opdracht1.2

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructie
            Leerling leerling1 = new Leerling();

            // Functieaanroep
            leerling1.Invoeren();
            leerling1.Weergeven();
            Console.ReadKey();
        }
    }
}
