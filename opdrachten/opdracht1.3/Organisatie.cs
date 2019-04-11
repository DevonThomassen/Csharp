using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._3
{
    class Organisatie
    {
        public string organisatieH204;

        public void Invoeren()
        {
            Console.WriteLine("Voer je organisatie in: ");
            organisatieH204 = Console.ReadLine();
        }
    }
}
