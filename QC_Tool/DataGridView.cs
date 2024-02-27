using System.Drawing;

namespace QC_Tool
{
    class DataGridView
    {
        FormApp frmApp;
        Utils uts = new Utils();

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
                    uts.labelError("QPM-CLI not found, please install the QPM3!");
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

        public void PopulateToolDGV()
        {
            frmApp = FormApp.getInstance();

            frmApp.dataGridViewCheckTools.Rows.Add();
            frmApp.dataGridViewCheckTools.Rows[0].Cells[0].Value = "QPM-CLI";
            PopulateResultDGV();
        }
    }
}
