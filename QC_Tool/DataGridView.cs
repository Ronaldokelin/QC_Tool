using System.Drawing;

namespace QC_Tool
{
    class DataGridView
    {
        FormApp frmApp;

        public void PopulateResultDGV()
        {
            frmApp = FormApp.getInstance();

            try
            {
                frmApp.dataGridViewCheckTools.Rows[0].Cells[1].Value = frmApp.CheckDirectoryQpmCli();

                if (frmApp.dataGridViewCheckTools.Rows[0].Cells[1].Value.ToString() == "PASS")
                    frmApp.dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.White;

                else
                {
                    frmApp.dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    frmApp.comboBoxProducts.Enabled = false;
                    frmApp.labelError("QPM-CLI not found, please install the QPM3!");
                }
            }
            catch
            {
                frmApp.dataGridViewCheckTools.Rows[0].Cells[1].Value = "FAIL";
                frmApp.dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                frmApp.labelErrorQPM3.Text = ("QPM-CLI not found, please install the QPM3");
                frmApp.labelErrorQPM3.Visible = true;
            }
        }
    }
}
