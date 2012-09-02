using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonForms;
using CWXmlStack;
using DLLWrapperLibrary;
using System.Xml;
using System.Xml.XPath;
using System.Data.OleDb;
using System.IO;
using ServerXmlCW;

namespace ServerTestGUI
{
    
    public partial class ServerTestGUI : Form, FileStore, ServerAppInterface
    {
        private delegate void delAlert();
        private delegate void delReport(CWXmlDataWrapper data);
        private delegate void delAlertError();
        FileSettings fileSettingsDialog;
        IPSettings ipSettingsDialog;
        CWXmlSaveSettings saveSettings;
        ServerModuleWrapper server;
        int[] messageCounter;
        const int totalFieldIndex = 0;
        
        private 
	    string[] 	XML_ITEMS = new string[9]{" ",
                                "Test_Message",
								"Entry_Report", 
								"Producttype",
                                "Final_Report",
                                "Auto_Report",
                                "EGA",
                                "Status_Report",
                                "Random_Sample"};

        public CWXmlSaveSettings SaveSettings
        {
            get
            {
                return saveSettings;
            }
            set
            {
                saveSettings = value;
            }
        }

        public ServerTestGUI()
        {
            InitializeComponent();
            server = new ServerModuleWrapper(this);
            saveSettings = new CWXmlSaveSettings();     
            messageCounter = new int[9];
            clearFields();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdFileSettings_Click(object sender, EventArgs e)
        {
            fileSettingsDialog = new FileSettings(this);         
            fileSettingsDialog.ShowDialog(this);
        }

        private void cmdIPSettings_Click(object sender, EventArgs e)
        {
            ipSettingsDialog = new IPSettings(IPSettings.EDIT_SERVER);
            ipSettingsDialog.ShowDialog(this);
        }

        private void cmdStartButton_Click(object sender, EventArgs e)
        {
            // MOD-START 08072007 EG
            if (server.ToString() != null)
            {
                bool stat = server.startMonitoring();
                if (stat)
                {
                    // MOD-START 08162007 EG
                    System.Threading.Thread.Sleep(1000);
                    // MOD-END 08162007 EG
                    statusLabel.Text = server.Status;
                    if (server.isListening())
                    {
                        cmdStartButton.Enabled = false;
                        cmdStopButton.Enabled = true;
                        cmdIPSettings.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Unable to listen on the specified port. There could be another program accessing the port.", "Listen Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // MOD-END 08072007 EG
        }

        private void cmdStopButton_Click(object sender, EventArgs e)
        {
            // MOD-START 08072007 EG
            if (server != null)
            {
                server.stopMonitoring();
                System.Threading.Thread.Sleep(300);
                statusLabel.Text = "Connection Stopped!";

                cmdStartButton.Enabled = true;
                cmdStopButton.Enabled = false;
                cmdIPSettings.Enabled = true;
            }
            // MOD-END 08072007 EG
        }

        private void cmdClearbutton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void alert()
        {
            if (statusLabel.InvokeRequired)
            {
                delAlert del = new delAlert(alert);
            }
            else
            {
                statusLabel.Text = server.Status;
            }
        }

        public void alertServerError()
        {
            StringBuilder pErrorMsg = new StringBuilder(1000);

            if (server.getServerErrorMessage(pErrorMsg, pErrorMsg.Capacity + 1))
            {
                MessageBox.Show(pErrorMsg.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void updateFields()
        {
            textBox0.Text = messageCounter[0].ToString();
            textBox1.Text = messageCounter[1].ToString();
            textBox2.Text = messageCounter[2].ToString();
            textBox3.Text = messageCounter[3].ToString();
            textBox4.Text = messageCounter[4].ToString();
            textBox5.Text = messageCounter[5].ToString();
            textBox6.Text = messageCounter[6].ToString();
            textBox7.Text = messageCounter[7].ToString();
            textBox8.Text = messageCounter[8].ToString();
        }

        void clearFields()
        {
            display.Text = "";
            for (int i = 0; i < messageCounter.Length; i++)
            {
                messageCounter[i] = 0;
            }
            updateFields();
        }

        int getXMLIndex(String s)
        {
            for (int i = 0; i < XML_ITEMS.Length; i++)
                if (XML_ITEMS[i].Equals(s)) return i;

            return -1;
        }

        public void alertReport(CWXmlDataWrapper report)
        {
            if (display.InvokeRequired)
            {
                delReport del = new delReport(alertReport);
                this.Invoke(del, new object[] { report });
            }
            else
            {

                // ADD-START 08072007 EG
                string reportName = "";
                reportName = report.getDocTypeString();

                // ADD-END 08072007 EG

                //записываем данные из отчета в базу данных.
                writeXmlToBD(report);

                // MOD-START 08072007 EG
                if (saveSettings.saveIfSpecifiedServer(server.getServerModule(), report, report.getServerIPAddress(), reportName))
                {                                        
                    setText(report.toXmlString());
                    int xmlIndex = getXMLIndex(reportName);

                    if (xmlIndex != -1)
                    {
                        messageCounter[xmlIndex]++;
                        messageCounter[totalFieldIndex]++;
                        updateFields();
                    }

                    display.BackColor = Color.Yellow;
                    display.Refresh();
                    System.Threading.Thread.Sleep(5);
                    display.BackColor = Color.White;                    
                }
                // MOD-END 08072007 EG
            }
        }

        private void ServerTestGUI_Load(object sender, EventArgs e)
        {
            //при загрузке главного окна, отправить сигнал для старта сервера
            cmdStart.PerformClick();
        }

        public void setText(string s)
        {
            String w = s.Replace("\u000a\u000a", Environment.NewLine);
            w = w.Replace("<!DOCTYPE", Environment.NewLine + Environment.NewLine + "<!DOCTYPE");
            w = w.Replace("<!-", Environment.NewLine + "<!-");
            w = w.Replace("<?", Environment.NewLine + "<?");
            w = w.Replace("]><", "]>" + Environment.NewLine + Environment.NewLine + "<");
            display.Text = w;
        }

        /*
         * функция получает отчет и в зависимости от типа
         * отчета записывает данные в соответствующую таблицу базы данных.
         */
        private void writeXmlToBD(CWXmlDataWrapper report)
        {
            string reportType = report.getDocTypeString();

            if (reportType.Equals("Final_Report"))
            {
                //получили финальный отчет за партию
                //записываем данные предоставляемые отчетом в БД
                writeFinalReport(report.toXmlString());
            }
        }

        private void writeFinalReport(string xmlReport)
        {
            try
            {

                //создаем объект DOM для чтения данных отчета
                XmlDocument report = new XmlDocument();
                report.LoadXml(xmlReport);

                //данные из секции General data
                string weighterNumber = "", machineNumber = "", startOfBatch = "",
                    endOfBatch = "", articleNumber = "", articleDesignation = "";

                XmlNode node = report.SelectSingleNode("/Final_Report/Production_Report/Miscellaneous_Data");
                XmlNodeList list = node.ChildNodes;

                foreach (XmlNode n in list)
                {
                    switch (n.Name)
                    {
                        case "Weigher_Number":
                            weighterNumber = n.InnerText;
                            break;
                        case "Machine_Number":
                            machineNumber = n.InnerText;
                            break;
                        case "Start_of_Batch":
                            startOfBatch = n.InnerText;
                            break;
                        case "End_of_Batch":
                            endOfBatch = n.InnerText;
                            break;
                        case "Article_Number":
                            articleNumber = n.InnerText;
                            break;
                        case "Article_Designation":
                            articleDesignation = n.InnerText;
                            break;
                        default:
                            break;
                    }
                }
                //end General data

                //start Evaluation Type = Total_Evaluation section 

                //start Produtuction Data Type = Total section
                node = report.SelectSingleNode("/Final_Report/Production_Report/Evaluation[@Type='TOTAL_EVALUATION']/Production_Data[@Type='TOTAL_PRODUCTION']");
                list = node.ChildNodes;

                //общее количество продукции
                //суммарный вес
                double sumWeightT = 0;
                //количество штук (целое число)
                string sumNumberT = "";

                foreach (XmlNode n in list)
                {
                    switch (n.Name)
                    {
                        case "Sum_Number":
                            sumNumberT = n.InnerText;
                            break;
                        case "Sum_Weight":
                            //получаем 2 строки: в первой вес, во второй единица измерения
                            string[] arr = n.InnerText.Split(' ');
                            //граммы и тонны преобразуем в килограммы
                            string strWeight = arr[0].Replace('.', ',');
                            switch (arr[1])
                            {
                                case "t":
                                    sumWeightT = double.Parse(strWeight) * 1000;
                                    break;
                                case "g":
                                    sumWeightT = double.Parse(strWeight) / 1000;
                                    break;
                                case "т":
                                    sumWeightT = double.Parse(strWeight) * 1000;
                                    break;
                                case "г":
                                    sumWeightT = double.Parse(strWeight) / 1000;
                                    break;
                                default:
                                    //килограммы
                                    sumWeightT = double.Parse(strWeight);
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
                //end Produtuction Data Type = Total section

                //start Produtuction Data Type = Good section
                node = report.SelectSingleNode("/Final_Report/Production_Report/Evaluation[@Type='TOTAL_EVALUATION']/Production_Data[@Type='GOOD_PRODUCTION']");
                list = node.ChildNodes;

                //количество продукции прошедшей проверку
                //суммарный вес
                double sumWeightG = 0;
                //количество штук (целое число)
                string sumNumberG = "";

                foreach (XmlNode n in list)
                {
                    switch (n.Name)
                    {
                        case "Sum_Number":
                            sumNumberG = n.InnerText;
                            break;
                        case "Sum_Weight":
                            //получаем 2 строки: в первой вес, во второй единица измерения
                            string[] arr = n.InnerText.Split(' ');
                            //граммы и тонны преобразуем в килограммы
                            string strWeight = arr[0].Replace('.', ',');
                            switch (arr[1])
                            {
                                case "t":
                                    sumWeightG = double.Parse(strWeight) * 1000;
                                    break;
                                case "g":
                                    sumWeightG = double.Parse(strWeight) / 1000;
                                    break;
                                case "т":
                                    sumWeightG = double.Parse(strWeight) * 1000;
                                    break;
                                case "г":
                                    sumWeightG = double.Parse(strWeight) / 1000;
                                    break;
                                default:
                                    //килограммы
                                    sumWeightG = double.Parse(strWeight);
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
                //end Produtuction Data Type = Good section
                //start Rejected_Packages Type = Total section
                //end Rejected_Packages Type = Total section
                //start Rejected_Packages Type = Under section
                //end Rejected_Packages Type = Under section
                //start Rejected_Packages Type = Over section
                //end Rejected_Packages Type = Over section

                //end Evaluation section

                //параметры партии
                node = report.SelectSingleNode("/Final_Report/Entry_Report/Entry_Report_Batch_Data/Entry_Report_Production_Data");
                list = node.ChildNodes;

                string
                    //вес упаковки
                    tareWeight = "",
                    //длина упаковки
                    packLength = "";

                foreach (XmlNode n in list)
                {
                    switch (n.Name)
                    {
                        case "Tare":
                            tareWeight = n.InnerText;
                            break;
                        case "Pack_Length":
                            packLength = n.InnerText;
                            break;
                        default:
                            break;
                    }
                }


                OleDbConnection cn = new OleDbConnection();
                cn.ConnectionString = "Provider=SQLOLEDB.1;" +
                                        "Integrated Security=SSPI;" +
                                        "Persist Security Info=False;" +
                                        "Initial Catalog = " + readDBName() + ";" +
                                        "Data Source = .\\WinCC;" +
                                        "User Id = WinCCConnect;" +
                                        "Password = 2WSXcder;";
                cn.Open();

                //получаем идентификатор артикула продукции
                string articleId = "";
                string strQuery = "SELECT id FROM ua#production WHERE articleNumber = N'" + articleNumber + "'";

                Console.WriteLine(strQuery);


                OleDbCommand cmd = new OleDbCommand(strQuery, cn);

                //результат выполнения запроса
                OleDbDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    //если запись с таким артикулом существует получаем её идентификатор
                    articleId = data["id"].ToString();
                    data.Close();
                }
                else
                {
                    //если такой записи не оказалось создаем новую
                    strQuery = "INSERT INTO ua#production (articleNumber, articleDesc)" +
                        "VALUES(N'" + articleNumber + "',N'" + articleDesignation + "');" +
                    "SELECT id FROM ua#production WHERE articleNumber = N'" + articleNumber + "';";
                    cmd.CommandText = strQuery;
                    //закроем предыдущий ридер
                    data.Close();
                    data = cmd.ExecuteReader();
                    data.Read();
                    articleId = data["id"].ToString();
                    data.Close();
                }

                //определяем какая сейчас смена
                int shift = 1;

                DateTime dateShift = DateTime.Parse(endOfBatch);//, System.Globalization.CultureInfo.InvariantCulture);
                int hour = dateShift.Hour;

                if (hour >= 7 && hour < 15)
                {
                    shift = 2;
                }
                else if (hour >= 15 && hour < 23)
                {
                    shift = 3;
                }

                //формируем запрос для записи отчета по партии
                strQuery = "INSERT INTO ua#ReportOfBatch(articleId, start_of_batch, time_stamp, shift," +
                "totalNum, totalWeight, goodNum, goodWeight, dateShift) " +
                            "VALUES(" + articleId + ",Convert(DATETIME,'" +
                            DateTime.Parse(startOfBatch).ToString("yyyy-MM-dd H:mm:ss")
                            + "'),Convert(DATETIME,'" + dateShift.ToString("yyyy-MM-dd H:mm:ss") + "')," + shift.ToString() + ","
                            + sumNumberT + "," + sumWeightT.ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + sumNumberG + "," + sumWeightG.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                            ",Convert(DATETIME,'" + dateShift.ToString("yyyy-MM-dd") + "'))";
                cmd.CommandText = strQuery;
                cmd.ExecuteReader();
                cn.Close();
            }
            catch (Exception e)
            {
                StreamWriter writer = new StreamWriter("log.txt");
                writer.WriteLine(DateTime.Now + " " + e.Message);
            }
        }

        /*функция считывает имя базы данных из конфигурационного файла
         */
        string readDBName()
        {
            StreamReader reader = new StreamReader("..\\XML\\DBSettings.txt");

            return reader.ReadLine();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                //если сервер остановлен на данный момент запускаем его
                if (!server.isListening())
                {
                    bool stat = server.startMonitoring();
                    if (stat)
                    {
                        System.Threading.Thread.Sleep(1000);
                        statusLabel.Text = server.Status;
                        if (server.isListening())
                        {
                            cmdStart.Text = "Остановить сервер";
                        }
                        else
                        {
                            MessageBox.Show("Unable to listen on the specified port. There could be another program accessing the port.", "Listen Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    //останавливаем в противном случае
                    if (server != null)
                    {
                        server.stopMonitoring();
                        System.Threading.Thread.Sleep(300);
                        statusLabel.Text = "Connection Stopped!";

                        cmdStartButton.Enabled = true;
                        cmdStopButton.Enabled = false;
                        cmdIPSettings.Enabled = true;

                        cmdStart.Text = "Запустить сервер";
                    }

                }
            }
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsDialog = new SettingsWindow();
            settingsDialog.ShowDialog(this);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //отменяем действие по умолчанию
            e.Cancel = true;
            //и скрываем форму в области уведомлений
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //если программа свернута развернуть и наоборот

            //проверяем свернуто окно или нет
            if (this.Visible == false)
            {
                // окно свернуто - разворчиваем 
                this.Show();
                //сделать активным только что развернутое окно
                this.Activate();
            }
            else
            {
                // окно развернуто - сворачиваем его в трей
                this.Hide();
            }
        }

    }
}