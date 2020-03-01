using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class shutdown
    {
        private string shutdownstring = "shutdown";

        public void abortshutdown()
        {
            Process.Start(shutdownstring, "/a");
        }

        public void forceshutdown()
        {
            Process.Start(shutdownstring, "/f");
        }

        public void hibernate()
        {
            Process.Start(shutdownstring, "/h");
        }

        public void logoff()
        {
            Process.Start(shutdownstring, "/l");
        }

        public void restart()
        {
            Process.Start(shutdownstring, "/r");
        }

        public void shutdownmachine()
        {
            Process.Start(shutdownstring, "/s");
        }

        public void shutdownoptions()
        {
            Process.Start(shutdownstring, "/i");
        }

        public void turnoffhibernation()
        {
            Process.Start("powercfg -h off");
        }
    }
}
