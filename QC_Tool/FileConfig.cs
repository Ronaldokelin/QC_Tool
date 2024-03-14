using System.IO;

namespace QC_Tool
{
    static class FileConfig
    {
        static string filepath = @".\LicensesNOK.txt";

        public static void deleteFile()
        {
            try
            {
                if (File.Exists(filepath))
                    File.Delete(filepath);
            }
            catch { }
        }

        public static void writeFile(string line)
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

        public static void readFile()
        {
            try
            {
                if (!File.Exists(@".\LicensesNOK.txt"))
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