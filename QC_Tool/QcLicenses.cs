using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Tool
{
    class QcLicenses
    {
        FormApp frmApp;
        ReadingXMLFile rxf = new ReadingXMLFile();

        public void copyDirectory(string path)
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
                            Directory.CreateDirectory(destFileName);

                        sourceFileName = (@"C:\" + path + @"\" + path + ".id");

                        if (File.Exists(sourceFileName))
                            File.Copy(sourceFileName, (destFileName + @"\" + path + ".id"));
                    }
                }
            }
            catch { }
        }
    }
}
