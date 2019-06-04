namespace Thomassen_Devon_IO2B4_Nepnieuws
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
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nepjournalistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nepnieuwsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venstersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.nepjournalistToolStripMenuItem,
            this.nepnieuwsToolStripMenuItem,
            this.venstersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "&Bestand";
            // 
            // nepjournalistToolStripMenuItem
            // 
            this.nepjournalistToolStripMenuItem.Name = "nepjournalistToolStripMenuItem";
            this.nepjournalistToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.nepjournalistToolStripMenuItem.Text = "Nepjournalist";
            this.nepjournalistToolStripMenuItem.Click += new System.EventHandler(this.nepjournalistToolStripMenuItem_Click);
            // 
            // nepnieuwsToolStripMenuItem
            // 
            this.nepnieuwsToolStripMenuItem.Name = "nepnieuwsToolStripMenuItem";
            this.nepnieuwsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.nepnieuwsToolStripMenuItem.Text = "Nepnieuws";
            this.nepnieuwsToolStripMenuItem.Click += new System.EventHandler(this.nepnieuwsToolStripMenuItem_Click);
            // 
            // venstersToolStripMenuItem
            // 
            this.venstersToolStripMenuItem.Name = "venstersToolStripMenuItem";
            this.venstersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.venstersToolStripMenuItem.Text = "Vensters";
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
            this.Text = "Toets Nepnieuws";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nepjournalistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nepnieuwsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venstersToolStripMenuItem;
    }
}

