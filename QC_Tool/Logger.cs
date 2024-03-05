using System;
using System.Windows.Forms;

namespace QC_Tool
{
    class Logger
    {
        FormApp frmApp;

        public void textBoxLog(string log)
        {
            frmApp = FormApp.getInstance();
            frmApp.textBoxDetails.Text += log + Environment.NewLine;
            Application.DoEvents();

        }
    }
}
