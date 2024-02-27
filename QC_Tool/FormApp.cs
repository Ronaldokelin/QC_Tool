using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace QC_Tool
{
    public partial class FormApp : Form
    {
        ReadingXMLFile readXML;
        Cmd CmdC;
        DataGridView Dgv;
        private static FormApp INSTANCE = null;

        public FormApp()
        {
            InitializeComponent();
            GetClasses();
            INSTANCE = this;
            PopulateToolDGV();
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
            CmdC = new Cmd();
            Dgv = new DataGridView();
        }
        public void PopulateToolDGV()
        {
            dataGridViewCheckTools.Rows.Add();
            dataGridViewCheckTools.Rows[0].Cells[0].Value = "QPM-CLI";
            Dgv.PopulateResultDGV();
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

        public string CheckDirectoryQpmCli()
        {
            try
            {
                string directory = @"C:\Program Files (x86)\Qualcomm\QPM-CLI";
                string pathSave = @".\License_List.txt";
                if (Directory.EnumerateFileSystemEntries(directory).Any())
                {
                    CmdC.Commands("qpm-cli --license-list", pathSave);

                    if (File.Exists(pathSave))
                    {
                        using (StreamReader reader = new StreamReader(pathSave))
                        {
                            string line = string.Empty;

                            if ((line = reader.ReadLine()) == null)
                                return "FAIL";

                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.Contains("is not recognized as an internal or external command"))
                                    return "FAIL";
                            }
                        }
                    }
                    else
                        return "FAIL";
                }
                else
                    return "FAIL";

                return "PASS";
            }
            catch
            { return "FAIL"; }
        }

        public void labelError(string error)
        {
            labelErrorQPM3.Text = error;
            labelErrorQPM3.Visible = true;
            labelErrorQPM3.ForeColor = Color.Red;
            labelErrorQPM3.Enabled = true;
            Application.DoEvents();
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
