namespace CommonForms
{
    partial class FileSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDeselectAll = new System.Windows.Forms.Button();
            this.cmdSelectAll = new System.Windows.Forms.Button();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdReportBrowse = new System.Windows.Forms.Button();
            this.cmdProdTypeBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmdFileApply = new System.Windows.Forms.Button();
            this.cmdFileCancel = new System.Windows.Forms.Button();
            this.cmdFileOK = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDeselectAll);
            this.groupBox1.Controls.Add(this.cmdSelectAll);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saved Data";
            // 
            // cmdDeselectAll
            // 
            this.cmdDeselectAll.Location = new System.Drawing.Point(357, 91);
            this.cmdDeselectAll.Name = "cmdDeselectAll";
            this.cmdDeselectAll.Size = new System.Drawing.Size(81, 23);
            this.cmdDeselectAll.TabIndex = 2;
            this.cmdDeselectAll.Text = "Deselect All";
            this.cmdDeselectAll.UseVisualStyleBackColor = true;
            this.cmdDeselectAll.Click += new System.EventHandler(this.cmdDeselectAll_Click);
            // 
            // cmdSelectAll
            // 
            this.cmdSelectAll.Location = new System.Drawing.Point(7, 90);
            this.cmdSelectAll.Name = "cmdSelectAll";
            this.cmdSelectAll.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectAll.TabIndex = 1;
            this.cmdSelectAll.Text = "Select All";
            this.cmdSelectAll.UseVisualStyleBackColor = true;
            this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(224, 66);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(101, 17);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "Any other report";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(121, 66);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(86, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Error_Report";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Remote_Message";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(326, 43);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(83, 17);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "Producttype";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(326, 20);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(107, 17);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "Random_Sample";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(224, 43);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(94, 17);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Status_Report";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(224, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 17);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "EGA";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(121, 43);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(86, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Auto_Report";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(121, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Final_Report";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Entry_Report";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Test_Message";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdReportBrowse);
            this.groupBox2.Controls.Add(this.cmdProdTypeBrowse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(10, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder Paths";
            // 
            // cmdReportBrowse
            // 
            this.cmdReportBrowse.Location = new System.Drawing.Point(367, 47);
            this.cmdReportBrowse.Name = "cmdReportBrowse";
            this.cmdReportBrowse.Size = new System.Drawing.Size(71, 23);
            this.cmdReportBrowse.TabIndex = 2;
            this.cmdReportBrowse.Text = "Browse...";
            this.cmdReportBrowse.UseVisualStyleBackColor = true;
            this.cmdReportBrowse.Click += new System.EventHandler(this.cmdReportBrowse_Click);
            // 
            // cmdProdTypeBrowse
            // 
            this.cmdProdTypeBrowse.Location = new System.Drawing.Point(367, 15);
            this.cmdProdTypeBrowse.Name = "cmdProdTypeBrowse";
            this.cmdProdTypeBrowse.Size = new System.Drawing.Size(71, 23);
            this.cmdProdTypeBrowse.TabIndex = 2;
            this.cmdProdTypeBrowse.Text = "Browse...";
            this.cmdProdTypeBrowse.UseVisualStyleBackColor = true;
            this.cmdProdTypeBrowse.Click += new System.EventHandler(this.cmdProdTypeBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "XML Report folder path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Type folder path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "..\\xml\\types\\";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "..\\xml\\reports\\";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmdFileApply
            // 
            this.cmdFileApply.Location = new System.Drawing.Point(377, 225);
            this.cmdFileApply.Name = "cmdFileApply";
            this.cmdFileApply.Size = new System.Drawing.Size(75, 23);
            this.cmdFileApply.TabIndex = 2;
            this.cmdFileApply.Text = "Apply";
            this.cmdFileApply.UseVisualStyleBackColor = true;
            this.cmdFileApply.Click += new System.EventHandler(this.cmdFileApply_Click);
            // 
            // cmdFileCancel
            // 
            this.cmdFileCancel.Location = new System.Drawing.Point(296, 225);
            this.cmdFileCancel.Name = "cmdFileCancel";
            this.cmdFileCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdFileCancel.TabIndex = 3;
            this.cmdFileCancel.Text = "Cancel";
            this.cmdFileCancel.UseVisualStyleBackColor = true;
            this.cmdFileCancel.Click += new System.EventHandler(this.cmdFileCancel_Click);
            // 
            // cmdFileOK
            // 
            this.cmdFileOK.Location = new System.Drawing.Point(215, 225);
            this.cmdFileOK.Name = "cmdFileOK";
            this.cmdFileOK.Size = new System.Drawing.Size(75, 23);
            this.cmdFileOK.TabIndex = 4;
            this.cmdFileOK.Text = "OK";
            this.cmdFileOK.UseVisualStyleBackColor = true;
            this.cmdFileOK.Click += new System.EventHandler(this.cmdFileOK_Click);
            // 
            // FileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 256);
            this.ControlBox = false;
            this.Controls.Add(this.cmdFileOK);
            this.Controls.Add(this.cmdFileCancel);
            this.Controls.Add(this.cmdFileApply);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileSettings";
            this.ShowInTaskbar = false;
            this.Text = "File Settings";
            this.Load += new System.EventHandler(this.FileSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDeselectAll;
        private System.Windows.Forms.Button cmdSelectAll;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFileApply;
        private System.Windows.Forms.Button cmdFileCancel;
        private System.Windows.Forms.Button cmdFileOK;
        private System.Windows.Forms.Button cmdReportBrowse;
        private System.Windows.Forms.Button cmdProdTypeBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}