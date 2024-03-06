using System.IO;

namespace QC_Tool
{
    class FileConfig
    {
        string filepath = @".\LicensesNOK.txt";

        public void writeFile(string line)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath, FileMode.Create, FileAccess.Write)))
                    {
                        writer.WriteLine(line);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath, FileMode.Append, FileAccess.Write)))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch { }
        }

        public void readFile()
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    using (StreamReader reader = new StreamReader(new FileStream(filepath, FileMode.Open, FileAccess.Read)))
                    {
                        reader.ReadLine();
                    }
                }
            }
            catch { }
        }
    }
}
