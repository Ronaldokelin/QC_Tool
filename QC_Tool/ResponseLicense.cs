using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Tool
{
    class ResponseLicense
    {
        Cmd CmdC = new Cmd();

        public void checkResponse()
        {
        }
        public int CopyFunction()
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
                        licNOK = reader.ReadLine();

                        while (licNOK != null)
                        {
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

                                }
                            }
                            licNOK = reader.ReadLine();
                        }
                    }
                }
            }
            catch (IOException)
            {
                return 1;
            }
            return 0;
        }
    }
}
