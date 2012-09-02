using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLLWrapperLibrary;
using CWXmlStack;

namespace CommonForms
{
    public partial class IPSettings : Form
    {
        public static int EDIT_CLIENT = 0;
        public static int EDIT_SERVER = 1;
        public static int EDIT_ALL = 2;
        private int editMode;

        public IPSettings()
        {
            InitializeComponent();
            cmdIPSettingsSave.Enabled = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.textBox1.Text = DLLWrapper.getRemoteIP();
            this.textBox1.Text = DLLWrapper.getRemotePort().ToString();
            this.textBox1.Text = DLLWrapper.getLocalServerPort().ToString();
            this.editMode = 2;
        }

        public IPSettings(int editMode)
        {
            InitializeComponent();
            this.editMode = editMode;
            cmdIPSettingsSave.Enabled = false;
            
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
                this.textBox1.Text = DLLWrapper.getRemoteIP();
                this.textBox2.Text = DLLWrapper.getRemotePort().ToString();
                this.textBox3.Text = DLLWrapper.getLocalServerPort().ToString();
            
            
        }

        private void cmdIPSettingsClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdIPSettingsEdit_Click(object sender, EventArgs e)
        {
            if (editMode == EDIT_ALL)
            {
                this.textBox1.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
            }
            if (editMode == EDIT_CLIENT)
            {
                this.textBox1.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = false;
            }
            if (editMode == EDIT_SERVER)
            {
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = true;
            }

            cmdIPSettingsEdit.Enabled = false;
            cmdIPSettingsSave.Enabled = true;
            
        }

        private void cmdIPSettingsSave_Click(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            cmdIPSettingsEdit.Enabled = true;
            cmdIPSettingsSave.Enabled = false;

            DLLWrapper.writeConfigurationFile(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void IPSettings_Load(object sender, EventArgs e)
        {

        }
    }
}