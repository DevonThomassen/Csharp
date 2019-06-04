using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    public class RegistratieDAL
    {
        private static DataSet dsRegistratie = new DataSet();

        public RegistratieDAL()
        {
            if (dsRegistratie.Tables["tblRegistratie"] == null)
            {
                //tabel aanmaken
                DataTable table = new DataTable
                {
                    TableName = "tblRegistratie"
                };

                //Colommen toevoegen
                table.Columns.Add("chipNummerD201", typeof(int));
                table.Columns.Add("registratieTijd", typeof(int));
                table.Columns.Add("registratiePuntW501", typeof(string));
                table.Columns.Add("jaar", typeof(int));

                //Tabel aan dataset toevoegen
                dsRegistratie.Tables.Add(table.Copy());
            }
        }

        public int Create(RegistratieBO r)
        {
            //Row aan table toevoegen
            dsRegistratie.Tables["tblRegistratie"].Rows.Add(r.ChipnummerD201, r.RegistratieTijd, r.RegistratiePuntW501, r.Jaar);

            return 1;
        }

        public DataSet Read()
        {
            return dsRegistratie; // dataset terug schieten
        }
    }
}
