using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
// ADD-START 08072007 EG
using System.IO;
// ADD-END 08072007 EG

namespace CWXmlStack
{
    public class CWXmlSaveSettings
    {
        public string[] XML_ITEMS = {"Test_Message",
                                     "Final_Report",
                                     "EGA",
                                     "Random_Sample",
								     "Entry_Report", 
                                     "Auto_Report",
                                     "Status_Report",
								     "Producttype",
                                     "Remote_Message",
                                     "Error_Report",
                                     "Any other report"};

        public bool[] toSave;
        public string productTypeFolderPath, ewkReportFolderPath;

        // DEL-START 08072007 EG
        /*private int getDocTypeIndex(CWXmlDataWrapper data)
        {
            for (int i = 0; i < XML_ITEMS.Length - 1; i++)
                if (data.getDocTypeString().Equals(XML_ITEMS[i])) return i;

            return XML_ITEMS.Length - 1;
        }*/
        // DEL-END 08072007 EG

        private int getDocTypeIndex(string docType)
        {
            for (int i = 0; i < XML_ITEMS.Length - 1; i++)
                if (docType.Equals(XML_ITEMS[i])) return i;

            return XML_ITEMS.Length - 1;
        }

        /**If the doctype of the entered <code>data</code> is specified to be saved, this method saves it to a file with the format <code> DOCTYPE_YYYY_MM_DD_hh_mm_ss.xml </code> in the folder path specified.
         * @param data - CWXmlDataWrapper to be saved
         */
        // MOD-START 08072007 EG
        public bool saveIfSpecifiedServer(IntPtr Module, CWXmlDataWrapper data, string ipAdd, string docType)
        {
            string targetFolder = ewkReportFolderPath;
            if (docType.Equals("Producttype")) targetFolder = productTypeFolderPath;
        // MOD-END 08072007 EG

            // ADD-START 08072007 EG
            targetFolder = targetFolder + ipAdd + "\\";
            // ADD-END 08072007 EG

            try
            {
                // MOD-START 08152007 EG
                if (toSave[getDocTypeIndex(docType)])
                {
                    Directory.CreateDirectory(targetFolder);

                    if (data.saveFormattedInServer(Module, targetFolder, docType))
                        return true;
                }                
                else
                {
                    return true;
                }
                // MOD-END 08152007 EG
            }
            catch (Exception ex) 
            { 
                System.Windows.Forms.MessageBox.Show("Unable to save in " + targetFolder + ". Please check the file settings.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            return false;
        }


        public bool saveIfSpecifiedClient(IntPtr Module, CWXmlDataWrapper data, string ipAdd, string docType)
        {
            string targetFolder = ewkReportFolderPath;
            if (docType.Equals("Producttype")) targetFolder = productTypeFolderPath;
            // MOD-END 08072007 EG

            // ADD-START 08072007 EG
            targetFolder = targetFolder + ipAdd + "\\";
            Directory.CreateDirectory(targetFolder);
            // ADD-END 08072007 EG

            try
            {
                // MOD-START 08072007 EG
                if (toSave[getDocTypeIndex(docType)])
                {
                    if (data.saveFormattedInClient(Module, targetFolder, docType))
                        return true;
                }
                // MOD-END 08072007 EG
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Unable to save in " + targetFolder + ". Please check the file settings.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        /**Creates a new instance of CWXmlSaveSettings with the following default settings: 
         * <p>
         * &nbsp&nbsp&nbsp - all files saved<br>
         * &nbsp&nbsp&nbsp - productTypeFolderPath = "..\\XML\\types\\" <br>
         * &nbsp&nbsp&nbsp - ewkReportFolderPath = "..\\XML\\reports\\" <br>
         * 
         */
        public CWXmlSaveSettings()
        {
            toSave = new bool[XML_ITEMS.Length];
            for (int i = 0; i < XML_ITEMS.Length; i++)
            {
                toSave[i] = true;
            }
            productTypeFolderPath = "..\\XML\\types\\";
            ewkReportFolderPath = "..\\XML\\reports\\";

            // ADD-START 08142007 EG
            string path = @"rptsetting.dat";
            if (!File.Exists(path))
            {
                // Create a new file for report setting to write to.         
                using (StreamWriter sw = File.CreateText(path))
                {
                    string stemp = "|";
                    for (int i = 0; i < XML_ITEMS.Length; i++)
                        stemp = stemp + toSave[i].ToString() + "|";
                    sw.WriteLine(ewkReportFolderPath  + "|" + productTypeFolderPath + stemp);
                }
            }
            else
            {
                // Load settings from the existing file settings
                using (StreamReader sr = File.OpenText(path))
                {
                    char[] delimeterChar = {'|'};
                    string strTemp = "";

                    while ((strTemp = sr.ReadLine()) != null)
                    {
                        string[] strFolders = strTemp.Split('|');

                        for (int i = 0; i < XML_ITEMS.Length; i++)
                            toSave[i] = (strFolders[i + 2].ToString().Equals("True")) ? true : false;

                        ewkReportFolderPath = strFolders[0];
                        productTypeFolderPath = strFolders[1];
                    }
                }

            }
            // ADD-END 08142007 EG
        }

        public CWXmlSaveSettings clone() 
        {
            CWXmlSaveSettings clone = new CWXmlSaveSettings();
            
            for (int i = 0; i < XML_ITEMS.Length; i++)
            {
                clone.toSave[i] = this.toSave[i];
            }
            clone.productTypeFolderPath = this.productTypeFolderPath;
            clone.ewkReportFolderPath = this.ewkReportFolderPath;

            return clone;
        }
	
    }
}
