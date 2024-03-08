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
            frmApp.labelWarning.Text = error;
            frmApp.labelWarning.Visible = true;

            if (colorL == "red")
                frmApp.labelWarning.ForeColor = Color.Red;

            else if (colorL == "orange")
                frmApp.labelWarning.ForeColor = Color.Orange;

            else if (colorL == "green")
                frmApp.labelWarning.ForeColor = Color.Green;

            frmApp.labelWarning.Enabled = true;
            frmApp.labelWarning.BringToFront();
            frmApp.tabControlMain.TabIndex = 1;
            Application.DoEvents();
        }

        public void cleanLabel()
        {
            frmApp = FormApp.getInstance();
            frmApp.labelWarning.Text = "";
            frmApp.labelWarning.Visible = false;
            frmApp.labelWarning.Enabled = false;
        }

        public void disableAll()//to do
        {
            frmApp.comboBoxEstation.Enabled = false;
            frmApp.comboBoxProducts.Enabled = false;
        }
    }
}
