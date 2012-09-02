using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace DLLWrapperLibrary
{
    public delegate void AlertFunction();
    public delegate void AlertReportFunction(IntPtr data);
    // MOD-START 08082007 EG
    public delegate void AlertServerError();
    public delegate void AlertClientError();
    // MOD-START 08082007 EG

    public class DLLWrapper
    {
#if DEBUG
        private const string DLLDIRECTY = "";
#else
        private const string  DLLDIRECTY = "";
#endif
        //XmlData-related Functions
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern string getDocTypeString(IntPtr data);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern string toXmlString(IntPtr data);

        // MOD-START 08072007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern bool outputToFileServer(IntPtr serverModule, IntPtr data, string filename);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern bool outputToFileClient(IntPtr clientModule, IntPtr data, string filename);
        // MOD-END 08072007 EG

        // ADD-START 08142007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern bool DestroyCWXmlHandlerReport(IntPtr data);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern bool DestroyCWXmlReply(IntPtr data);        
        // ADD-END 08142007 EG

        // DEL-START 08092007 EG
        /*
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern void setTextInNode(string tagName, string newText, IntPtr data);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern string getTextInNode(string tagName, IntPtr data);
         */
        // DEL-END 08092007 EG

        // ADD-START 08072007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern string getCWIPAddress(IntPtr report, int module);
        // ADD-END 08072007 EG

        //Client-related Functions
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr CreateCWXmlClientModule();

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern void DestroyCWXmlClientModule(IntPtr client);

        // DEL-START 08092007 EG
        /*[DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern string getErrorMessage(IntPtr data);
         */
        // DEL-END 08092007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandDeleteErrorFifo(IntPtr client);

        // MOD-START 08092007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandEraseProducttype(IntPtr client, string articleNo);
        // MOD-END 08092007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetAutoReport(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetCheckweigherState(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetEntryReport(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetFinalReport(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetIntermediateReport(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetLastError(IntPtr client);

        // MOD-START 08092007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandGetProducttype(IntPtr client, string articleNo);
        // MOD-END 08092007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetShiftReport(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandGetTestMessage(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandSetDateTime(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandSoftwareUpdate(IntPtr client);

        // MOD-START 08092007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandLoadProducttype(IntPtr client, string articleNo);
        // MOD-END 08092007 EG

        // DEL-START 08092007 EG
        /*
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandLoadProducttypeSPCfWin(IntPtr client, string articleNo, string batchNo);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandPrepareProducttype(IntPtr client, string articleNo);
         *  */
        // DEL-END 08092007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr sendCommandStartBatch(IntPtr client);

        // MOD-START 08092007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandStartBatchArticle(IntPtr client, string articleNo);
        // MOD-END 08092007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern IntPtr sendCommandStopBatch(IntPtr client);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern string getRemoteIP();

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern int getLocalServerPort();

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern int getRemotePort();

        // MOD-START 08092007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern void writeConfigurationFile(string rip, int lsp, int rp);
        // MOD-END 08092007 EG

        //Server-related functions
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr CreateCWXmlServerModule();
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern void DestroyCWXmlServerModule(IntPtr server);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool startListening(IntPtr server);

        // ADD-START 07082007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern bool isServerListening(IntPtr server);
        // ADD-END 07082007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern void stopListening(IntPtr server);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern string getStatusMessage(IntPtr server);
 
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern void SetAlertCallBackPointer(IntPtr server, AlertFunction fxnPtr);
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern void SetReportCallBackPointer(IntPtr server, AlertFunction fxnPtr);
        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        // ADD-START 08072007 EG
        public static extern void SetErrorCallBackPointer(IntPtr module, AlertFunction fxnPtr, int moduletype);
        // ADD-END 08072007 EG

        [DllImport(DLLDIRECTY + "CWXmlStack.dll")]
        public static extern IntPtr getLatestReport(IntPtr server);

        // ADD-START 08082007 EG
        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern bool getErrorMessageServer(IntPtr server, [MarshalAs(UnmanagedType.LPStr)] StringBuilder pErrorMsg, out int len);

        [DllImport(DLLDIRECTY + "CWXmlStack.dll", CharSet = CharSet.None)]
        public static extern bool getErrorMessageClient(IntPtr client, [MarshalAs(UnmanagedType.LPStr)] StringBuilder pErrorMsg, out int len);
        // ADD-END 08082007 EG
    }
}
