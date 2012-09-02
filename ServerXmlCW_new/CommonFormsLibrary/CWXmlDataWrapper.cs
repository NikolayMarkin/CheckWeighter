using System;
using System.Collections.Generic;
using System.Text;
using DLLWrapperLibrary;

namespace CWXmlStack
{
    public class CWXmlDataWrapper
    {
        IntPtr data;

        public CWXmlDataWrapper(IntPtr data)
        {
            this.data = data;
        }

        public string getDocTypeString()
        {
            int x = (int)data;
            if (x == 0) return "null data";
            return DLLWrapper.getDocTypeString(data);
        }

        public string toXmlString()
        {
            int x = (int)data;
            if (x == 0) return "null data";
            string s = DLLWrapper.toXmlString(data);
            return s;
        }

        // MOD-START 08072007 EG
        public bool outputToFileServer(IntPtr serverModule, IntPtr data, string filename)
        {
            return DLLWrapper.outputToFileServer(serverModule, data, filename);
        }

        public bool outputToFileClient(IntPtr clientModule, IntPtr data, string filename)
        {
            return DLLWrapper.outputToFileClient(clientModule, data, filename);
        }
        // MOD-END 08072007 EG

        /**Saves the equivalent xml file with the following format: DOCTYPE_YYYY_MM_DD_hh_mm_ss_ms.xml 
         * @param directory the path of the directory in which the xml file is to be saved.
         */
        public bool saveFormattedInServer(IntPtr serverModule, string directory, string docType)
        {
            DateTime date = DateTime.Now;
            
            directory = directory.Trim();
            if (directory[directory.Length - 1] != '\\') directory = directory + "\\";
            string now = date.Year + "_" + date.Month + "_" + date.Day + "_" + date.Hour + "_" + date.Minute + "_" + date.Second + "_" + date.Millisecond;
            
            // MOD-START 08072007 EG            
            string filename = directory + docType + "_" + now + ".xml";
            return outputToFileServer(serverModule, data, filename);
            // MOD-END 08072007 EG
        }

        // ADD-START 08072007 EG
        public bool saveFormattedInClient(IntPtr clientModule, string directory, string docType)
        {
            DateTime date = DateTime.Now;

            directory = directory.Trim();
            if (directory[directory.Length - 1] != '\\') directory = directory + "\\";
            string now = date.Year + "_" + date.Month + "_" + date.Day + "_" + date.Hour + "_" + date.Minute + "_" + date.Second + "_" + date.Millisecond;

            // MOD-START 08072007 EG            
            string filename = directory + docType + "_" + now + ".xml";
            return outputToFileClient(clientModule, data, filename);
            // MOD-END 08072007 EG
        }

        public string getServerIPAddress()
        {
            return DLLWrapper.getCWIPAddress(data, 1);
        }

        public string getClientIPAddress()
        {
            return DLLWrapper.getCWIPAddress(data, 2);
        }
        // ADD-END 08072007 EG

        // ADD-START 08142007 EG
        public void destoryHandlerReport()
        {
            DLLWrapper.DestroyCWXmlHandlerReport(data);
        }

        public void destroyClientReply()
        {
            DLLWrapper.DestroyCWXmlReply(data);
        }
        // ADD-END 08142007 EG
    }
}
