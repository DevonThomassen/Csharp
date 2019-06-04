using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    public class DeelnemerBLL
    {
        // Declaratie
        public static DataSet dsDeelnemer;
        public DeelnemerDAL dDeelnemerDAL;

        // Constructor
        public DeelnemerBLL()
        {
            dsDeelnemer = new DataSet();
            dDeelnemerDAL = new DeelnemerDAL();
        }

        public int Create(DeelnemerBO d)
        {
            return dDeelnemerDAL.Create(d);
        }

        public DataSet Read()
        {

            return dDeelnemerDAL.Read();
        }
    }
}
