using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QC_Tool
{
    public partial class FormApp : Form
    {
        ReadingXMLFile readXML;
        Cmd CmdC;
        DataGridView Dgv;
        private static FormApp INSTANCE = null;
        public string pathFileLicensesList = string.Empty;

        public FormApp()
        {
            InitializeComponent();
            INSTANCE = this;
            GetClasses();
            Dgv.PopulateToolDGV();
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

        public string CheckDirectoryQpmCli()
        {
            try
            {
                string directory = @"C:\Program Files (x86)\Qualcomm\QPM-CLI";
                string pathSave = @".\License_List.txt";
                pathFileLicensesList = pathSave;

                if (Directory.EnumerateFileSystemEntries(directory).Any())
                {
                    CmdC.Commands("qpm-cli --license-list", pathSave + "1");//tirar 1

                    if (File.Exists(pathSave))
                    {
                        using (StreamReader reader = new StreamReader(pathSave))
                        {
                            string line = string.Empty;

                            if ((line = reader.ReadLine()) == null)
                                return "NOK";

                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.Contains("is not recognized as an internal or external command"))
                                    return "NOK";
                            }
                        }
                    }
                    else
                        return "NOK";
                }
                else
                    return "NOK";

                return "OK";
            }
            catch
            { return "NOK"; }
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
            CmdC.GetHostID();
            readXML.countNokLicenses();
        }

        private void comboBoxEstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            readXML.FillingDGVTools(readXML.indexProduct, readXML.countStationName);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            comboBoxProducts.Text = "MACAN24";
            comboBoxEstation.Text = "5GFR1BDTST";
        }
    }
}