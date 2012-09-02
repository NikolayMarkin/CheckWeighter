using System;
using System.Collections.Generic;
using System.Text;
using CWXmlStack;
using DLLWrapperLibrary;
using System.Runtime.InteropServices;

namespace ServerTestGUI
{ 
    class ServerModuleWrapper
    {
        ServerAppInterface parent;
        string status;
        IntPtr server;
        AlertFunction exportAlert;
        AlertFunction exportAlertReport;
        AlertFunction exportAlertError;

        public string Status 
        {
            get
            {
                status = DLLWrapper.getStatusMessage(server);
                return status;
            }
        }

        public ServerModuleWrapper(ServerAppInterface parentApp)
        {
            parent = parentApp;
            server = DLLWrapper.CreateCWXmlServerModule();

            exportAlert = new AlertFunction(this.alertFromDLL);
            exportAlertReport = new AlertFunction(this.reportFromDLL);

            // ADD-START 08072007 EG
            exportAlertError = new AlertFunction(this.alertErrorFromDLL);
            // ADD-END 08072007 EG

            // MOD-START 08072007 EG
            DLLWrapper.SetAlertCallBackPointer(server, exportAlert);
            DLLWrapper.SetReportCallBackPointer(server, exportAlertReport);
            DLLWrapper.SetErrorCallBackPointer(server, exportAlertError, 1);
            // MOD-END 08072007 EG
        }

        ~ServerModuleWrapper()
        {
            DLLWrapper.DestroyCWXmlServerModule(server);
        }

        public bool startMonitoring()
        {
            return DLLWrapper.startListening(server);
        }

        public void stopMonitoring()
        {
            DLLWrapper.stopListening(server);
        }

        public void alertFromDLL()
        {
            parent.alert();
        }

        // ADD-START 08072007 EG
        public void alertErrorFromDLL()
        {
            parent.alertServerError();
        }
        // ADD-END 08072007 EG

        public void reportFromDLL()
        {
            CWXmlDataWrapper report = new CWXmlDataWrapper(DLLWrapper.getLatestReport(server));
            // MOD-START 08142007 EG
            if (report != null)
            {
                parent.alertReport(report);
                report.destoryHandlerReport();
            }
            // MOD-END 08142007 EG
        }

        // ADD-START 08072007 EG
        public bool isListening()
        {
            return DLLWrapper.isServerListening(server);
        }

        public IntPtr getServerModule()
        {
            return this.server;
        }

        public bool getServerErrorMessage(StringBuilder pErrorMsg, int len)
        {
            if (DLLWrapper.getErrorMessageServer(this.server, pErrorMsg, out len))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // ADD-END 08072007 EG
    }
}
