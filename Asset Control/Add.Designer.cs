namespace Asset_Control
{
    partial class Add
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
            this.location = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ownership = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.serial_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.remarks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catergory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(269, 129);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(98, 21);
            this.location.TabIndex = 49;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(460, 210);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(56, 20);
            this.quantity.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Description";
            // 
            // ownership
            // 
            this.ownership.FormattingEnabled = true;
            this.ownership.Items.AddRange(new object[] {
            "Toll Authority/DBJ",
            "DBJ",
            "Toll Authority",
            "Others"});
            this.ownership.Location = new System.Drawing.Point(135, 214);
            this.ownership.Name = "ownership";
            this.ownership.Size = new System.Drawing.Size(232, 21);
            this.ownership.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Ownership";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "View Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Serial Number";
            // 
            // serial_num
            // 
            this.serial_num.Location = new System.Drawing.Point(460, 171);
            this.serial_num.Name = "serial_num";
            this.serial_num.Size = new System.Drawing.Size(231, 20);
            this.serial_num.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Remarks";
            // 
            // remarks
            // 
            this.remarks.FormattingEnabled = true;
            this.remarks.Items.AddRange(new object[] {
            "Good Condition",
            "Fair Condition",
            "Fairly Bad Condition",
            "Very Bad Condition"});
            this.remarks.Location = new System.Drawing.Point(136, 170);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(231, 21);
            this.remarks.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cost";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(136, 128);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(76, 20);
            this.cost.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Make/Model";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(460, 129);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(231, 20);
            this.model.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date Acquired";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(136, 87);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(211, 20);
            this.date.TabIndex = 31;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(136, 256);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(555, 99);
            this.Description.TabIndex = 30;
            this.Description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(460, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 59);
            this.name.TabIndex = 28;
            this.name.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Asset Catergory";
            // 
            // catergory
            // 
            this.catergory.FormattingEnabled = true;
            this.catergory.Items.AddRange(new object[] {
            "Plant, Machinery & Equipment",
            "Electronics ",
            "Furniture, Office Equipment, Fixtures & Fittings",
            "Office Stationery & Supplies",
            "Motor Vehicles",
            "Specialist Assets"});
            this.catergory.Location = new System.Drawing.Point(135, 51);
            this.catergory.Name = "catergory";
            this.catergory.Size = new System.Drawing.Size(212, 21);
            this.catergory.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Quantity:";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.location);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ownership);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serial_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.remarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catergory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ownership;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serial_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catergory;
        private System.Windows.Forms.Label label11;
    }
}