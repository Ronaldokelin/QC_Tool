using System.Drawing;
using System.Windows.Forms;

namespace QC_Tool
{
    class Utils
    {
        FormApp frmApp;

        public void labelError(string error)
        {
            frmApp = FormApp.getInstance();

            frmApp.labelErrorQPM3.Text = error;
            frmApp.labelErrorQPM3.Visible = true;
            frmApp.labelErrorQPM3.ForeColor = Color.Red;
            frmApp.labelErrorQPM3.Enabled = true;
            frmApp.tabControlMain.TabIndex = 1;
            Application.DoEvents();
        }
    }
}
