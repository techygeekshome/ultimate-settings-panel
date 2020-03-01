using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class firefox
    {
        public void launchFirefox()
        {
            Process.Start("firefox.exe", "https://blog.techygeekshome.info");
        }
        public void privatebrowsing()
        {
            Process.Start("firefox.exe", "-private-window https://blog.techygeekshome.info");
        }
        public void preferences()
        {
            Process.Start("firefox.exe", "-preferences");
        }
        public void setdefaultbrowser()
        {
            Process.Start("firefox.exe", "-setdefaultbrowser");
        }
        public void safemode()
        {
            Process.Start("firefox.exe", "-safemode");
        }
    }
}
