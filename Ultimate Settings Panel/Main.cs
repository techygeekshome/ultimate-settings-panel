using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Ultimate_Settings_Panel
{
    public partial class Main : MetroForm
    {
        // Variables
        Settings.general general = new Settings.general();
        Settings.chrome chrome = new Settings.chrome();
        Settings.firefox firefox = new Settings.firefox();
        Settings.internetexplorer internetexplorer = new Settings.internetexplorer();
        Settings.cmdexport cmdexport = new Settings.cmdexport();
        Settings.shutdown shutdown = new Settings.shutdown();
        Settings.powershell powershell = new Settings.powershell();
        Settings.serveradmin serveradmin = new Settings.serveradmin();
        Settings.outlook outlook = new Settings.outlook();
        Settings.controlpanel controlpanel = new Settings.controlpanel();
        Settings.windows windows = new Settings.windows();
        Settings.tricks tricks = new Settings.tricks();
        Settings.checkforupdates _checkforupdates = new Settings.checkforupdates();
        Settings.MSEdge _msedge = new Settings.MSEdge();
        PowerStatus pw = SystemInformation.PowerStatus;

        // Strings
        string compname = SystemInformation.ComputerName;
        string username = SystemInformation.UserName.ToString();
        string currenttime = DateTime.Now.ToLongTimeString();
        string currentdate = DateTime.Now.ToLongDateString();
        string MessageBoxErrorCode = Environment.NewLine + "Report as a bug - Click back to the Home panel then Report a Bug";
        string versioninformation = "Version 6.6" + Environment.NewLine +
                "March 2020" + Environment.NewLine +
                "    - Some source code changes" + Environment.NewLine +
                "    - Minor bug fixes";
        public Main()
        {
            InitializeComponent();
            // Google Analytic Events
            GoogleAnalyticsApi.TrackEvent("Category", "Action", "Label",1);
            GoogleAnalyticsApi.TrackPageview("Category", "Action", "Label", 1);
            //Set Style Variable
            StyleManager = metroStyleManagerSelector;
            //New Set Style Method Below
            StyleManager.Theme = Properties.Settings.Default.USPThemeStyle;
            StyleManager.Style = Properties.Settings.Default.USPColorStyle;
            //Start timer for date and time display
            timerTime.Start();
            //Display computer information pulled from strings
            metroLabelComputerNameString.Text = compname;
            metroLabelUsernameString.Text = username;
            metroLabelDateString.Text = currentdate;
            mlblTimeString.Text = currenttime;
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, versioninformation, "Version Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void metroTextButtonLaunchChrome_Click(object sender, EventArgs e)
        {
            try
            {
                chrome.launchchrome();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonDisablePlugins_Click(object sender, EventArgs e)
        {
            try
            {
                chrome.disableplugins();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonDisableTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                chrome.disabletranslate();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonKioskMode_Click(object sender, EventArgs e)
        {
            try
            {
                chrome.kioskmode();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonIncognitoMode_Click(object sender, EventArgs e)
        {
            try
            {
                chrome.incognitomode();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonRestoreLastSession_Click(object sender, EventArgs e)
        {
            try
            {
                chrome.restorelastsession();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonLaunchFirefox_Click(object sender, EventArgs e)
        {
            try
            {
                firefox.launchFirefox();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonPrivateBrowsing_Click(object sender, EventArgs e)
        {
            try
            {
                firefox.privatebrowsing();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonPreferences_Click(object sender, EventArgs e)
        {
            try
            {
                firefox.preferences();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonSetFirefoxasDefaultBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                firefox.setdefaultbrowser();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonFirefoxSetasDefaultBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                firefox.safemode();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonLaunchInternetExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                internetexplorer.launchIE();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonNoExtensions_Click(object sender, EventArgs e)
        {
            try
            {
                internetexplorer.NoExtensions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonInPrivateBrowsing_Click(object sender, EventArgs e)
        {
            try
            {
                internetexplorer.InPrivateBrowsing();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton466_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.ipconfig();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton467_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.ipconfigall();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton462_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.dnsinformation();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonComputerSettings_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.computersettings();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton463_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.driverquery();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton464_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.extensionassociations();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton465_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.gpresult();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton468_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.openfiles();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton461_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.systeminformation();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton454_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.tasklist();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton455_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.volumeinformation();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton456_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.windowsversion();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton422_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.abortshutdown();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton415_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.forceshutdown();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton416_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.hibernate();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton417_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.logoff();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton418_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.restart();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton419_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.shutdownmachine();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton420_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.shutdownoptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton421_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown.turnoffhibernation();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonPowershell_Click(object sender, EventArgs e)
        {
            try
            {
                powershell.powershellrun();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButtonPowershellISE_Click(object sender, EventArgs e)
        {
            try
            {
                powershell.powershellise();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton328_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ADDomainandTrusts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton321_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ADDirectoryManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton322_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ADSitesandServices();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton323_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ADUsersandComputers();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton324_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ADSIEdit();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton325_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.AuthorisationManager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton326_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.CertificationAuthorityManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton327_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.CertificateTemplates();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton320_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ClusterAdministrator();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton313_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ComputerManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton314_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ComponentServices();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton315_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ConfigureYourServer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton316_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.DHCPManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton317_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.DiskDefragmenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton318_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.DFS();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton319_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.DNS();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton312_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.EventViewer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton305_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.IndexingService();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton306_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.IPAddressManage();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton307_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.LocalCertificatesManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton308_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.LocalGPOEdit();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton309_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.LocalSecuritySettings();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton310_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.LocalUsersGroups();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton311_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.NetworkLoadBalancing();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton304_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.PerformanceMonitor();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton297_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.PKIViewer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton298_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.PublicKeyManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton299_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.QoS();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton300_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.RemoteDesktops();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton301_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.RemoteStorage();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton302_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.RemovableStorage();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton303_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.RoutingandRemote();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton296_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.SchemaManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton289_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.ServicesManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton290_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.SharedFolders();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton291_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.TelephonyManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton292_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.TerminalServer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton293_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.WMIManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton294_Click(object sender, EventArgs e)
        {
            try
            {
                serveradmin.WINSManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton281_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.finder();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton274_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanautocompletecache();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton275_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleancategories();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton276_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanclientrules();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton277_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleandmrecords();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton278_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanserverrules();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton279_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanfromaddresses();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton280_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanfreebusy();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton273_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanmailtipcache();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton266_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanreminders();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton267_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanrules();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton268_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleansharing();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton269_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleansubscriptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton270_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleansniff();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton271_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.checkclient();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton272_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.cleanconvongoingactions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton265_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.importNK2();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton258_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.nopreview();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton259_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.outlooksafemode();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton260_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetnavpane();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton261_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetquicksteps();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton262_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetsearchcriteria();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton263_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resettodobar();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton264_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetfolders();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton257_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.restoreallviews();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton250_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetsearchcriteria();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton251_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.repairPST();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton252_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetfoldernames();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton253_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.profiles();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton254_Click(object sender, EventArgs e)
        {
            try
            {
                outlook.resetsharedfolders();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton187_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.chkdsk();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton180_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.windowscontrolpanel();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton181_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DesktopGadgets();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton182_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.detailedlicenceinfo();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton183_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.diskcleanup();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton184_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.FamilySafety();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton185_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.FileHistory();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton186_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.FileRecovery();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton179_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.FolderOptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton172_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.GetPrograms();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton173_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.GettingStarted();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton174_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.grouppolicyeditor();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton175_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.HomeGroup();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton176_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.IndexingOptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton177_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.IntelGraphicsMediaControlPanel();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton178_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.iSCSIInitiator();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton171_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.MobilityCenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton164_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.NetworkSharingCenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton165_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.NetworkSetupWizard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton166_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.NotificationAreaIcons();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton167_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ODBCAdmin();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton168_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.OfflineFiles();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton169_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ParentalControls();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton170_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.PerformanceInfo();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton163_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ProblemReports();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton156_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Recovery();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton157_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.regedit();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton158_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.SecurityCenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton159_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.SyncCenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton160_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.taskmanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton161_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.TexttoSpeech();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton162_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Troubleshooting();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton155_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.UACSettings();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton148_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.WelcomeCenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton149_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.WindowsCardSpace();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton150_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.WindowsDefender();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton151_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.windowsexplorer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton152_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.WindowsSideShow();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton234_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DiskPart();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton227_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DiskRAID();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton228_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.EventViewer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton229_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.GPResult();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton230_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.PresentationSettings();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton231_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rstrui.exe");
        }

        private void metroTextButton40_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AccessibilityOptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton141_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ActionCenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton41_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AddNewHardware();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton42_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AdminTools();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton43_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AutoPlay();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton44_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.BitLocker();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton45_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.BluetoothDevices();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton47_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ColorManagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton39_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.CredentialManager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton32_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DefaultPrograms();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton33_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DeviceManager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton34_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DevicesandPrinters();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton35_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.FindFast();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton36_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Fonts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton37_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.GameControllers();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton38_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.GodMode();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton31_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.InfraRed();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton24_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.InternetProperties();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton25_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Keyboard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton26_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.LocationInformation();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton27_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.MailSetupOutlook();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton28_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Modem();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton29_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Mouse();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton30_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.NetworkConnections();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton23_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.PCCard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton16_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.PeopleNearMe();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton17_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.PowerConfig();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton18_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ProgramsandFeatures();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton19_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.RegionandLanguage();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton20_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.RemoteDesktopConnection();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton21_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ScannerandCameras();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton22_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.ScreenResolution();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton15_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.Sound();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton8_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.SystemProperties();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton9_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.TabletPC();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton10_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.TaskScheduler();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton11_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.TimeDate();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton12_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.UserAccounts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton13_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.WindowsFirewall();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton14_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.WindowsUpdate();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                windows.aboutwindows();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            try
            {
                windows.addaprinter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton93_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AddFeaturestoWindows81();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            try
            {
                windows.advancedstartup();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton4_Click(object sender, EventArgs e)
        {
            try
            {
                windows.advancedaccounts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton86_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AnytimeUpgrade();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton91_Click(object sender, EventArgs e)
        {
            try
            {
                windows.bluetoothfiletransfer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton92_Click(object sender, EventArgs e)
        {
            try
            {
                windows.charmap();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton85_Click(object sender, EventArgs e)
        {
            try
            {
                windows.cleartypetuner();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton78_Click(object sender, EventArgs e)
        {
            try
            {
                windows.colormanagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton79_Click(object sender, EventArgs e)
        {
            try
            {
                windows.commandprompt();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton80_Click(object sender, EventArgs e)
        {
            try
            {
                windows.componentservices();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton81_Click(object sender, EventArgs e)
        {
            try
            {
                windows.controlpanel();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton82_Click(object sender, EventArgs e)
        {
            try
            {
                windows.credentialmanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton83_Click(object sender, EventArgs e)
        {
            try
            {
                windows.dataexecution();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton87_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DesktopGadgets();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton77_Click(object sender, EventArgs e)
        {
            try
            {
                windows.directxdiagnosics();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton70_Click(object sender, EventArgs e)
        {
            try
            {
                windows.defragmenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton71_Click(object sender, EventArgs e)
        {
            try
            {
                windows.display();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton72_Click(object sender, EventArgs e)
        {
            try
            {
                windows.driververifymanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton73_Click(object sender, EventArgs e)
        {
            try
            {
                windows.importtocontacts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton74_Click(object sender, EventArgs e)
        {
            try
            {
                windows.internetexplorer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton75_Click(object sender, EventArgs e)
        {
            try
            {
                windows.languagepacks();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton76_Click(object sender, EventArgs e)
        {
            try
            {
                windows.magnifier();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton69_Click(object sender, EventArgs e)
        {
            try
            {
                windows.malicioussoftwarescan();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton62_Click(object sender, EventArgs e)
        {
            try
            {
                windows.managementconsole();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton63_Click(object sender, EventArgs e)
        {
            try
            {
                windows.newscannerwizard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton64_Click(object sender, EventArgs e)
        {
            try
            {
                windows.onscreenkeyboard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton65_Click(object sender, EventArgs e)
        {
            try
            {
                windows.performancemonitor();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton66_Click(object sender, EventArgs e)
        {
            try
            {
                windows.performanceoptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton67_Click(object sender, EventArgs e)
        {
            try
            {
                windows.resourcemonitor();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton68_Click(object sender, EventArgs e)
        {
            try
            {
                windows.setcomputerdefaults();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton61_Click(object sender, EventArgs e)
        {
            try
            {
                windows.snippingtool();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton54_Click(object sender, EventArgs e)
        {
            try
            {
                windows.stepsrecorder();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton55_Click(object sender, EventArgs e)
        {
            try
            {
                windows.stickynotes();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton56_Click(object sender, EventArgs e)
        {
            try
            {
                windows.syncenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton57_Click(object sender, EventArgs e)
        {
            try
            {
                windows.systemconfiguration();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton58_Click(object sender, EventArgs e)
        {
            try
            {
                windows.taskmanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton59_Click(object sender, EventArgs e)
        {
            try
            {
                windows.taskscheduler();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton60_Click(object sender, EventArgs e)
        {
            try
            {
                windows.utilitymanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton51_Click(object sender, EventArgs e)
        {
            try
            {
                windows.volumemixer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton5_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowseasytransfer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton6_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowsexplorer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton53_Click(object sender, EventArgs e)
        {
            try
            {
                windows.aboutwindows();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton52_Click(object sender, EventArgs e)
        {
            try
            {
                windows.addaprinter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton125_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AddFeaturestoWindows10();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton50_Click(object sender, EventArgs e)
        {
            try
            {
                windows.advancedstartup();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton49_Click(object sender, EventArgs e)
        {
            try
            {
                windows.advancedaccounts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton121_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.AnytimeUpgrade();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton123_Click(object sender, EventArgs e)
        {
            try
            {
                windows.bluetoothfiletransfer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton124_Click(object sender, EventArgs e)
        {
            try
            {
                windows.charmap();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton120_Click(object sender, EventArgs e)
        {
            try
            {
                windows.cleartypetuner();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton114_Click(object sender, EventArgs e)
        {
            try
            {
                windows.colormanagement();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton115_Click(object sender, EventArgs e)
        {
            try
            {
                windows.commandprompt();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton116_Click(object sender, EventArgs e)
        {
            try
            {
                windows.componentservices();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton117_Click(object sender, EventArgs e)
        {
            try
            {
                windows.controlpanel();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton118_Click(object sender, EventArgs e)
        {
            try
            {
                windows.credentialmanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton119_Click(object sender, EventArgs e)
        {
            try
            {
                windows.dataexecution();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton122_Click(object sender, EventArgs e)
        {
            try
            {
                controlpanel.DesktopGadgets();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton113_Click(object sender, EventArgs e)
        {
            try
            {
                windows.directxdiagnosics();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton106_Click(object sender, EventArgs e)
        {
            try
            {
                windows.defragmenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton107_Click(object sender, EventArgs e)
        {
            try
            {
                windows.display();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton108_Click(object sender, EventArgs e)
        {
            try
            {
                windows.driververifymanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton109_Click(object sender, EventArgs e)
        {
            try
            {
                windows.importtocontacts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton110_Click(object sender, EventArgs e)
        {
            try
            {
                windows.internetexplorer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton111_Click(object sender, EventArgs e)
        {
            try
            {
                windows.languagepacks();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton112_Click(object sender, EventArgs e)
        {
            try
            {
                windows.magnifier();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton105_Click(object sender, EventArgs e)
        {
            try
            {
                windows.malicioussoftwarescan();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton98_Click(object sender, EventArgs e)
        {
            try
            {
                windows.managementconsole();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton99_Click(object sender, EventArgs e)
        {
            try
            {
                windows.newscannerwizard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton100_Click(object sender, EventArgs e)
        {
            try
            {
                windows.onscreenkeyboard();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton101_Click(object sender, EventArgs e)
        {
            try
            {
                windows.performancemonitor();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton102_Click(object sender, EventArgs e)
        {
            try
            {
                windows.performanceoptions();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton103_Click(object sender, EventArgs e)
        {
            try
            {
                windows.resourcemonitor();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton104_Click(object sender, EventArgs e)
        {
            try
            {
                windows.setcomputerdefaults();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton97_Click(object sender, EventArgs e)
        {
            try
            {
                windows.snippingtool();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton84_Click(object sender, EventArgs e)
        {
            try
            {
                windows.stepsrecorder();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton88_Click(object sender, EventArgs e)
        {
            try
            {
                windows.stickynotes();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton89_Click(object sender, EventArgs e)
        {
            try
            {
                windows.syncenter();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton90_Click(object sender, EventArgs e)
        {
            try
            {
                windows.systemconfiguration();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton94_Click(object sender, EventArgs e)
        {
            try
            {
                windows.taskmanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton95_Click(object sender, EventArgs e)
        {
            try
            {
                windows.taskscheduler();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton96_Click(object sender, EventArgs e)
        {
            try
            {
                windows.utilitymanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton48_Click(object sender, EventArgs e)
        {
            try
            {
                windows.volumemixer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton7_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowseasytransfer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton46_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowsexplorer();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton87_Click_1(object sender, EventArgs e)
        {
            try
            {
                windows.videoapp();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton122_Click_1(object sender, EventArgs e)
        {
            try
            {
                windows.microsoftstore();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton126_Click(object sender, EventArgs e)
        {
            try
            {
                windows.photosapp();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton127_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.netstat();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton128_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowsrepairdisc();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton129_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowsremoteassist();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton130_Click(object sender, EventArgs e)
        {
            try
            {
                windows.wordpad();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton131_Click(object sender, EventArgs e)
        {
            try
            {
                windows.windowsactionmanager();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton134_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.flushdns();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton133_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.getinstalledproducts();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton132_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.netview();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton135_Click(object sender, EventArgs e)
        {
            try
            {
                tricks.starwars();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + Environment.NewLine + "Have you got Windows Telnet Client Installed?" + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton136_Click(object sender, EventArgs e)
        {
            try
            {
                tricks.weatherservice();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + Environment.NewLine + "Have you got Windows Telnet Client Installed?" + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton138_Click(object sender, EventArgs e)
        {
            try
            {
                tricks.telehack();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + Environment.NewLine + "Have you got Windows Telnet Client Installed?" + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            //Pre-populate the time label text
            //metroLabelTimeString.Text = DateTime.Now.ToLongTimeString();
            mlblTimeString.Text = DateTime.Now.ToLongTimeString();
            //Start the timer
            timerTime.Start();
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxExit_MouseHover(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = System.Drawing.Color.Red;
            pictureBoxExit.Cursor = Cursors.Hand;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            pictureBoxExit.Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = System.Drawing.Color.LightBlue;
            pictureBox6.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.Cursor = Cursors.Default;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackColor = System.Drawing.Color.LightBlue;
            pictureBox8.Cursor = Cursors.Hand;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = System.Drawing.Color.Transparent;
            pictureBox8.Cursor = Cursors.Default;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.BackColor = System.Drawing.Color.LightBlue;
            pictureBox12.Cursor = Cursors.Hand;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackColor = System.Drawing.Color.Transparent;
            pictureBox12.Cursor = Cursors.Default;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.BackColor = System.Drawing.Color.LightBlue;
            pictureBox10.Cursor = Cursors.Hand;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.BackColor = System.Drawing.Color.Transparent;
            pictureBox10.Cursor = Cursors.Default;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.BackColor = System.Drawing.Color.LightBlue;
            pictureBox9.Cursor = Cursors.Hand;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackColor = System.Drawing.Color.Transparent;
            pictureBox9.Cursor = Cursors.Default;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.BackColor = System.Drawing.Color.LightBlue;
            pictureBox11.Cursor = Cursors.Hand;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.BackColor = System.Drawing.Color.Transparent;
            pictureBox11.Cursor = Cursors.Default;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.BackColor = System.Drawing.Color.LightBlue;
            pictureBox13.Cursor = Cursors.Hand;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackColor = System.Drawing.Color.Transparent;
            pictureBox13.Cursor = Cursors.Default;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.BackColor = System.Drawing.Color.LightBlue;
            pictureBox14.Cursor = Cursors.Hand;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.BackColor = System.Drawing.Color.Transparent;
            pictureBox14.Cursor = Cursors.Default;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            _checkforupdates.updateUSP();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            general.TGHWebsite();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            general.facebook();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            general.twitter();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            general.youtube();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            general.pinterest();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            general.instagram();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            general.googleplus();
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBoxTheme.SelectedIndex)
            {
                case 0:
                    metroStyleManagerSelector.Theme = MetroThemeStyle.Light;
                    Properties.Settings.Default.USPThemeStyle = MetroThemeStyle.Light;
                    Properties.Settings.Default.Save();
                    break;
                case 1:
                    metroStyleManagerSelector.Theme = MetroThemeStyle.Dark;
                    Properties.Settings.Default.USPThemeStyle = MetroThemeStyle.Dark;
                    Properties.Settings.Default.Save();
                    break;
            }
        }

        private void metroComboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManagerSelector.Style = (MetroColorStyle)Convert.ToInt32(metroComboBoxStyle.SelectedIndex);
            Properties.Settings.Default.USPColorStyle = (MetroColorStyle)Convert.ToInt32(metroComboBoxStyle.SelectedIndex);
            Properties.Settings.Default.Save();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip TooltipTheme = new ToolTip();
                metroToolTipTheme.SetToolTip(this.metroComboBoxTheme, "Select a theme from the drop down list");
                metroToolTipStyle.SetToolTip(this.metroComboBoxStyle, "Select a colour style from the drop down list");
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n{0}\n", ex.Message);
            }
        }

        private void metroTileAbout_Click(object sender, EventArgs e)
        {
            About _about = new About();
            _about.ShowDialog();
            _about.Dispose();
        }

        private void metroTileInstructions_Click(object sender, EventArgs e)
        {
            general.instructions();
        }

        private void metroTileReportaBug_Click(object sender, EventArgs e)
        {
            general.reportabug();
        }

        private void metroTileVersionInformation_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, versioninformation, "Version Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroTileVideoDemo_Click(object sender, EventArgs e)
        {
            general.videodemo();
        }

        private void metroTileUpdates_Click(object sender, EventArgs e)
        {
            _checkforupdates.updateUSP();
        }

        private void metroTextButton137_Click(object sender, EventArgs e)
        {
            try
            {
                _msedge.launchMSEdge();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + Environment.NewLine + "Are you using Windows 10?" + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroTextButton139_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Not yet available programmatically but will be added fully once Microsoft release the code information." + Environment.NewLine + Environment.NewLine + "To carry this out manually, open Edge and in the address bar type the following:" + Environment.NewLine + Environment.NewLine + "about:flags", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroTextButton140_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Not yet available programmatically but will be added fully once Microsoft release the code information." + Environment.NewLine + Environment.NewLine + "To carry this out manually, open Edge and then press CTRL+SHIFT+P", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroTextButton142_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Not yet available programmatically but will be added fully once Microsoft release the code information." + Environment.NewLine + Environment.NewLine + "To carry this out manually, open Edge and in the address bar type the following: " + Environment.NewLine + Environment.NewLine + "read:[URL you want to open]", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            general.TGHWebsite();
        }

        private void btn_CMD_DisableSMBv1_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.disablesmbv1();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_CMDDeleteIEHistory_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.deleteiehistory();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_CMDBitLocker_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.bitlocker();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_CMDFindLargeFiles_Click(object sender, EventArgs e)
        {
            try
            {
                cmdexport.resetWMI();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString() + MessageBoxErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            general.github();
        }
    }
    }
