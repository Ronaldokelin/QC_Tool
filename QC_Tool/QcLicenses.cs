using System.IO;

namespace QC_Tool
{
    class QcLicenses
    {
        FormApp frmApp;
        ReadingXMLFile rxf = new ReadingXMLFile();
        Logger log = new Logger();

        public bool copyDirectory(string path)
        {
            frmApp = FormApp.getInstance();
            string sourceFileName = string.Empty;
            string destFileName = string.Empty;

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
    }
}
