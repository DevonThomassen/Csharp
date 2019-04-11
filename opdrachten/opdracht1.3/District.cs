using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._3
{
    class District
    {
        // Declaratie
        public string districtH202;

        // Constructor
        District()
        {
            districtH202 = "onbekend";
        }

        // Functions
        public void Invoeren()
        {
            Console.WriteLine("Voer uw district in: ");
            districtH202 = Console.ReadLine();
        }
    }
}
