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
        QcLicenses QcL;
        ResponseLicense rl;
        private static FormApp INSTANCE = null;
        public string pathFileLicensesList = string.Empty;
        public string[] lic;
        Utils uts;
        string filepath = @".\LicensesNOK.txt";
        string pathSave = @"C:\temp\License_List.txt";
        CreateNewProduct CnP;
        PopulateListBoxEngineer PLBE;


        public FormApp()
        {
            InitializeComponent();
            INSTANCE = this;
            GetClasses();
            Dgv.PopulateToolDGV();
            readXML.FillingComboBoxProducts();
            PLBE.populatelistBoxProductNameFile();
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
            QcL = new QcLicenses();
            rl = new ResponseLicense();
            uts = new Utils();
            CnP = new CreateNewProduct();
            PLBE = new PopulateListBoxEngineer();
        }

        public string CheckDirectoryQpmCli()
        {
            try
            {
                string directory = @"C:\Program Files (x86)\Qualcomm\QPM-CLI";
                pathFileLicensesList = pathSave;

                if (Directory.EnumerateFileSystemEntries(directory).Any())
                {
                    if (File.Exists(pathSave))
                        File.Delete(pathSave);

                    CmdC.Commands("qpm-cli --license-list", pathSave);

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
            buttonExit.Enabled = false;
            uts.disableAll();
            getLicensesResponses();
            buttonExit.Enabled = true;
        }

        private void getLicensesResponses()
        {
            FileConfig.deleteFile(filepath);
            buttonActions.Enabled = false;

            if (CmdC.GetHostID())
            {
                readXML.countNokLicenses(filepath);

                if (QcL.copyDirectory())
                {
                    textBoxDetails.Text += "Send License ID Successfully!!!" + Environment.NewLine;
                    textBoxDetails.Text += "Waiting to receive license file within the next 30 min!!!" + Environment.NewLine;
                    rl.verifyResponseFile();
                }
            }
        }
        private void comboBoxEstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonActions.Enabled = false;
            readXML.FillingDGVTools(readXML.indexProduct, readXML.countStationName);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FileConfig.deleteFile(filepath);
            FileConfig.deleteFile(pathSave);
            Environment.Exit(0);
        }

        private void buttonAddPath_Click(object sender, EventArgs e)
        {
            CnP.writeToXML();
        }

        private void buttonPassProductNameFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.passValueButton(listBoxProductNameFile, listBoxProductInclude);
        }

        private void buttonReturnProductNameFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.removeValueButton(listBoxProductNameFile, listBoxProductInclude);
        }

        private void buttonPassBoxStationFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.passValueButton(listBoxStationFile, listBoxStationInclude);
        }

        private void buttonReturnBoxStationFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.removeValueButton(listBoxStationFile, listBoxStationInclude);
        }

        private void buttonPassLicenseTypeFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.passValueButton(listBoxLicenseTypeFile, listBoxLicenseTypeInclude);
        }

        private void buttonReturnLicenseTypeFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.removeValueButton(listBoxLicenseTypeFile, listBoxLicenseTypeInclude);
        }

        private void buttonPassUserFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.passValueButton(listBoxUserFile, listBoxUserInclude);
        }

        private void buttonReturnUserFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.removeValueButton(listBoxUserFile, listBoxUserInclude);
        }

        private void buttonPassItemTypeFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.passValueButton(listBoxItemTypeFile, listBoxItemTipeInclude);
        }

        private void buttonReturnItemTypeFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.removeValueButton(listBoxItemTypeFile, listBoxItemTipeInclude);
        }

        private void buttonPassLicenseNumberFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.passValueButton(listBoxLicenseNumberFile, listBoxLicenseNumberInclude);
        }

        private void buttonReturnLicenseNumberFile_Click(object sender, EventArgs e)
        {
            ButtonsFunctionsEngineerTab.removeValueButton(listBoxLicenseNumberFile, listBoxLicenseNumberInclude);
        }
    }
}