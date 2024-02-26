using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QC_Tool
{
    public partial class FormApp : Form
    {
        ReadingXMLFile readXML;
        private static FormApp INSTANCE = null;

        public FormApp()
        {
            InitializeComponent();
            PopulateToolDGV();
            INSTANCE = this;
            GetClasses();
            readXML.FillingComboBoxProducts();
        }

        public static FormApp getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormApp();

            return INSTANCE;
        }

        private void GetClasses()
        {
            readXML = new ReadingXMLFile();
        }
        public void PopulateToolDGV()
        {
            dataGridViewCheckTools.Rows.Add();
            dataGridViewCheckTools.Rows[0].Cells[0].Value = "QPM-CLI";
            PopulateResultDGV();
        }

        /* private bool CheckProcess(string tool)
         {
             try
             {
                 Process[] processList = Process.GetProcesses();
                 int i = 0;
                 string[] list = new string[2000000];
                 foreach (Process process in processList)
                 {
                     string processName = process.ToString();
                     processName = processName.Replace("System.Diagnostics.Process ", "");

                     if (processName == "(" + tool + ")")
                         return true;
                 }
                 return false;
             }
             catch
             { return false; }
         }
         */

        /* private void cmd()
         {
             string strCmdText;
             strCmdText = @"/C qpm-cli --license-list > C:\prod\License_List.txt";

             Process.Start("CMD.exe", strCmdText);
         }*/

        private string CheckDirectoryQpmCli()
        {
            try
            {
                string directory = @"C:\Program Files (x86)\Qualcomm\QPM-CLI";

                if (Directory.Exists(directory))
                    return "PASS";

                else
                    return "FAIL";
            }
            catch
            { return "FAIL"; }
        }

        private void PopulateResultDGV()
        {
            try
            {
                dataGridViewCheckTools.Rows[0].Cells[1].Value = CheckDirectoryQpmCli();

                if (dataGridViewCheckTools.Rows[0].Cells[1].Value.ToString() == "PASS")
                    dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.White;

                else
                {
                    dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    MessageBox.Show("QPM-CLI not found, please install the QPM3");
                    comboBoxProducts.Enabled = false;
                }

                this.dataGridViewCheckTools.ClearSelection();
                dataGridViewCheckTools.CurrentCell = null;
                //dataGridViewCheckTools.ClearSelection();
                //if (dataGridViewCheckTools.Focused)
                //    dataGridViewCheckTools.DataBindingComplete -= DataGridView_DataBindingComplete;

                //dataGridViewCheckTools.ClearSelection();

                // dataGridViewCheckTools.SelectedCells[1];

            }

            catch
            {
                dataGridViewCheckTools.Rows[0].Cells[1].Value = "FAIL";
                dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                MessageBox.Show("QPM-CLI not found, please install the QPM3");
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEstation.Enabled = true;
            buttonActions.Enabled = false;
            comboBoxEstation.Items.Clear();
            readXML.FillingComboBoxStations(readXML.allProducts);
        }

        private void buttonActions_Click(object sender, EventArgs e)
        {
            readXML.FillingDGVTools(readXML.indexProduct, readXML.countStationName);
        }

        private void comboBoxEstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonActions.Enabled = true;
        }
    }
}
