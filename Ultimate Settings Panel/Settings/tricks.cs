using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class tricks
    {
        // Variables
        Process process = new Process();
        public void starwars()
        {
                process.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
                process.StartInfo.Arguments = "/k telnet towel.blinkenlights.nl";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
                process.WaitForExit();
        }
        public void weatherservice()
        {
            process.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
            process.StartInfo.Arguments = "/k telnet rainmaker.wunderground.com";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }
        public void telehack()
        {
            process.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
            process.StartInfo.Arguments = "/k telnet telehack.com";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
        }
        
    }
}

