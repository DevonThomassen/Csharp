namespace opdracht5
{
    partial class frmRegistratie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbChipnummer = new System.Windows.Forms.ComboBox();
            this.tbTijd = new System.Windows.Forms.TextBox();
            this.cbPunt = new System.Windows.Forms.ComboBox();
            this.tbJaar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invoeren = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.chipnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registratietijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registratiepunt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbChipnummer
            // 
            this.cbChipnummer.FormattingEnabled = true;
            this.cbChipnummer.Location = new System.Drawing.Point(20, 20);
            this.cbChipnummer.Name = "cbChipnummer";
            this.cbChipnummer.Size = new System.Drawing.Size(120, 21);
            this.cbChipnummer.TabIndex = 0;
            // 
            // tbTijd
            // 
            this.tbTijd.Location = new System.Drawing.Point(160, 20);
            this.tbTijd.Name = "tbTijd";
            this.tbTijd.Size = new System.Drawing.Size(100, 20);
            this.tbTijd.TabIndex = 1;
            // 
            // cbPunt
            // 
            this.cbPunt.FormattingEnabled = true;
            this.cbPunt.Items.AddRange(new object[] {
            "5km",
            "10km",
            "15km"});
            this.cbPunt.Location = new System.Drawing.Point(280, 20);
            this.cbPunt.Name = "cbPunt";
            this.cbPunt.Size = new System.Drawing.Size(75, 21);
            this.cbPunt.TabIndex = 2;
            // 
            // tbJaar
            // 
            this.tbJaar.Location = new System.Drawing.Point(376, 20);
            this.tbJaar.Name = "tbJaar";
            this.tbJaar.Size = new System.Drawing.Size(100, 20);
            this.tbJaar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chipnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registratietijd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registratiepunt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jaar";
            // 
            // invoeren
            // 
            this.invoeren.Location = new System.Drawing.Point(20, 100);
            this.invoeren.Name = "invoeren";
            this.invoeren.Size = new System.Drawing.Size(120, 23);
            this.invoeren.TabIndex = 8;
            this.invoeren.Text = "Invoeren";
            this.invoeren.UseVisualStyleBackColor = true;
            this.invoeren.Click += new System.EventHandler(this.invoeren_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.Location = new System.Drawing.Point(20, 153);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(49, 13);
            this.lbOutput.TabIndex = 9;
            this.lbOutput.Text = "HIDDEN";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chipnummer,
            this.registratietijd,
            this.registratiepunt,
            this.jaar});
            this.listView.Location = new System.Drawing.Point(20, 200);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(456, 100);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // chipnummer
            // 
            this.chipnummer.Text = "Chipnummer";
            this.chipnummer.Width = 150;
            // 
            // registratietijd
            // 
            this.registratietijd.Text = "Registratietijd";
            this.registratietijd.Width = 150;
            // 
            // registratiepunt
            // 
            this.registratiepunt.Text = "Registratiepunt";
            this.registratiepunt.Width = 100;
            // 
            // jaar
            // 
            this.jaar.Text = "Jaar";
            // 
            // frmRegistratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 321);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.invoeren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbJaar);
            this.Controls.Add(this.cbPunt);
            this.Controls.Add(this.tbTijd);
            this.Controls.Add(this.cbChipnummer);
            this.Name = "frmRegistratie";
            this.Text = "Registratie";
            this.Activated += new System.EventHandler(this.frm_Load);
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChipnummer;
        private System.Windows.Forms.TextBox tbTijd;
        private System.Windows.Forms.ComboBox cbPunt;
        private System.Windows.Forms.TextBox tbJaar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button invoeren;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader chipnummer;
        private System.Windows.Forms.ColumnHeader registratietijd;
        private System.Windows.Forms.ColumnHeader registratiepunt;
        private System.Windows.Forms.ColumnHeader jaar;
    }
}