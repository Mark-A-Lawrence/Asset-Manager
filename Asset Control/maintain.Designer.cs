namespace Asset_Control
{
    partial class maintain
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
            this.MGrid1 = new System.Windows.Forms.DataGridView();
            this.dpicker = new System.Windows.Forms.DateTimePicker();
            this.txtupdate = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // MGrid1
            // 
            this.MGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MGrid1.Location = new System.Drawing.Point(25, 27);
            this.MGrid1.Name = "MGrid1";
            this.MGrid1.Size = new System.Drawing.Size(324, 263);
            this.MGrid1.TabIndex = 0;
            this.MGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MGrid1_CellClick);
            // 
            // dpicker
            // 
            this.dpicker.Location = new System.Drawing.Point(85, 376);
            this.dpicker.Name = "dpicker";
            this.dpicker.Size = new System.Drawing.Size(200, 20);
            this.dpicker.TabIndex = 1;
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(85, 415);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(75, 23);
            this.txtupdate.TabIndex = 2;
            this.txtupdate.Text = "Update";
            this.txtupdate.UseVisualStyleBackColor = true;
            this.txtupdate.Click += new System.EventHandler(this.Txtupdate_Click);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(85, 341);
            this.txt_code.Name = "txt_code";
            this.txt_code.ReadOnly = true;
            this.txt_code.Size = new System.Drawing.Size(200, 20);
            this.txt_code.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.dpicker);
            this.Controls.Add(this.MGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "maintain";
            this.ShowInTaskbar = false;
            this.Text = "maintain";
            ((System.ComponentModel.ISupportInitialize)(this.MGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MGrid1;
        private System.Windows.Forms.DateTimePicker dpicker;
        private System.Windows.Forms.Button txtupdate;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button button1;
    }
}