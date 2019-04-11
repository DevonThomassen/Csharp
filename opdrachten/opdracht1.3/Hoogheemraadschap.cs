using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1._3
{
    class Hoogheemraadschap
    {
        // Constructie
        District district1;

        // Declaratie
        public string hoogH208;
        private string districtD202;

        // Constructor
        Hoogheemraadschap()
        {
            hoogH208 = "onbekend";
            districtD202 = "onbekend";
        }

        // Functions
        public void Invoeren()
        {
            Console.WriteLine("Voer je hoogheemraadschap in: ");
            hoogH208 = Console.ReadLine();

            district1.Invoeren();
            districtD202 = district1.districtH202;
        }

        public void Weergeven()
        {

        }
    }
}
