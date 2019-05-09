namespace opdracht3
{
    partial class frmLeerlinggegevens
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbChipnummer = new System.Windows.Forms.Label();
            this.invoeren = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.tbRegistratieTijd = new System.Windows.Forms.TextBox();
            this.tbRegistratiePunt = new System.Windows.Forms.TextBox();
            this.tbJaar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chipnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registratietijd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registratiepunt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jaar";
            // 
            // lbChipnummer
            // 
            this.lbChipnummer.AutoSize = true;
            this.lbChipnummer.Location = new System.Drawing.Point(139, 66);
            this.lbChipnummer.Name = "lbChipnummer";
            this.lbChipnummer.Size = new System.Drawing.Size(13, 13);
            this.lbChipnummer.TabIndex = 7;
            this.lbChipnummer.Text = "0";
            // 
            // invoeren
            // 
            this.invoeren.Location = new System.Drawing.Point(139, 192);
            this.invoeren.Name = "invoeren";
            this.invoeren.Size = new System.Drawing.Size(100, 23);
            this.invoeren.TabIndex = 8;
            this.invoeren.Text = "Invoeren";
            this.invoeren.UseVisualStyleBackColor = true;
            this.invoeren.Click += new System.EventHandler(this.invoeren_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(45, 220);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(194, 62);
            this.display.TabIndex = 9;
            // 
            // tbRegistratieTijd
            // 
            this.tbRegistratieTijd.Location = new System.Drawing.Point(139, 94);
            this.tbRegistratieTijd.Name = "tbRegistratieTijd";
            this.tbRegistratieTijd.Size = new System.Drawing.Size(100, 20);
            this.tbRegistratieTijd.TabIndex = 10;
            // 
            // tbRegistratiePunt
            // 
            this.tbRegistratiePunt.Location = new System.Drawing.Point(139, 125);
            this.tbRegistratiePunt.Name = "tbRegistratiePunt";
            this.tbRegistratiePunt.Size = new System.Drawing.Size(100, 20);
            this.tbRegistratiePunt.TabIndex = 11;
            // 
            // tbJaar
            // 
            this.tbJaar.Location = new System.Drawing.Point(139, 154);
            this.tbJaar.Name = "tbJaar";
            this.tbJaar.Size = new System.Drawing.Size(100, 20);
            this.tbJaar.TabIndex = 12;
            // 
            // frmLeerlinggegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.tbJaar);
            this.Controls.Add(this.tbRegistratiePunt);
            this.Controls.Add(this.tbRegistratieTijd);
            this.Controls.Add(this.display);
            this.Controls.Add(this.invoeren);
            this.Controls.Add(this.lbChipnummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLeerlinggegevens";
            this.Text = "Registratie";
            this.Activated += new System.EventHandler(this.frm_Load);
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbChipnummer;
        private System.Windows.Forms.Button invoeren;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TextBox tbRegistratieTijd;
        private System.Windows.Forms.TextBox tbRegistratiePunt;
        private System.Windows.Forms.TextBox tbJaar;
    }
}