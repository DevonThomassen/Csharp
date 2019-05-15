namespace opdracht4
{
    partial class frmPizza
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
            this.input = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(20, 20);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(200, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(20, 60);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(200, 23);
            this.input.TabIndex = 1;
            this.input.Text = "Pizza invoeren";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // listView
            // 
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.Enabled = false;
            this.listView.Location = new System.Drawing.Point(20, 103);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(200, 97);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 221);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.input);
            this.Controls.Add(this.tbNaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPizza";
            this.Text = "Pizza\'s";
            this.Load += new System.EventHandler(this.frmLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.ListView listView;
    }
}