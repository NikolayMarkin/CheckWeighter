using System;
using System.Collections.Generic;
using System.Text;
using CWXmlStack;

namespace ServerTestGUI
{
    interface ServerAppInterface
    {
        void alert();
        void alertReport(CWXmlDataWrapper data);
        // ADD-START 08072007 EG
        void alertServerError();
        // ADD-END 08072007 EG
    }
}
