using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class cmdexport
    {
        // Variables
        Process process = new Process();
        public void computersettings()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C set";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void dnsinformation()
        {
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/displaydns";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void driverquery()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C driverquery";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void extensionassociations()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C assoc";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void gpresult()
        {
            process.StartInfo.FileName = "gpresult";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/r";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void ipconfig()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C ipconfig";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void ipconfigall()
        {
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/all";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void openfiles()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C openfiles";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void systeminformation()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C systeminfo";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void tasklist()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C tasklist";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void volumeinformation()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C vol";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void windowsversion()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C ver";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }

        public void netstat()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C netstat";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void flushdns()
        {
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/flushdns";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void getinstalledproducts()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C wmic product get name";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void netview()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C netview";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void disablesmbv1()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C dism /online /norestart /disable-feature /featurename:SMB1Protocol";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void deleteiehistory()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C rundll32.exe inetcpl.cpl,ClearMyTracksByProcess 255";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void bitlocker()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C manage-bde -status";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
        public void resetWMI()
        {
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = "/C winmgmt /resetrepository";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            new cmdoutput(process.StandardOutput.ReadToEnd()).Show();
        }
    }
}
