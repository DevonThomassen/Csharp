/************************** Module Header *******************************\
Project:        opdracht3
Auteur:         Devon Thomassen
Aanmaakdatum:   09-05-2019 
Module naam:    Registratie.cs

Omschrijving:   opdracht3

\************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3
{
    public class Registratie
    {
        // Declaratie
        private int _chipNummerD201;
        private int _registratieTijd;
        private string _registratiePunt;
        private int _jaar;

        // Propeties
        public int ChipnummerD201
        {
            get { return _chipNummerD201; }
            set { _chipNummerD201 = value; }
        }

        public int RegistratieTijd
        {
            get { return _registratieTijd; }
            set { _registratieTijd = value; }
        }

        public string RegistratiePunt
        {
            get { return _registratiePunt; }
            set { _registratiePunt = value; }
        }

        public int Jaar
        {
            get { return _jaar; }
            set { _jaar = value; }
        }

        // Constructor
        public Registratie()
        {
            _jaar = 0;
        }
    }
}
