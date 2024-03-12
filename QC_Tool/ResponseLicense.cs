using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace QC_Tool
{
    class ResponseLicense
    {
        Cmd CmdC = new Cmd();
        FormApp frmApp;
        int countTimer = 0;
        Utils uts = new Utils();
        ReadingXMLFile readXML = new ReadingXMLFile();

        public int copyResponseFile()
        {
            string filePath = @".\LicensesNOK.txt";
            string destinationDir = "";
            string sourceDir = "";
            string pattern = ".resp";
            string licNOK = "";
            string path = CmdC.getHostName();
            frmApp = FormApp.getInstance();

            try
            {
                countTimer += 1;

                if (countTimer >= 2)//mudar pra 12{
                {
                    frmApp.timer.Enabled = false;
                    frmApp.timer.Stop();
                    frmApp.timer.Dispose();
                    Application.DoEvents();
                    Thread.Sleep(15000);
                    //uts.cleanLabel();
                    //uts.labelError("File responses not received from server", "Red");
                }

                else
                {
                    if (File.Exists(filePath))
                    {
                        using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
                        {
                            do
                            {
                                //  frmApp.textBoxDetails.Text += countTimer + "º Attempt" + Environment.NewLine;
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
                                        //frmApp.timer.Enabled = false;
                                        //frmApp.timer.Stop();
                                        //frmApp.timer.Dispose();
                                        //uts.cleanLabel();
                                        //uts.labelError("File responses received from server", "Green");
                                        //activateLicense();
                                    }
                                }
                            }
                            while (licNOK != null);
                        }
                    }
                }
                return 0;
            }
            catch (IOException)
            {
                return 1;
            }
        }

        public void activateLicense()
        {
            string path = CmdC.getHostName();
            CmdC.Commands(@"qpm-cli -–process-responses C:\" + path);
            //readXML.FillingDGVTools(readXML.indexProduct, readXML.countStationName);
        }
    }
}
