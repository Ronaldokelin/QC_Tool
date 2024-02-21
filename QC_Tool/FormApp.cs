using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QC_Tool
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
            CkeckQPM3();
        }

        private void CkeckQPM3()
        {
            dataGridViewCheckTools.Rows.Add();
            dataGridViewCheckTools.Rows[0].Cells[0].Value = "QualcommPackageManager33";
        }

        private bool QPM3(string tool)
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
            {
                return false;
            }
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            PopulateDGV();
        }
        private void PopulateDGV()
        {
            try
            {
                if (QPM3(dataGridViewCheckTools.Rows[0].Cells[0].Value.ToString()))
                {
                    dataGridViewCheckTools.Rows[0].Cells[1].Value = "PASS";
                    dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dataGridViewCheckTools.Rows[0].Cells[1].Value = "FAIL";
                    dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            catch { }
        }
    }
}
