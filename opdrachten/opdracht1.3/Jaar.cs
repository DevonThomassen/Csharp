using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._3
{
    class Jaar
    {
        // Declaratie
        public int jaarH203;

        // Constructor
        Jaar()
        {
            jaarH203 = 1980;
        }

        // Functions
        public void Invoeren()
        {
            string input;
            Console.WriteLine("Voer het jaartal in: ");
            input = Console.ReadLine();
            try
            {
                jaarH203 = Convert.ToInt32(input);
            }
            catch
            {
                jaarH203 = 0;
                Console.WriteLine("Geen geldig jaartal ingevoerd.");
            }
        }
    }
}
