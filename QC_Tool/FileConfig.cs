using System.IO;

namespace QC_Tool
{
    static class FileConfig
    {
        public static void deleteFile(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                    File.Delete(filepath);
            }
            catch { }
        }

        public static void writeFile(string filepath, string line)
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
    }
}