namespace CommonForms
{
    partial class IPSettings
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
            this.cmdIPSettingsClose = new System.Windows.Forms.Button();
            this.cmdIPSettingsEdit = new System.Windows.Forms.Button();
            this.cmdIPSettingsSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdIPSettingsClose
            // 
            this.cmdIPSettingsClose.Location = new System.Drawing.Point(15, 83);
            this.cmdIPSettingsClose.Name = "cmdIPSettingsClose";
            this.cmdIPSettingsClose.Size = new System.Drawing.Size(50, 22);
            this.cmdIPSettingsClose.TabIndex = 0;
            this.cmdIPSettingsClose.Text = "Close";
            this.cmdIPSettingsClose.UseVisualStyleBackColor = true;
            this.cmdIPSettingsClose.Click += new System.EventHandler(this.cmdIPSettingsClose_Click);
            // 
            // cmdIPSettingsEdit
            // 
            this.cmdIPSettingsEdit.Location = new System.Drawing.Point(71, 83);
            this.cmdIPSettingsEdit.Name = "cmdIPSettingsEdit";
            this.cmdIPSettingsEdit.Size = new System.Drawing.Size(66, 22);
            this.cmdIPSettingsEdit.TabIndex = 0;
            this.cmdIPSettingsEdit.Text = "Edit";
            this.cmdIPSettingsEdit.UseVisualStyleBackColor = true;
            this.cmdIPSettingsEdit.Click += new System.EventHandler(this.cmdIPSettingsEdit_Click);
            // 
            // cmdIPSettingsSave
            // 
            this.cmdIPSettingsSave.Location = new System.Drawing.Point(143, 83);
            this.cmdIPSettingsSave.Name = "cmdIPSettingsSave";
            this.cmdIPSettingsSave.Size = new System.Drawing.Size(66, 22);
            this.cmdIPSettingsSave.TabIndex = 0;
            this.cmdIPSettingsSave.Text = "Save";
            this.cmdIPSettingsSave.UseVisualStyleBackColor = true;
            this.cmdIPSettingsSave.Click += new System.EventHandler(this.cmdIPSettingsSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "59000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Local Server Port";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "59001";
            // 
            // IPSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 112);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdIPSettingsSave);
            this.Controls.Add(this.cmdIPSettingsEdit);
            this.Controls.Add(this.cmdIPSettingsClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "IPSettings";
            this.ShowInTaskbar = false;
            this.Text = "IP Settings";
            this.Load += new System.EventHandler(this.IPSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cmdIPSettingsClose;
        private System.Windows.Forms.Button cmdIPSettingsEdit;
        private System.Windows.Forms.Button cmdIPSettingsSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}