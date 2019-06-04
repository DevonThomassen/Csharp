using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht5
{
    public partial class frmRegistratie : Form
    {
        public frmRegistratie()
        {
            InitializeComponent();
        }

        private void invoeren_Click(object sender, EventArgs e)
        {
            RegistratieBO r = new RegistratieBO();
            RegistratieBLL registratieBLL = new RegistratieBLL();

            int parse;
            Int32.TryParse(cbChipnummer.Text, out parse);
            r.ChipnummerD201 = parse;

            Int32.TryParse(tbTijd.Text, out parse);
            r.RegistratieTijd = parse;

            r.RegistratiePuntW501 = cbPunt.Text;

            Int32.TryParse(tbJaar.Text, out parse);
            r.Jaar = parse;

            // Update Form
            if (registratieBLL.Create(r) > 0)
            {
                registratieBLL.Read();
                // UI
                string[] array = new string[4];
                array[0] = r.ChipnummerD201.ToString();
                array[1] = r.RegistratieTijd.ToString();
                array[2] = r.RegistratiePuntW501;
                array[3] = r.Jaar.ToString();

                ListViewItem item = new ListViewItem(array);
                listView.Items.Add(item);
            }

            lbOutput.Text = $"Chipnummer {cbChipnummer.Text} registreert voor NYCM in het jaartal {tbJaar.Text} bij het registratiepunt {cbPunt.Text} de registratietijd {tbTijd.Text} minuten";
        }

        private void frm_Load(object sender, EventArgs e)
        {
            RegistratieBLL r = new RegistratieBLL();
            DeelnemerBLL d = new DeelnemerBLL();

            DataSet ds = r.Read();
            DataSet dsDeelnemer = d.Read();

            // Vullen listview
            listView.Items.Clear();
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow row = ds.Tables[0].Rows[i];
                    if (row.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item  = new ListViewItem(new[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() });
                        listView.Items.Add(item);
                    }

                    listView.Sort();
                }
            }

            // Vullen cb
            cbChipnummer.Items.Clear();
            if (dsDeelnemer.Tables.Count > 0)
            {
                for (int i = 0; i < dsDeelnemer.Tables[0].Rows.Count; i++)
                {
                    DataRow row = dsDeelnemer.Tables[0].Rows[i];
                    if (row.RowState != DataRowState.Deleted)
                    {
                        cbChipnummer.Items.Add(row[2].ToString());
                    }
                }
            }
        }
    }
}
