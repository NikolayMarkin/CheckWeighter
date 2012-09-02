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

            //при загрузке окна параметры не доступны для редактирования
            //кнопка "Сохранить" так же не активна, т.к. сохранять еще нечего
            cmdSave.Enabled = false;
            this.localPortNumber.Enabled = false;
            //считываем значение номера порта из конфиг файла
            this.localPortNumber.Text = DLLWrapper.getLocalServerPort().ToString();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            //при нажатии на кнопку "Редактировать" все параметры 
            //становятся доступными для редактирования
            this.localPortNumber.Enabled = true;

            this.

            //кнопка "Сохранить" становится активной
            cmdSave.Enabled = true;
            //кнопка "Редактировать" становится неактивной
            cmdEdit.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //при нажатии на кнопку "Сохранить" она становится неактивной
            cmdSave.Enabled = false;
            //а кнопка "Редактировать" активизируется
            cmdEdit.Enabled = true;

            //сохраняем настройки порта
            DLLWrapper.writeConfigurationFile("127.0.0.1", 60001, int.Parse(this.localPortNumber.Text));
        }

        private void checkBDName_CheckedChanged(object sender, EventArgs e)
        {
            //при изменении состояния флажка даем возможность 
            //либо выбирать имя базы данных из файла 
            //либо вводить имя базы вручную
            this.dbName.Enabled = !this.checkBDName.Checked;
            this.pathToDBName.Enabled = this.checkBDName.Checked;
            this.cmdBrowse.Enabled = this.checkBDName.Checked;
        }

        
    }
}