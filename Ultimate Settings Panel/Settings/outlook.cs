using System.Diagnostics;
using System.IO;

namespace Ultimate_Settings_Panel.Settings
{
    class outlook
    {
        private string checkclientv = "/checkclient";
        private string cleanaddressesv = "/cleanfromaddresses";
        private string cleanautocompletecachev = "/cleanautocompletecache";
        private string cleancatsv = "/cleancategories";
        private string cleanclientrulesv = "/cleanclientrules";
        private string cleanconvongoingactionsv = "/cleanconvongoingactions";
        private string cleandmrecordsv = "/cleandmrecords";
        private string cleanfindersv = "/cleanfinders";
        private string cleanfreebusyv = "/cleanfreebusy";
        private string cleanmailtipcachev = "/cleanmailtipcache";
        private string cleanremindersv = "/cleanreminders";
        private string cleanrulesv = "/cleanrules";
        private string cleanserverrulesv = "/cleanserverrules";
        private string cleansharingv = "/cleansharing";
        private string cleansniffv = "/cleansniff";
        private string cleansubscriptionsv = "/cleansubscriptions";
        private string cleanviewsv = "/cleanviews";
        private string finderv = "/finder";
        private string importNK2v = "/importNK2";
        private string nopreviewv = "/nopreview";
        private string outlook2010executablefile = @"C:\Program Files\Microsoft Office\Office14\OUTLOOK.EXE";
        private string outlook2013executablefile = @"C:\Program Files\Microsoft Office\Office15\OUTLOOK.EXE";
        private string profilesv = "/profiles";
        private string resetfoldernamesv = "/resetfoldernames";
        private string resetfoldersv = "/resetfolders";
        private string resetnavpanev = "/resetnavpane";
        private string resetquickstepsv = "/resetquicksteps";
        private string resetsearchcriteriav = "/resetsearchcriteria";
        private string resetsharedfoldersv = "/resetsharedfolders";
        private string resettodobarv = "/resettodobar";
        private string safemodev = "/Safe";
        private string scanpst2010executablefile = @"C:\Program Files\Microsoft Office\Office14\Scanpst.exe";
        private string scanpst2013executablefile = @"C:\Program Files\Microsoft Office\Office15\Scanpst.exe";

        public void checkclient()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, checkclientv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, checkclientv);
            }
        }

        public void cleanautocompletecache()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanautocompletecachev);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanautocompletecachev);
            }
        }

        public void cleancategories()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleancatsv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleancatsv);
            }
        }

        public void cleanclientrules()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanclientrulesv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanclientrulesv);
            }
        }

        public void cleanconvongoingactions()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanconvongoingactionsv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanconvongoingactionsv);
            }
        }

        public void cleandmrecords()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleandmrecordsv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleandmrecordsv);
            }
        }

        public void cleanfinders()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanfindersv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanfindersv);
            }
        }

        public void cleanfreebusy()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanfreebusyv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanfreebusyv);
            }
        }

        public void cleanfromaddresses()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanaddressesv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanaddressesv);
            }
        }

        public void cleanmailtipcache()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanmailtipcachev);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanmailtipcachev);
            }
        }

        public void cleanreminders()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanremindersv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanremindersv);
            }
        }

        public void cleanrules()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanrulesv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanrulesv);
            }
        }

        public void cleanserverrules()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanserverrulesv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanserverrulesv);
            }
        }

        public void cleansharing()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleansharingv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleansharingv);
            }
        }

        public void cleansniff()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleansniffv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleansniffv);
            }
        }

        public void cleansubscriptions()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleansubscriptionsv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleansubscriptionsv);
            }
        }

        public void finder()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, finderv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, finderv);
            }
        }

        public void importNK2()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, importNK2v);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, importNK2v);
            }
        }

        public void nopreview()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, nopreviewv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, nopreviewv);
            }
        }

        public void outlooksafemode()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, safemodev);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, safemodev);
            }
        }

        public void profiles()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, profilesv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, profilesv);
            }
        }

        public void repairPST()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(scanpst2010executablefile);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(scanpst2013executablefile);
            }
        }

        public void resetfoldernames()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resetfoldernamesv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resetfoldernamesv);
            }
        }

        public void resetfolders()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resetfoldersv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resetfoldersv);
            }
        }

        public void resetnavpane()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resetnavpanev);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resetnavpanev);
            }
        }

        public void resetquicksteps()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resetquickstepsv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resetquickstepsv);
            }
        }

        public void resetsearchcriteria()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resetsearchcriteriav);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resetsearchcriteriav);
            }
        }

        public void resetsharedfolders()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resetsharedfoldersv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resetsharedfoldersv);
            }
        }

        public void resettodobar()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, resettodobarv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, resettodobarv);
            }
        }

        public void restoreallviews()
        {
            if (File.Exists(outlook2010executablefile))
            {
                Process.Start(outlook2010executablefile, cleanviewsv);
            }
            else if (File.Exists(outlook2013executablefile))
            {
                Process.Start(outlook2013executablefile, cleanviewsv);
            }
        }
    }
}