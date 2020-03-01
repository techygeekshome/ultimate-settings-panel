using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class windows
    {
        public void aboutwindows()
        {
            Process.Start("winver");
        }

        public void addaprinter()
        {
            Process.Start("rundll32", "printui.dll,PrintUIEntry /il");
        }

        public void advancedaccounts()
        {
            Process.Start("netplwiz");
        }

        public void advancedstartup()
        {
            Process.Start("bootim");
        }

        public void bluetoothfiletransfer()
        {
            Process.Start("fsquirt");
        }

        public void charmap()
        {
            Process.Start("charmap");
        }

        public void cleartypetuner()
        {
            Process.Start("cttune");
        }

        public void colormanagement()
        {
            Process.Start("colorcpl");
        }

        public void commandprompt()
        {
            Process.Start("cmd");
        }

        public void componentservices()
        {
            Process.Start("dcomcnfg");
        }

        public void controlpanel()
        {
            Process.Start("control");
        }

        public void credentialmanager()
        {
            Process.Start("rundll32.exe", "keymgr.dll, KRShowKeyMgr");
        }

        public void dataexecution()
        {
            Process.Start("systempropertiesdataexecutionprevention");
        }

        public void defragmenter()
        {
            Process.Start("dfrgui.exe");
        }

        public void directxdiagnosics()
        {
            Process.Start("dxdiag");
        }

        public void display()
        {
            Process.Start("dpiscaling");
        }

        public void driververifymanager()
        {
            Process.Start("verifier");
        }

        public void importtocontacts()
        {
            Process.Start("wabmig");
        }

        public void internetexplorer()
        {
            Process.Start("iexplore");
        }

        public void languagepacks()
        {
            Process.Start("lpksetup");
        }

        public void magnifier()
        {
            Process.Start("magnify");
        }

        public void malicioussoftwarescan()
        {
            Process.Start("mrt");
        }

        public void managementconsole()
        {
            Process.Start("mmc");
        }

        public void microsoftstore()
        {
            Process.Start("ms-windows-store://publisher/?name=Microsoft Corporation"); 
        }

        public void newscannerwizard()
        {
            Process.Start("wiaacmgr");
        }

        public void onscreenkeyboard()
        {
            Process.Start("osk");
        }

        public void performancemonitor()
        {
            Process.Start("perfmon");
        }

        public void performanceoptions()
        {
            Process.Start("systempropertiesperformance");
        }

        public void photosapp()
        {
            Process.Start("ms-photos://");
        }

        public void resourcemonitor()
        {
            Process.Start("resmon");
        }

        public void setcomputerdefaults()
        {
            Process.Start("computerdefaults");
        }

        public void snippingtool()
        {
            Process.Start("snippingtool");
        }

        public void stepsrecorder()
        {
            Process.Start("psr");
        }

        public void stickynotes()
        {
            Process.Start("explorer", @"shell:AppsFolder\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe!App");
        }

        public void syncenter()
        {
            Process.Start("mobsync");
        }

        public void systemconfiguration()
        {
            Process.Start("msconfig");
        }

        public void taskmanager()
        {
            Process.Start("taskmgr");
        }

        public void taskscheduler()
        {
            Process.Start("control", "schedtasks");
        }

        public void utilitymanager()
        {
            Process.Start("utilman");
        }

        public void videoapp()
        {
            Process.Start("microsoftvideo://");
        }

        public void volumemixer()
        {
            Process.Start("sndvol");
        }

        public void windowseasytransfer()
        {
            Process.Start("migwiz");
        }

        public void windowsexplorer()
        {
            Process.Start("explorer");
        }

        public void windowsrepairdisc()
        {
            Process.Start("recdisc");
        }

        public void windowsremoteassist()
        {
            Process.Start("msra");
        }

        public void wordpad()
        {
            Process.Start("write");
        }

        public void windowsactionmanager()
        {
            Process.Start("wscui.cpl");
        }
    }
}