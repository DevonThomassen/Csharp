namespace opdracht2
{
    partial class frmHoofdVenster
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
            this.components = new System.ComponentModel.Container();
            this.menuHoofd = new System.Windows.Forms.MenuStrip();
            this.cmMenuHoofd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bovenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ladenConfiguratieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanConfiguratieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapgewijsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankschikkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onderElkaarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naastelkaarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleVensterSluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuHoofd.SuspendLayout();
            this.cmMenuHoofd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHoofd
            // 
            this.menuHoofd.ContextMenuStrip = this.cmMenuHoofd;
            this.menuHoofd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.toevoegenToolStripMenuItem,
            this.overzichtToolStripMenuItem,
            this.vensterToolStripMenuItem});
            this.menuHoofd.Location = new System.Drawing.Point(0, 0);
            this.menuHoofd.Name = "menuHoofd";
            this.menuHoofd.Size = new System.Drawing.Size(800, 24);
            this.menuHoofd.TabIndex = 0;
            this.menuHoofd.Text = "menuStrip1";
            // 
            // cmMenuHoofd
            // 
            this.cmMenuHoofd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bovenToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.rechtsToolStripMenuItem,
            this.bottomToolStripMenuItem,
            this.toolStripSeparator2,
            this.ladenConfiguratieToolStripMenuItem,
            this.opslaanConfiguratieToolStripMenuItem});
            this.cmMenuHoofd.Name = "cmMenuHoofd";
            this.cmMenuHoofd.Size = new System.Drawing.Size(187, 142);
            // 
            // bovenToolStripMenuItem
            // 
            this.bovenToolStripMenuItem.Name = "bovenToolStripMenuItem";
            this.bovenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bovenToolStripMenuItem.Text = "Boven";
            this.bovenToolStripMenuItem.Click += new System.EventHandler(this.bovenToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.linksToolStripMenuItem.Text = "Links";
            this.linksToolStripMenuItem.Click += new System.EventHandler(this.linksToolStripMenuItem_Click);
            // 
            // rechtsToolStripMenuItem
            // 
            this.rechtsToolStripMenuItem.Name = "rechtsToolStripMenuItem";
            this.rechtsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.rechtsToolStripMenuItem.Text = "Rechts";
            this.rechtsToolStripMenuItem.Click += new System.EventHandler(this.rechtsToolStripMenuItem_Click);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bottomToolStripMenuItem.Text = "Bottom";
            this.bottomToolStripMenuItem.Click += new System.EventHandler(this.bottomToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // ladenConfiguratieToolStripMenuItem
            // 
            this.ladenConfiguratieToolStripMenuItem.Name = "ladenConfiguratieToolStripMenuItem";
            this.ladenConfiguratieToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ladenConfiguratieToolStripMenuItem.Text = "Laden Configuratie";
            this.ladenConfiguratieToolStripMenuItem.Click += new System.EventHandler(this.ladenConfiguratieToolStripMenuItem_Click);
            // 
            // opslaanConfiguratieToolStripMenuItem
            // 
            this.opslaanConfiguratieToolStripMenuItem.Name = "opslaanConfiguratieToolStripMenuItem";
            this.opslaanConfiguratieToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.opslaanConfiguratieToolStripMenuItem.Text = "Opslaan Configuratie";
            this.opslaanConfiguratieToolStripMenuItem.Click += new System.EventHandler(this.opslaanConfiguratieToolStripMenuItem_Click);
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "&Bestand";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.persoonToolStripMenuItem});
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.toevoegenToolStripMenuItem.Text = "Toevoegen";
            // 
            // persoonToolStripMenuItem
            // 
            this.persoonToolStripMenuItem.Name = "persoonToolStripMenuItem";
            this.persoonToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.persoonToolStripMenuItem.Text = "Persoon";
            this.persoonToolStripMenuItem.Click += new System.EventHandler(this.persoonToolStripMenuItem_Click);
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hardwareToolStripMenuItem});
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            // 
            // hardwareToolStripMenuItem
            // 
            this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
            this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hardwareToolStripMenuItem.Text = "Hardware";
            this.hardwareToolStripMenuItem.Click += new System.EventHandler(this.hardwareToolStripMenuItem_Click);
            // 
            // vensterToolStripMenuItem
            // 
            this.vensterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trapgewijsToolStripMenuItem,
            this.rankschikkenToolStripMenuItem,
            this.alleVensterSluitenToolStripMenuItem});
            this.vensterToolStripMenuItem.Name = "vensterToolStripMenuItem";
            this.vensterToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vensterToolStripMenuItem.Text = "&Venster";
            // 
            // trapgewijsToolStripMenuItem
            // 
            this.trapgewijsToolStripMenuItem.Name = "trapgewijsToolStripMenuItem";
            this.trapgewijsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trapgewijsToolStripMenuItem.Text = "&Trapgewijs";
            this.trapgewijsToolStripMenuItem.Click += new System.EventHandler(this.trapgewijsToolStripMenuItem_Click);
            // 
            // rankschikkenToolStripMenuItem
            // 
            this.rankschikkenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onderElkaarToolStripMenuItem,
            this.naastelkaarToolStripMenuItem});
            this.rankschikkenToolStripMenuItem.Name = "rankschikkenToolStripMenuItem";
            this.rankschikkenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rankschikkenToolStripMenuItem.Text = "&Rankschikken";
            // 
            // onderElkaarToolStripMenuItem
            // 
            this.onderElkaarToolStripMenuItem.Name = "onderElkaarToolStripMenuItem";
            this.onderElkaarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onderElkaarToolStripMenuItem.Text = "&Onder elkaar";
            this.onderElkaarToolStripMenuItem.Click += new System.EventHandler(this.onderElkaarToolStripMenuItem_Click);
            // 
            // naastelkaarToolStripMenuItem
            // 
            this.naastelkaarToolStripMenuItem.Name = "naastelkaarToolStripMenuItem";
            this.naastelkaarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.naastelkaarToolStripMenuItem.Text = "&Naast elkaar";
            this.naastelkaarToolStripMenuItem.Click += new System.EventHandler(this.naastelkaarToolStripMenuItem_Click);
            // 
            // alleVensterSluitenToolStripMenuItem
            // 
            this.alleVensterSluitenToolStripMenuItem.Name = "alleVensterSluitenToolStripMenuItem";
            this.alleVensterSluitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alleVensterSluitenToolStripMenuItem.Text = "Alle venster sluiten";
            this.alleVensterSluitenToolStripMenuItem.Click += new System.EventHandler(this.alleVensterSluitenToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // frmHoofdVenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuHoofd);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHoofd;
            this.Name = "frmHoofdVenster";
            this.Text = "Form1";
            this.menuHoofd.ResumeLayout(false);
            this.menuHoofd.PerformLayout();
            this.cmMenuHoofd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHoofd;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmMenuHoofd;
        private System.Windows.Forms.ToolStripMenuItem bovenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vensterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapgewijsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankschikkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onderElkaarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naastelkaarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleVensterSluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ladenConfiguratieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanConfiguratieToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

