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
    public partial class frmDeelnemer : Form
    {
        public frmDeelnemer()
        {
            InitializeComponent();
        }

        private void invoeren_Click(object sender, EventArgs e)
        {
            DeelnemerBO d = new DeelnemerBO();
            DeelnemerBLL deelnemerBLL = new DeelnemerBLL();

            d.Naam = tbNaam.Text;
            try { d.Rugnummer = Convert.ToInt32(tbRugnummer.Text); }
            catch { d.Rugnummer = 0; }
            // Int32.TryParse(tbRugnummer.Text, out parse);
            try { d.ChipnummerH201 = Convert.ToInt32(tbChipnummer.Text); }
            catch { d.ChipnummerH201 = 0; }
            // Int32.TryParse(tbChipnummer.Text, out parse);
            
            // Update Form
            if (deelnemerBLL.Create(d) > 0)
            {
                deelnemerBLL.Read();
                // UI
                string[] array = new string[3];
                array[0] = d.Naam;
                array[1] = d.Rugnummer.ToString();
                array[2] = d.ChipnummerH201.ToString();

                ListViewItem item = new ListViewItem(array);
                listView.Items.Add(item);
            }

            // UI
            lbOutput.Text = $"Deelnemer {tbNaam.Text} heeft het rugnummer {tbRugnummer.Text} en chipnummer {tbChipnummer.Text}";
        }

        private void frm_Load(object sender, EventArgs e)
        {
            DeelnemerBLL d = new DeelnemerBLL();

            listView.Items.Clear();
            DataSet ds = d.Read();

            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow row = ds.Tables[0].Rows[i];
                    if (row.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item = new ListViewItem(new[] { row[0].ToString(), row[1].ToString(), row[2].ToString() });
                        listView.Items.Add(item);
                    }
                    listView.Sort();
                }
            }
        }
    }
}
