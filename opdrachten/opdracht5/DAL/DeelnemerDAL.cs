using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    public class DeelnemerDAL
    {
        private static DataSet dsDeelnemer = new DataSet();

        // Constructor
        public DeelnemerDAL()
        {
            // Kijken of de table 
            if (dsDeelnemer.Tables["tblDeelnemer"] == null)
            {
                // Table maken
                DataTable table = new DataTable
                {
                    TableName = "tblDeelnemer"
                };

                // Colomumen tovoegen
                table.Columns.Add("naam", typeof(string));
                table.Columns.Add("rugnummer", typeof(int));
                table.Columns.Add("chipnummerH201", typeof(int));

                // Table toevoegen aan de dataset
                dsDeelnemer.Tables.Add(table.Copy());

                // Vullen tabel
                dsDeelnemer.Tables["tblDeelnemer"].Rows.Add("Henk", 1234, 5678);
            }
        }

        public int Create(DeelnemerBO d)
        {
            dsDeelnemer.Tables["tblDeelnemer"].Rows.Add(d.Naam, d.Rugnummer, d.ChipnummerH201);

            return 1;
        }

        public DataSet Read()
        {
            return dsDeelnemer;
        }
    }
}
