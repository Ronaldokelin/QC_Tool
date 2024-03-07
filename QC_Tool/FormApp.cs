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
        public System.Threading.Timer timer;
        FileConfig fc = new FileConfig();
        Utils uts;

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
            QcL = new QcLicenses();
            rl = new ResponseLicense();
            uts = new Utils();
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
            fc.deleteFile();
            buttonActions.Enabled = false;

            uts.labelError("Waiting Response...","orange");

            if (CmdC.GetHostID())
            {
                readXML.countNokLicenses();

                if (QcL.copyDirectory(CmdC.getHostName()))
                {
                    MessageBox.Show("Send License ID Successfully!!!", "ID License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    callTimer();
                }
            }
        }

        private void comboBoxEstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            readXML.FillingDGVTools(readXML.indexProduct, readXML.countStationName);
        }

        private void buttonHelp_Click(object sender, EventArgs e)//tirar
        {
            comboBoxProducts.Text = "MACAN24";
            comboBoxEstation.Text = "5GFR1BDTST";
        }

        private void callTimer()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(20);

            timer = new System.Threading.Timer((obj) =>
            {
                rl.CopyFunction();
            }, null, startTimeSpan, periodTimeSpan);
        }
    }
}