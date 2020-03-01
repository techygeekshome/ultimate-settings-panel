using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class internetexplorer
    {
        public void launchIE()
        {
            Process.Start("iexplore.exe", "https://blog.techygeekshome.info");
        }
        public void NoExtensions()
        {
            Process.Start("iexplore.exe", "-extoff https://blog.techygeekshome.info");
        }
        public void InPrivateBrowsing()
        {
            Process.Start("iexplore.exe", "-private https://blog.techygeekshome.info");
        }
    }
}
