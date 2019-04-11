using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._3
{
    class Burger
    {
        // Declaratie
        public int bsnH201;

        // Constructor
        Burger()
        {
            bsnH201 = 0;
        }

        // Functions
        public void Invoeren()
        {
            string input; // try - catch 
            Console.WriteLine("Voer je bsn in: ");
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
