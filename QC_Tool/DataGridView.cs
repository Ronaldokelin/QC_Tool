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
                frmApp.dataGridViewCheckTools.Rows[0].Cells[2].Value = frmApp.CheckDirectoryQpmCli();

                if (frmApp.dataGridViewCheckTools.Rows[0].Cells[2].Value.ToString() == "OK")
                {
                    frmApp.dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.White;
                    frmApp.buttonActions.Enabled = true;
                    uts.cleanLabel();
                }

                else
                {
                    frmApp.dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    frmApp.comboBoxProducts.Enabled = false;
                    uts.labelError("QPM-CLI not found, please install the QPM3!");
                }
            }
            catch
            {
                frmApp.dataGridViewCheckTools.Rows[0].Cells[2].Value = "NOK";
                frmApp.dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                uts.labelError("QPM-CLI not found, please install the QPM3!");
            }
        }

        public void PopulateToolDGV()
        {
            frmApp = FormApp.getInstance();
            frmApp.dataGridViewCheckTools.Rows.Add();
            frmApp.dataGridViewCheckTools.Rows[0].Cells[0].Value = "QPM-CLI";
            frmApp.dataGridViewCheckTools.Rows[0].Cells[1].Value = "Software";
            PopulateResultDGV();
        }
    }
}
