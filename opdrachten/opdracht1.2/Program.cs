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
