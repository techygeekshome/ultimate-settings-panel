using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class chrome
    {
        public void launchchrome()
        {
            Process.Start("chrome.exe", "https://blog.techygeekshome.info");
        }

        public void disableplugins()
        {
            Process.Start("chrome.exe", "--disable-plugins");
        }

        public void disabletranslate()
        {
            Process.Start("chrome.exe", "--disable-translate");
        }

        public void kioskmode()
        {
            Process.Start("chrome.exe", "--kiosk");
        }

        public void incognitomode()
        {
            Process.Start("chrome.exe", "--incognito");
        }

        public void restorelastsession()
        {
            Process.Start("chrome.exe", "--restore-last-session");
        }
    }
}
