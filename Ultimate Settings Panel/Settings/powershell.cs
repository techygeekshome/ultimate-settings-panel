using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class powershell
    {
        public void powershellise()
        {
            Process.Start("powershell_ise");
        }
        public void powershellrun()
        {
            Process.Start("powershell");
        }
    }
}
