using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLLWrapperLibrary;
using CWXmlStack;

namespace ServerXmlCW
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            //��� �������� ���� ��������� �� �������� ��� ��������������
            //������ "���������" ��� �� �� �������, �.�. ��������� ��� ������
            cmdSave.Enabled = false;
            this.localPortNumber.Enabled = false;
            //��������� �������� ������ ����� �� ������ �����
            this.localPortNumber.Text = DLLWrapper.getLocalServerPort().ToString();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            //��� ������� �� ������ "�������������" ��� ��������� 
            //���������� ���������� ��� ��������������
            this.localPortNumber.Enabled = true;

            this.

            //������ "���������" ���������� ��������
            cmdSave.Enabled = true;
            //������ "�������������" ���������� ����������
            cmdEdit.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //��� ������� �� ������ "���������" ��� ���������� ����������
            cmdSave.Enabled = false;
            //� ������ "�������������" ��������������
            cmdEdit.Enabled = true;

            //��������� ��������� �����
            DLLWrapper.writeConfigurationFile("127.0.0.1", 60001, int.Parse(this.localPortNumber.Text));
        }

        private void checkBDName_CheckedChanged(object sender, EventArgs e)
        {
            //��� ��������� ��������� ������ ���� ����������� 
            //���� �������� ��� ���� ������ �� ����� 
            //���� ������� ��� ���� �������
            this.dbName.Enabled = !this.checkBDName.Checked;
            this.pathToDBName.Enabled = this.checkBDName.Checked;
            this.cmdBrowse.Enabled = this.checkBDName.Checked;
        }

        
    }
}