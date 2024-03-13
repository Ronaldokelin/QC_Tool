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
            do
            {
                copyResponseFile();
                frmApp.buttonActions.BackColor = Color.Orange;
                Application.DoEvents();
                Thread.Sleep(2000);
                count++;
                frmApp.buttonActions.BackColor = Color.Gray;
                Application.DoEvents();
                Thread.Sleep(2000);
            }
            while (count < 550 && status == false);

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
        }
    }
}
