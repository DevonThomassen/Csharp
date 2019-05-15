namespace opdracht4
{
    partial class frmBestellingen
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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbBottom = new System.Windows.Forms.ComboBox();
            this.input = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestelcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(20, 37);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pizza Grootte";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(500, 37);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pizza Bodem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aantal";
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Location = new System.Drawing.Point(140, 37);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(100, 21);
            this.cbPizza.TabIndex = 11;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbSize.Location = new System.Drawing.Point(260, 37);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(100, 21);
            this.cbSize.TabIndex = 12;
            // 
            // cbBottom
            // 
            this.cbBottom.FormattingEnabled = true;
            this.cbBottom.Items.AddRange(new object[] {
            "Classic",
            "Crush",
            "Fresh Pan"});
            this.cbBottom.Location = new System.Drawing.Point(380, 37);
            this.cbBottom.Name = "cbBottom";
            this.cbBottom.Size = new System.Drawing.Size(100, 21);
            this.cbBottom.TabIndex = 13;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(20, 77);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(220, 23);
            this.input.TabIndex = 14;
            this.input.Text = "Bestelling invoeren";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.name,
            this.size,
            this.bottom,
            this.amount});
            this.listView.Location = new System.Drawing.Point(20, 120);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(580, 97);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // code
            // 
            this.code.Text = "Bestelcode";
            this.code.Width = 150;
            // 
            // name
            // 
            this.name.Text = "Pizza";
            this.name.Width = 150;
            // 
            // size
            // 
            this.size.Text = "Pizza Grootte";
            this.size.Width = 100;
            // 
            // bottom
            // 
            this.bottom.Text = "Pizza Bodem";
            this.bottom.Width = 100;
            // 
            // amount
            // 
            this.amount.Text = "Aantal";
            this.amount.Width = 76;
            // 
            // frmBestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 241);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.input);
            this.Controls.Add(this.cbBottom);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBestellingen";
            this.Text = "Bestellingen";
            this.Activated += new System.EventHandler(this.frmLoad);
            this.Load += new System.EventHandler(this.frmLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbBottom;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader bottom;
        private System.Windows.Forms.ColumnHeader amount;
    }
}