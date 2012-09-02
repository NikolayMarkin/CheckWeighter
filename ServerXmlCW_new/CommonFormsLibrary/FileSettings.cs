using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CWXmlStack;
// ADD-START 08142007 EG
using System.IO;
// ADD-END 08142007 EG

namespace CommonForms
{
    public partial class FileSettings : Form
    {
        FileStore parent;
        CWXmlSaveSettings settings;

        // ADD-START 08142007 EG
        bool blnTypeChanged;
        bool blnReportChanged;
        bool blnOptionChanged;
        // ADD-END 08142007 EG

        public FileSettings()
        {
            InitializeComponent();
            cmdFileApply.Enabled = false;
            
        }
        public FileSettings(FileStore parent)
        {
            InitializeComponent();
            this.parent = parent;
            settings = parent.SaveSettings.clone();
            cmdFileApply.Enabled = false;

            checkBox1.Checked = settings.toSave[0];
            checkBox2.Checked = settings.toSave[4];
            checkBox3.Checked = settings.toSave[8];
            checkBox4.Checked = settings.toSave[1];
            checkBox5.Checked = settings.toSave[5];
            checkBox6.Checked = settings.toSave[9];
            checkBox7.Checked = settings.toSave[2];
            checkBox8.Checked = settings.toSave[6];
            checkBox9.Checked = settings.toSave[10];
            checkBox10.Checked = settings.toSave[3];
            checkBox11.Checked = settings.toSave[7];

            textBox1.Text = settings.productTypeFolderPath;
            textBox2.Text = settings.ewkReportFolderPath;

            // ADD-START 08142007 EG
            blnTypeChanged = false;
            blnReportChanged = false;
            blnOptionChanged = false;
            // ADD-END 08142007 EG
        }

        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = true;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;
            this.checkBox4.Checked = true;
            this.checkBox5.Checked = true;
            this.checkBox6.Checked = true;
            this.checkBox7.Checked = true;
            this.checkBox8.Checked = true;
            this.checkBox9.Checked = true;
            this.checkBox10.Checked = true;
            this.checkBox11.Checked = true;

            this.cmdFileApply.Enabled = true;

            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG


        }

        private void cmdDeselectAll_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox10.Checked = false;
            this.checkBox11.Checked = false;
            
            this.cmdFileApply.Enabled = true;

            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[0] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[4] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[8] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[1] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[5] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[9] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[2] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[6] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[10] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[3] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            settings.toSave[7] = b.Checked;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08142007 EG
            blnOptionChanged = true;
            // ADD-END 08142007 EG
        }

        private void cmdFileOK_Click(object sender, EventArgs e)
        {          
            // MOD-START 08142007 EG
            if (blnReportChanged || blnTypeChanged || blnOptionChanged)
            {
                if (saveFolderSettings())
                {
                    parent.SaveSettings = settings;
                    blnOptionChanged = false;
                    blnReportChanged = false;
                    blnTypeChanged = false;
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
            // MOD-END 08142007 EG
        }

        private void cmdFileCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            cmdFileApply.Enabled = false;
            // ADD-START 08142007 EG
            blnOptionChanged = false;
            blnReportChanged = false;
            blnTypeChanged = false;
            // ADD-END 08142007 EG
        }

        private void cmdFileApply_Click(object sender, EventArgs e)
        {                      
            // MOD-START 08142007 EG
            if (blnReportChanged || blnTypeChanged || blnOptionChanged)
            {
                if (saveFolderSettings())
                {
                    parent.SaveSettings = settings;
                    cmdFileApply.Enabled = false;
                    blnOptionChanged = false;
                    blnReportChanged = false;
                    blnTypeChanged = false;
                }
            }
            // MOD-END 08142007 EG
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            settings.ewkReportFolderPath = b.Text;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08152007 EG
            blnReportChanged = true;
            // ADD-END 08152007 EG
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            settings.productTypeFolderPath = b.Text;
            this.cmdFileApply.Enabled = true;
            // ADD-START 08152007 EG
            blnTypeChanged = true;
            // ADD-END 08152007 EG
        }

        private void FileSettings_Load(object sender, EventArgs e)
        {
            this.cmdFileApply.Enabled = false;
            folderBrowserDialog.ShowNewFolderButton = false;
        }

        private void cmdProdTypeBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select the directory where EWK product type files will be stored.";
            DialogResult x = folderBrowserDialog.ShowDialog(this);
            if (x != DialogResult.Cancel) textBox1.Text = folderBrowserDialog.SelectedPath;
        }

        private void cmdReportBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select the directory where EWK message files will be stored.";
            DialogResult x = folderBrowserDialog.ShowDialog(this);
            if (x != DialogResult.Cancel) textBox2.Text = folderBrowserDialog.SelectedPath;
        }

        // ADD-START 08142007 EG
        // Save new settings for reports.
        private bool saveFolderSettings()
        {
            try
            {
                string path = @"rptsetting.dat";
                using (StreamWriter sw = File.CreateText(path))
                {
                    string stemp = "|";

                    for (int i = 0; i < settings.XML_ITEMS.Length; i++)
                        stemp = stemp + settings.toSave[i].ToString() + "|";

                    if (!(settings.ewkReportFolderPath.EndsWith("\\") == true))
                        settings.ewkReportFolderPath += "\\";

                    if (!(settings.productTypeFolderPath.EndsWith("\\") == true))
                        settings.productTypeFolderPath += "\\";

                    sw.WriteLine(settings.ewkReportFolderPath + "|" + settings.productTypeFolderPath + stemp);

                    if (blnReportChanged || blnTypeChanged)
                        copyXmlFiles();
                }
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Access violation! The file for folder setting is read-only.", "Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            return false;
        }
        
        // Copy the XML folder and its contents to new a specified report folder.
        private void copyXmlFiles()
        {
            DirectoryInfo di = new DirectoryInfo("..\\XML\\");
            FileInfo[] fi = di.GetFiles();

            for (int i = 0; i < fi.Length; i++)
                if (File.Exists(settings.ewkReportFolderPath + "\\XML\\" + fi[i].ToString()))
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("File " + fi[i].ToString() + " already exists! Overwrite?", "File Write", MessageBoxButtons.YesNo, MessageBoxIcon.Question);                    

                    if (result == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(settings.ewkReportFolderPath + "\\XML\\");
                        File.Copy("..\\XML\\" + fi[i].ToString(), settings.ewkReportFolderPath + "\\XML\\" + fi[i].ToString(), true);
                    }
                }
                else
                {
                    Directory.CreateDirectory(settings.ewkReportFolderPath + "\\XML\\");
                    File.Copy("..\\XML\\" + fi[i].ToString(), settings.ewkReportFolderPath + "\\XML\\" + fi[i].ToString(), true);
                }

        }
        // ADD-END 08142007 EG
         
    }
}