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

        public int CopyFunction()
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

                if (countTimer >= 4)//mudar pra 12
                    frmApp.timer.Change(Timeout.Infinite, Timeout.Infinite);
                else
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
                                        uts.cleanLabel();
                                        string[] vet = file_name.Split('\\');
                                        string fileActivate = vet.Last();
                                        File.Copy(file_name, destinationDir + @"\" + fileActivate, true);
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
    }
}
