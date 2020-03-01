using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Ultimate_Settings_Panel.Settings
{
    class controlpanel
    {
public void AccessibilityOptions()
        {
            Process.Start("utilman.exe");
        }

        public void ActionCenter()
        {
            Process.Start("Wscui.cpl");
        }

        public void AddFeaturestoWindows81()
        {
            Process.Start("control", "/name Microsoft.WindowsAnytimeUpgrade");
        }

        public void AddFeaturestoWindows10()
        {
            Process.Start(@"C:\Windows\System32\OptionalFeatures.exe");
        }

        public void AddNewHardware()
        {
            Process.Start("control", "sysdm.cpl add new hardware");
        }

        public void AdminTools()
        {
            Process.Start("control", "admintools");
        }

        public void AnytimeUpgrade()
        {
            Process.Start("control", "/name Microsoft.WindowsAnytimeUpgrade");
        }

        public void AutoPlay()
        {
            Process.Start("control", "/name Microsoft.AutoPlay");
        }

        public void BitLocker()
        {
            Process.Start("control", "/name Microsoft.BitLockerDriveEncryption");
        }

        public void BluetoothDevices()
        {
            Process.Start("BthProps.cpl");
        }

        public void chkdsk()
        {
            new Process
            {
                StartInfo = {
                CreateNoWindow = false,
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "ChkDsk.exe",
                Arguments = "C:" + " /f",
                UseShellExecute = false
            }
            }.Start();
        }

        public void ColorManagement()
        {
            Process.Start("control", "/name Microsoft.ColorManagement");
        }

        public void windowscontrolpanel()
        {
            Process.Start("control");
        }

        public void CredentialManager()
        {
            Process.Start("control", "/name Microsoft.CredentialManager");
        }

        public void DefaultPrograms()
        {
            Process.Start("control", "/name Microsoft.DefaultPrograms");
        }

        public void DesktopGadgets()
        {
            Process.Start("control", "/name Microsoft.DesktopGadgets");
        }

        public void detailedlicenceinfo()
        {
            string arguments = "/dlv";
            Process.Start("slmgr.vbs", arguments);
        }

        public void DeviceManager()
        {
            Process.Start("HdwWiz.cpl");
        }

        public void DevicesandPrinters()
        {
            Process.Start("control", "printers");
        }

        public void diskcleanup()
        {
            Process.Start("cleanmgr.exe");
        }

        public void DiskPart()
        {
            Process.Start("diskpart");
        }

        public void DiskRAID()
        {
            Process.Start("diskraid");
        }

        public void EventViewer()
        {
            Process.Start("eventvwr");
        }

        public void FamilySafety()
        {
            Process.Start("control", "/name Microsoft.ParentalControls");
        }

        public void FileHistory()
        {
            Process.Start("control", "/name Microsoft.FileHistory");
        }

        public void FileRecovery()
        {
            Process.Start("control", "/name Microsoft.BackupAndRestore");
        }

        public void FindFast()
        {
            Process.Start("control", "findfast.cpl");
        }

        public void FolderOptions()
        {
            Process.Start("control", "/name Microsoft.FolderOptions");
        }

        public void Fonts()
        {
            Process.Start("control", "fonts");
        }

        public void GameControllers()
        {
            Process.Start("Joy.cpl");
        }

        public void GetPrograms()
        {
            Process.Start("control", "/name Microsoft.GetPrograms");
        }

        public void GettingStarted()
        {
            Process.Start("control", "/name Microsoft.GettingStarted");
        }

        public void GodMode()
        {
            Directory.CreateDirectory(@"C:\\TGH\\GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}");
            Process.Start(@"C:\TGH\GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}");
        }

        public void GPResult()
        {
            string arguments = @"/h c:\windows\temp\gpresult.html";
            Process.Start("gpresult", arguments);
            Thread.Sleep(0x1388);
            Process.Start(@"c:\windows\temp\gpresult.html");
        }

        public void grouppolicyeditor()
        {
            Process.Start("gpedit.msc");
        }

        public void HomeGroup()
        {
            Process.Start("control", "/name Microsoft.HomeGroup");
        }

        public void IndexingOptions()
        {
            Process.Start("control", "/name Microsoft.IndexingOptions");
        }

        public void InfraRed()
        {
            Process.Start("Irprops.cpl");
        }

        public void IntelGraphicsMediaControlPanel()
        {
            Process.Start("lgfxcpl.cpl");
        }

        public void InternetProperties()
        {
            Process.Start("Inetcpl.cpl");
        }

        public void iSCSIInitiator()
        {
            Process.Start("control", "/name Microsoft.iSCSIInitiator");
        }

        public void Keyboard()
        {
            Process.Start("control", "main.cpl keyboard");
        }

        public void LocationInformation()
        {
            Process.Start("Telephon.cpl");
        }

        public void MailSetupOutlook()
        {
            Process.Start("control", "MLCFG32.cpl");
        }

        public void MobilityCenter()
        {
            Process.Start("control", "/name Microsoft.MobilityCenter");
        }

        public void Modem()
        {
            Process.Start("control", "modem.cpl");
        }

        public void Mouse()
        {
            Process.Start("Main.cpl");
        }

        public void NetworkConnections()
        {
            Process.Start("ncpa.cpl");
        }

        public void NetworkSetupWizard()
        {
            Process.Start("control", "netsetup.cpl");
        }

        public void NetworkSharingCenter()
        {
            Process.Start("control", "/name Microsoft.NetworkAndSharingCenter");
        }

        public void NotificationAreaIcons()
        {
            Process.Start("control", "/name Microsoft.NotificationAreaIcons");
        }

        public void ODBCAdmin()
        {
            Process.Start("control", "odbccp32.cpl");
        }

        public void OfflineFiles()
        {
            Process.Start("control", "/name Microsoft.OfflineFiles");
        }

        public void ParentalControls()
        {
            Process.Start("control", "/name Microsoft.ParentalControls");
        }

        public void PCCard()
        {
            Process.Start("control", "main.cpl pc card");
        }

        public void PeopleNearMe()
        {
            Process.Start("CollAb.cpl");
        }

        public void PerformanceInfo()
        {
            Process.Start("control", "/name Microsoft.PerformanceInformationAndTools");
        }

        public void PowerConfig()
        {
            Process.Start("powercfg.cpl");
        }

        public void PresentationSettings()
        {
            Process.Start("presentationsettings.exe");
        }

        public void ProblemReports()
        {
            Process.Start("control", "/name Microsoft.ProblemReportsAndSolutions");
        }

        public void ProgramsandFeatures()
        {
            Process.Start("AppWiz.cpl");
        }

        public void Recovery()
        {
            Process.Start("control", "/name Microsoft.Recovery");
        }

        public void regedit()
        {
            Process.Start("regedit");
        }

        public void RegionandLanguage()
        {
            Process.Start("Intl.cpl");
        }

        public void RemoteDesktopConnection()
        {
            Process.Start("mstsc.exe");
        }

        public void ScannerandCameras()
        {
            Process.Start("control", "sticpl.cpl");
        }

        public void ScreenResolution()
        {
            Process.Start("DESK.cpl");
        }

        public void SecurityCenter()
        {
            Process.Start("control", "/name Microsoft.SecurityCenter");
        }

        public void Sound()
        {
            Process.Start("mmsys.cpl");
        }

        public void SyncCenter()
        {
            Process.Start("control", "/name Microsoft.SyncCenter");
        }

        public void SystemProperties()
        {
            Process.Start("sysdm.cpl");
        }

        public void SystemRestore()
        {
            Process.Start("rstrui.exe");
        }

        public void TabletPC()
        {
            Process.Start("TabletPC.cpl");
        }

        public void taskmanager()
        {
            Process.Start("taskmgr");
        }

        public void TaskScheduler()
        {
            Process.Start("control", "schedtasks");
        }

        public void TexttoSpeech()
        {
            Process.Start("control", "/name Microsoft.TextToSpeech");
        }

        public void TimeDate()
        {
            Process.Start("TimeDate.cpl");
        }

        public void Troubleshooting()
        {
            Process.Start("control", "/name Microsoft.Troubleshooting");
        }

        public void UACSettings()
        {
            Process.Start("UserAccountControlSettings.exe");
        }

        public void UserAccounts()
        {
            Process.Start("control", "userpasswords");
        }

        public void WelcomeCenter()
        {
            Process.Start("control", "/name Microsoft.WelcomeCenter");
        }

        public void WindowsCardSpace()
        {
            Process.Start("control", "/name Microsoft.CardSpace");
        }

        public void WindowsDefender()
        {
            Process.Start("control", "/name Microsoft.WindowsDefender");
        }

        public void windowsexplorer()
        {
            Process.Start("explorer");
        }

        public void WindowsFirewall()
        {
            Process.Start("FireWall.cpl");
        }

        public void WindowsSideShow()
        {
            Process.Start("control", "/name Microsoft.WindowsSideShow");
        }

        public void WindowsUpdate()
        {
            Process.Start("control", "/name Microsoft.WindowsUpdate");
        }
    }
}