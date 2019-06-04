namespace opdracht5
{
    partial class frmDeelnemer
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbRugnummer = new System.Windows.Forms.TextBox();
            this.tbChipnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoeren = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rugnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chipnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(20, 20);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(150, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbRugnummer
            // 
            this.tbRugnummer.Location = new System.Drawing.Point(200, 20);
            this.tbRugnummer.Name = "tbRugnummer";
            this.tbRugnummer.Size = new System.Drawing.Size(100, 20);
            this.tbRugnummer.TabIndex = 1;
            // 
            // tbChipnummer
            // 
            this.tbChipnummer.Location = new System.Drawing.Point(330, 20);
            this.tbChipnummer.Name = "tbChipnummer";
            this.tbChipnummer.Size = new System.Drawing.Size(100, 20);
            this.tbChipnummer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naam deelnemer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rugnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chipnummer";
            // 
            // invoeren
            // 
            this.invoeren.Location = new System.Drawing.Point(20, 100);
            this.invoeren.Name = "invoeren";
            this.invoeren.Size = new System.Drawing.Size(100, 23);
            this.invoeren.TabIndex = 6;
            this.invoeren.Text = "Invoeren";
            this.invoeren.UseVisualStyleBackColor = true;
            this.invoeren.Click += new System.EventHandler(this.invoeren_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(20, 152);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(49, 13);
            this.lbOutput.TabIndex = 7;
            this.lbOutput.Text = "HIDDEN";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naam,
            this.rugnummer,
            this.chipnummer});
            this.listView.Location = new System.Drawing.Point(20, 200);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(410, 135);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // naam
            // 
            this.naam.Text = "Deelnemernaam";
            this.naam.Width = 200;
            // 
            // rugnummer
            // 
            this.rugnummer.Text = "Rugnummer";
            this.rugnummer.Width = 100;
            // 
            // chipnummer
            // 
            this.chipnummer.Text = "Chipnummer";
            this.chipnummer.Width = 106;
            // 
            // frmDeelnemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.invoeren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbChipnummer);
            this.Controls.Add(this.tbRugnummer);
            this.Controls.Add(this.tbNaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDeelnemer";
            this.Text = "Deelnemer";
            this.Activated += new System.EventHandler(this.frm_Load);
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbRugnummer;
        private System.Windows.Forms.TextBox tbChipnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button invoeren;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.ColumnHeader rugnummer;
        private System.Windows.Forms.ColumnHeader chipnummer;
    }
}