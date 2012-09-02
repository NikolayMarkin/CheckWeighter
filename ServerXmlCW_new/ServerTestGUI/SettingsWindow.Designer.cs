namespace ServerXmlCW
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.localPortNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbName = new System.Windows.Forms.TextBox();
            this.checkBDName = new System.Windows.Forms.CheckBox();
            this.pathToDBName = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(196, 329);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Закрыть";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(298, 329);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(96, 23);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Редактировать";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(412, 329);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Сохранить";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Локальный порт TCP/IP:";
            // 
            // localPortNumber
            // 
            this.localPortNumber.Location = new System.Drawing.Point(156, 6);
            this.localPortNumber.Name = "localPortNumber";
            this.localPortNumber.Size = new System.Drawing.Size(115, 20);
            this.localPortNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "при изменении параметра \r\nнеобходимо перезапустить сервер!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя базы данных:";
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(156, 38);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(115, 20);
            this.dbName.TabIndex = 7;
            // 
            // checkBDName
            // 
            this.checkBDName.AutoSize = true;
            this.checkBDName.Location = new System.Drawing.Point(280, 40);
            this.checkBDName.Name = "checkBDName";
            this.checkBDName.Size = new System.Drawing.Size(105, 17);
            this.checkBDName.TabIndex = 8;
            this.checkBDName.Text = "брать из файла";
            this.checkBDName.UseVisualStyleBackColor = true;
            this.checkBDName.CheckedChanged += new System.EventHandler(this.checkBDName_CheckedChanged);
            // 
            // pathToDBName
            // 
            this.pathToDBName.Location = new System.Drawing.Point(392, 37);
            this.pathToDBName.Name = "pathToDBName";
            this.pathToDBName.Size = new System.Drawing.Size(115, 20);
            this.pathToDBName.TabIndex = 9;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(522, 34);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowse.TabIndex = 10;
            this.cmdBrowse.Text = "Обзор";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.pathToDBName);
            this.Controls.Add(this.checkBDName);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.localPortNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localPortNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.CheckBox checkBDName;
        private System.Windows.Forms.TextBox pathToDBName;
        private System.Windows.Forms.Button cmdBrowse;
    }
}