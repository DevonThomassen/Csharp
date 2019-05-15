namespace opdracht4
{
    partial class frmBezorging
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Button();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbSale = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.zip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huisnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bezorgdag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bezorgtijd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bestelcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actiecode";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(20, 77);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(220, 23);
            this.input.TabIndex = 6;
            this.input.Text = "Bezorging invoeren";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(20, 37);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(100, 20);
            this.tbZip.TabIndex = 7;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(140, 37);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 8;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(260, 37);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(100, 20);
            this.tbDay.TabIndex = 9;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(380, 37);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 10;
            // 
            // tbSale
            // 
            this.tbSale.Location = new System.Drawing.Point(620, 37);
            this.tbSale.Name = "tbSale";
            this.tbSale.Size = new System.Drawing.Size(100, 20);
            this.tbSale.TabIndex = 12;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zip,
            this.number,
            this.date,
            this.time,
            this.code,
            this.sale});
            this.listView.Location = new System.Drawing.Point(20, 120);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(700, 97);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // zip
            // 
            this.zip.Text = "Postcode";
            this.zip.Width = 150;
            // 
            // number
            // 
            this.number.Text = "Huisnummer";
            this.number.Width = 96;
            // 
            // date
            // 
            this.date.Text = "Bezorgdag";
            this.date.Width = 75;
            // 
            // time
            // 
            this.time.Text = "Bezorgtijd";
            this.time.Width = 75;
            // 
            // code
            // 
            this.code.Text = "Bestelcode";
            this.code.Width = 150;
            // 
            // sale
            // 
            this.sale.Text = "Actiecode";
            this.sale.Width = 150;
            // 
            // cbCode
            // 
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(500, 37);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(100, 21);
            this.cbCode.TabIndex = 14;
            // 
            // frmBezorging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 241);
            this.Controls.Add(this.cbCode);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tbSale);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBezorging";
            this.Text = "Bezorgingen";
            this.Activated += new System.EventHandler(this.frmLoad);
            this.Load += new System.EventHandler(this.frmLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.ColumnHeader zip;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader sale;
    }
}