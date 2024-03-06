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
        public void checkResponse()
        {

        }
        private int CopyFunction()
        {
            string destinationDir = "";
            string sourceDir = "";
            string pattern = ".resp";
            FileInfo fileInfo;
            try
            {
                foreach (string file_name in Directory.GetFiles(sourceDir, "*" + pattern + "*", System.IO.SearchOption.AllDirectories))
                {
                    fileInfo = new FileInfo(file_name);

                    File.Copy(file_name, destinationDir + file_name.Substring(sourceDir.Length), true);
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
