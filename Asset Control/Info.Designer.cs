namespace Asset_Control
{
    partial class Info
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.remarks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maintenance ETA Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "null";
            // 
            // serial
            // 
            this.serial.AutoSize = true;
            this.serial.Location = new System.Drawing.Point(106, 147);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(23, 13);
            this.serial.TabIndex = 25;
            this.serial.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Model & Serial number:";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(47, 123);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(23, 13);
            this.cost.TabIndex = 23;
            this.cost.Text = "null";
            // 
            // remarks
            // 
            this.remarks.AutoSize = true;
            this.remarks.Location = new System.Drawing.Point(53, 99);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(23, 13);
            this.remarks.TabIndex = 22;
            this.remarks.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Value: $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Condition:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(121, 177);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(23, 13);
            this.Date.TabIndex = 19;
            this.Date.Text = "null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Modify Maintenance";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 30);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.Panel1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Code:";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(37, 76);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(23, 13);
            this.code.TabIndex = 14;
            this.code.Text = "null";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 253);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.remarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.ShowInTaskbar = false;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Info_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Info_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label remarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label code;
    }
}