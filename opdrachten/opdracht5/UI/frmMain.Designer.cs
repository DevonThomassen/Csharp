namespace opdracht5
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deelnemerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registratieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deelnemerToolStripMenuItem,
            this.registratieToolStripMenuItem,
            this.vensterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // deelnemerToolStripMenuItem
            // 
            this.deelnemerToolStripMenuItem.Name = "deelnemerToolStripMenuItem";
            this.deelnemerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.deelnemerToolStripMenuItem.Text = "Deelnemer";
            this.deelnemerToolStripMenuItem.Click += new System.EventHandler(this.deelnemerToolStripMenuItem_Click);
            // 
            // registratieToolStripMenuItem
            // 
            this.registratieToolStripMenuItem.Name = "registratieToolStripMenuItem";
            this.registratieToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.registratieToolStripMenuItem.Text = "Registratie";
            this.registratieToolStripMenuItem.Click += new System.EventHandler(this.registratieToolStripMenuItem_Click);
            // 
            // vensterToolStripMenuItem
            // 
            this.vensterToolStripMenuItem.Name = "vensterToolStripMenuItem";
            this.vensterToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vensterToolStripMenuItem.Text = "Venster";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deelnemerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registratieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vensterToolStripMenuItem;
    }
}

