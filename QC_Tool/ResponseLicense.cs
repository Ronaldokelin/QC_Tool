using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace QC_Tool
{
    class ResponseLicense
    {
        Cmd CmdC = new Cmd();
        FormApp frmApp = FormApp.getInstance();
        Utils uts = new Utils();
        ReadingXMLFile readXML = new ReadingXMLFile();
        private bool status = false;
        QcLicenses ql = new QcLicenses();

        public int copyResponseFile()
        {
            string filePath = @".\LicensesNOK.txt";
            string destinationDir = "";
            string sourceDir = "";
            string pattern = ".resp";
            string licNOK = "";
            string path = CmdC.getHostName();

            try
            {

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
                    {
                        do
                        {
                            licNOK = reader.ReadLine();
                            sourceDir = (@"Q:\QualcommLicenseRequests\" + licNOK + @"\" + path + @"\responses");
                            destinationDir = (@"C:\" + path + @"\responses");

                            if (!Directory.Exists(destinationDir))
                                Directory.CreateDirectory(destinationDir);

                            if (Directory.Exists(sourceDir))
                            {
                                foreach (string file_name in Directory.GetFiles(sourceDir, "*" + pattern + "*", System.IO.SearchOption.AllDirectories))
                                {
                                    string[] vet = file_name.Split('\\');
                                    string fileActivate = vet.Last();
                                    File.Copy(file_name, destinationDir + @"\" + fileActivate, true);
                                    status = true;
                                }
                            }
                        }
                        while (licNOK != null);
                    }

                }
                return 0;
            }
            catch
            {
                return 1;
            }

        }
        public void verifyResponseFile()
        {
            int count = 0;
            var response = TimeSpan.FromMinutes(30.0);

            do
            {
                copyResponseFile();
                frmApp.buttonActions.BackColor = Color.Orange;
                uts.labelError("Waiting Response " + response + " min", "orange");

                Application.DoEvents();
                Thread.Sleep(1000);
                response -= TimeSpan.FromSeconds(1);

                count++;
                frmApp.buttonActions.BackColor = Color.Gray;
                uts.labelError("Waiting Response " + response + " min", "orange");
                Application.DoEvents();
                Thread.Sleep(1000);
                response -= TimeSpan.FromSeconds(1);

            }
            while (count < 900 && status == false);

            if (status == false)
            {
                uts.labelError("File responses not received from server!!!", "red");
                frmApp.buttonActions.BackColor = Color.Red;
            }
            else
            {
                uts.labelError("File responses received from server!!!", "green");
                frmApp.buttonActions.BackColor = Color.Green;
                activateLicense();
            }
        }

        public void activateLicense()
        {
            string path = CmdC.getHostName();
            CmdC.Commands(@"qpm-cli --process-responses C:\" + path);
            //readXML.FillingDGVTools(readXML.indexProduct, readXML.countStationName);
            ql.verifyInstallLicense();
            frmApp.buttonExit.Enabled = true;
        }
    }
}
