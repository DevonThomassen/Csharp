namespace Thomassen_Devon_IO2B4_Nepnieuws
{
    partial class frmNepjournalist
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
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.invoeren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(22, 43);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbNummer
            // 
            this.tbNummer.Location = new System.Drawing.Point(165, 43);
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.Size = new System.Drawing.Size(100, 20);
            this.tbNummer.TabIndex = 1;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "V"});
            this.cbSex.Location = new System.Drawing.Point(307, 43);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 21);
            this.cbSex.TabIndex = 2;
            // 
            // invoeren
            // 
            this.invoeren.Location = new System.Drawing.Point(22, 142);
            this.invoeren.Name = "invoeren";
            this.invoeren.Size = new System.Drawing.Size(120, 33);
            this.invoeren.TabIndex = 3;
            this.invoeren.Text = "Invoeren";
            this.invoeren.UseVisualStyleBackColor = true;
            this.invoeren.Click += new System.EventHandler(this.invoeren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Journalistnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Journalistnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geslacht";
            // 
            // lbOutput
            // 
            this.lbOutput.Location = new System.Drawing.Point(22, 215);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(406, 31);
            this.lbOutput.TabIndex = 7;
            this.lbOutput.Text = "output";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(25, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmNepjournalist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 386);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoeren);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbNummer);
            this.Controls.Add(this.tbNaam);
            this.Name = "frmNepjournalist";
            this.Text = "Nepjournalist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Button invoeren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.ListView listView1;
    }
}