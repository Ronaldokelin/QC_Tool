using System.IO;

namespace QC_Tool
{
    class QcLicenses
    {
        FormApp frmApp;
        Logger log = new Logger();
        Cmd CmdC = new Cmd();

        public bool copyDirectory()
        {
            frmApp = FormApp.getInstance();
            string sourceFileName = string.Empty;
            string destFileName = string.Empty;
            string path = CmdC.getHostName();

            try
            {
                if (Directory.Exists(@"C:\" + path))
                {
                    for (int i = 0; i < frmApp.lic.Length; i++)
                    {
                        destFileName = (@"Q:\QualcommLicenseRequests\" + frmApp.lic[i] + @"\" + path);
                        if (!Directory.Exists(destFileName))
                        {
                            Directory.CreateDirectory(destFileName);
                            log.textBoxLog("Created folder at: " + destFileName);
                        }

                        sourceFileName = (@"C:\" + path + @"\" + path + ".id");

                        if (File.Exists(sourceFileName))
                        {
                            File.Copy(sourceFileName, (destFileName + @"\" + path + ".id"), true);
                            log.textBoxLog("Copy file at: " + destFileName + @"\" + path + ".id");

                        }
                    }
                }
                return true;
            }
            catch { return false; }
        }

        public void verifyInstallLicense()
        {
            string path = CmdC.getHostName();
            string sourceDir = @"C:\" + path + @"\responses";
            string pattern = ".done";
            int count = 0;
            frmApp = FormApp.getInstance();

            try
            {
                if (Directory.Exists(sourceDir))
                {
                    foreach (string file_name in Directory.GetFiles(sourceDir, "*" + pattern + "*", System.IO.SearchOption.AllDirectories))
                    {
                        count++;
                    }
                }
                frmApp.textBoxDetails.Text += count + " Licenses installed!";
            }
            catch { }

        }
    }
}
