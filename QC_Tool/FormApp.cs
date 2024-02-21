using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dataGridViewCheckTools.Rows[0].Cells[0].Value = "QDCM_motorola_a5269361-8345-11ee-8637-026b10d3716b";
            dataGridViewCheckTools.Rows[0].Cells[1].Value = "NOk";

            if (dataGridViewCheckTools.Rows[0].Cells[1].Value == "NOk")
                dataGridViewCheckTools.Rows[0].DefaultCellStyle.BackColor = Color.Red;

        }

        private void OnlyViewComboBoxs()
        {

        }

    }
}
