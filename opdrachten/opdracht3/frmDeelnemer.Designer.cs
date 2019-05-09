namespace opdracht3
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
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChipnummer = new System.Windows.Forms.TextBox();
            this.invoeren = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.tbRugnummer = new System.Windows.Forms.TextBox();
            this.tbDeelnemer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(35, 56);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(87, 13);
            this.label0.TabIndex = 0;
            this.label0.Text = "Naam deelnemer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rugnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chipnummer";
            // 
            // tbChipnummer
            // 
            this.tbChipnummer.Location = new System.Drawing.Point(152, 146);
            this.tbChipnummer.Name = "tbChipnummer";
            this.tbChipnummer.Size = new System.Drawing.Size(100, 20);
            this.tbChipnummer.TabIndex = 5;
            // 
            // invoeren
            // 
            this.invoeren.Location = new System.Drawing.Point(152, 185);
            this.invoeren.Name = "invoeren";
            this.invoeren.Size = new System.Drawing.Size(100, 23);
            this.invoeren.TabIndex = 6;
            this.invoeren.Text = "Invoeren";
            this.invoeren.UseVisualStyleBackColor = true;
            this.invoeren.Click += new System.EventHandler(this.invoeren_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(35, 211);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(217, 30);
            this.display.TabIndex = 7;
            // 
            // tbRugnummer
            // 
            this.tbRugnummer.Location = new System.Drawing.Point(152, 103);
            this.tbRugnummer.Name = "tbRugnummer";
            this.tbRugnummer.Size = new System.Drawing.Size(100, 20);
            this.tbRugnummer.TabIndex = 4;
            // 
            // tbDeelnemer
            // 
            this.tbDeelnemer.Location = new System.Drawing.Point(152, 53);
            this.tbDeelnemer.Name = "tbDeelnemer";
            this.tbDeelnemer.Size = new System.Drawing.Size(100, 20);
            this.tbDeelnemer.TabIndex = 1;
            // 
            // frmDeelnemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.display);
            this.Controls.Add(this.invoeren);
            this.Controls.Add(this.tbChipnummer);
            this.Controls.Add(this.tbRugnummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDeelnemer);
            this.Controls.Add(this.label0);
            this.Name = "frmDeelnemer";
            this.Text = "frmDeelnemer";
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChipnummer;
        private System.Windows.Forms.Button invoeren;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TextBox tbRugnummer;
        private System.Windows.Forms.TextBox tbDeelnemer;
    }
}