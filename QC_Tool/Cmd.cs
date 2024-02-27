using System.Diagnostics;

namespace QC_Tool
{
    class Cmd
    {
        FormApp frmApp;

        public void Commands(string command, string path)
        {
            frmApp = FormApp.getInstance();

            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "CMD.exe";
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(command + " > " + path);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
            catch { }
        }
    }
}
