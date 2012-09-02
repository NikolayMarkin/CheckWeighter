namespace ServerTestGUI
{
    partial class ServerTestGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerTestGUI));
            this.cmdStartButton = new System.Windows.Forms.Button();
            this.cmdStopButton = new System.Windows.Forms.Button();
            this.cmdIPSettings = new System.Windows.Forms.Button();
            this.cmdClearbutton = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.cmdFileSettings = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // cmdStartButton
            // 
            this.cmdStartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdStartButton.Location = new System.Drawing.Point(96, 437);
            this.cmdStartButton.Name = "cmdStartButton";
            this.cmdStartButton.Size = new System.Drawing.Size(107, 45);
            this.cmdStartButton.TabIndex = 0;
            this.cmdStartButton.Text = "Start Server";
            this.cmdStartButton.UseVisualStyleBackColor = true;
            this.cmdStartButton.Click += new System.EventHandler(this.cmdStartButton_Click);
            // 
            // cmdStopButton
            // 
            this.cmdStopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdStopButton.Location = new System.Drawing.Point(210, 437);
            this.cmdStopButton.Name = "cmdStopButton";
            this.cmdStopButton.Size = new System.Drawing.Size(96, 45);
            this.cmdStopButton.TabIndex = 0;
            this.cmdStopButton.Text = "Stop Server";
            this.cmdStopButton.UseVisualStyleBackColor = true;
            this.cmdStopButton.Click += new System.EventHandler(this.cmdStopButton_Click);
            // 
            // cmdIPSettings
            // 
            this.cmdIPSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdIPSettings.Location = new System.Drawing.Point(313, 437);
            this.cmdIPSettings.Name = "cmdIPSettings";
            this.cmdIPSettings.Size = new System.Drawing.Size(94, 45);
            this.cmdIPSettings.TabIndex = 0;
            this.cmdIPSettings.Text = "IP Settings";
            this.cmdIPSettings.UseVisualStyleBackColor = true;
            this.cmdIPSettings.Click += new System.EventHandler(this.cmdIPSettings_Click);
            // 
            // cmdClearbutton
            // 
            this.cmdClearbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdClearbutton.Location = new System.Drawing.Point(513, 437);
            this.cmdClearbutton.Name = "cmdClearbutton";
            this.cmdClearbutton.Size = new System.Drawing.Size(86, 45);
            this.cmdClearbutton.TabIndex = 0;
            this.cmdClearbutton.Tag = "Clear";
            this.cmdClearbutton.Text = "Clear";
            this.cmdClearbutton.UseVisualStyleBackColor = true;
            this.cmdClearbutton.Click += new System.EventHandler(this.cmdClearbutton_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdExit.Location = new System.Drawing.Point(606, 437);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(84, 45);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Location = new System.Drawing.Point(12, 94);
            this.display.MaxLength = 50000;
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.display.Size = new System.Drawing.Size(773, 187);
            this.display.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Message:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Report:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Report:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Auto Report:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Indiv. Weight:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "SPCfWin Data:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Product type:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(178, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(178, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(178, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(324, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(58, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Location = new System.Drawing.Point(324, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(58, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Location = new System.Drawing.Point(478, 11);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(56, 20);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Location = new System.Drawing.Point(478, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(56, 20);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "0";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.Location = new System.Drawing.Point(632, 11);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(58, 20);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "0";
            // 
            // textBox0
            // 
            this.textBox0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox0.Location = new System.Drawing.Point(632, 37);
            this.textBox0.Name = "textBox0";
            this.textBox0.ReadOnly = true;
            this.textBox0.Size = new System.Drawing.Size(58, 20);
            this.textBox0.TabIndex = 3;
            this.textBox0.Text = "0";
            // 
            // cmdFileSettings
            // 
            this.cmdFileSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdFileSettings.Location = new System.Drawing.Point(414, 438);
            this.cmdFileSettings.Name = "cmdFileSettings";
            this.cmdFileSettings.Size = new System.Drawing.Size(92, 42);
            this.cmdFileSettings.TabIndex = 4;
            this.cmdFileSettings.Text = "File Settings";
            this.cmdFileSettings.UseVisualStyleBackColor = true;
            this.cmdFileSettings.Click += new System.EventHandler(this.cmdFileSettings_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusLabel.Location = new System.Drawing.Point(270, 68);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            this.statusLabel.TabIndex = 5;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(210, 329);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(96, 53);
            this.cmdStart.TabIndex = 6;
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdSettings
            // 
            this.cmdSettings.Location = new System.Drawing.Point(313, 329);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(94, 53);
            this.cmdSettings.TabIndex = 7;
            this.cmdSettings.Text = "Настройки";
            this.cmdSettings.UseVisualStyleBackColor = true;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Запись отчета в ручном режиме";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Программа учета готовой продукции";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // ServerTestGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdSettings);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.cmdFileSettings);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClearbutton);
            this.Controls.Add(this.cmdIPSettings);
            this.Controls.Add(this.cmdStopButton);
            this.Controls.Add(this.cmdStartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ServerTestGUI";
            this.Text = "Учет готовой продукции";
            this.Load += new System.EventHandler(this.ServerTestGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStartButton;
        private System.Windows.Forms.Button cmdStopButton;
        private System.Windows.Forms.Button cmdIPSettings;
        private System.Windows.Forms.Button cmdClearbutton;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Button cmdFileSettings;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

