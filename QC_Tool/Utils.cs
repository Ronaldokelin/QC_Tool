using System.Drawing;
using System.Windows.Forms;

namespace QC_Tool
{
    class Utils
    {
        FormApp frmApp;

        public void labelError(string error, string colorL)
        {
            frmApp = FormApp.getInstance();
            frmApp.labelErrorQPM3.Text = error;
            frmApp.labelErrorQPM3.Visible = true;
            if (colorL == "red")
                frmApp.labelErrorQPM3.ForeColor = Color.Red;
            else if (colorL == "orange")
                frmApp.labelErrorQPM3.ForeColor = Color.Orange;
            else if (colorL == "green")
                frmApp.labelErrorQPM3.ForeColor = Color.Green;

            frmApp.labelErrorQPM3.Enabled = true;
            frmApp.tabControlMain.TabIndex = 1;
            Application.DoEvents();
        }

        public void cleanLabel()
        {
            frmApp = FormApp.getInstance();
            frmApp.labelErrorQPM3.Text = "";
            frmApp.labelErrorQPM3.Visible = false;
            frmApp.labelErrorQPM3.Enabled = false;
        }

        public void disableAll()//to do
        {
            frmApp.comboBoxEstation.Enabled = false;
            frmApp.comboBoxProducts.Enabled = false;
        }
    }
}
