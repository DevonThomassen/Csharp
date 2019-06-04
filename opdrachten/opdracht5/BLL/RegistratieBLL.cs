using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    public class RegistratieBLL
    {
        public static DataSet dsRegistratie;
        public RegistratieDAL registratieDAL;

        public RegistratieBLL()
        {
            dsRegistratie = new DataSet();
            registratieDAL = new RegistratieDAL();
        }

        public int Create(RegistratieBO r)
        {
            return registratieDAL.Create(r);
        }

        public DataSet Read()
        {
            return registratieDAL.Read();
        }
    }
}
