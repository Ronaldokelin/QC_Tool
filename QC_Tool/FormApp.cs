using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            GetClasses();
            INSTANCE = this;
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
        private void PopulateToolDGV()
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
        private void buttonTry_Click(object sender, EventArgs e)
        {
            readXML.FillingDGVProduct();
        }

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
                    dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;

            }

            catch
            {
                dataGridViewCheckTools.Rows[0].Cells[1].Value = "FAIL";
                dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEstation.Enabled = true;
        }
    }
}
