using System.Diagnostics;

namespace Ultimate_Settings_Panel.Settings
{
    class serveradmin
    {
        public void ADDirectoryManagement()
        {
            Process.Start("admgmt.msc");
        }

        public void ADDomainandTrusts()
        {
            Process.Start("domain.msc");
        }

        public void ADSIEdit()
        {
            Process.Start("adsiedit.msc");
        }

        public void ADSitesandServices()
        {
            Process.Start("dssite.msc");
        }

        public void ADUsersandComputers()
        {
            Process.Start("dsa.msc");
        }

        public void AuthorisationManager()
        {
            Process.Start("azman.msc");
        }

        public void CertificateTemplates()
        {
            Process.Start("certtmpl.msc");
        }

        public void CertificationAuthorityManagement()
        {
            Process.Start("certsrv.msc");
        }

        public void ClusterAdministrator()
        {
            Process.Start("cluadmin.msc");
        }

        public void ComponentServices()
        {
            Process.Start("comexp.msc");
        }

        public void ComputerManagement()
        {
            Process.Start("compmgmt.msc");
        }

        public void ConfigureYourServer()
        {
            Process.Start("cys.exe");
        }

        public void DeviceManager()
        {
            Process.Start("devmgmt.msc");
        }

        public void DFS()
        {
            Process.Start("dfsgui.msc");
        }

        public void DHCPManagement()
        {
            Process.Start("dhcpmgmt.msc");
        }

        public void DiskDefragmenter()
        {
            Process.Start("dfrg.msc");
        }

        public void DNS()
        {
            Process.Start("dnsmgmt.msc");
        }

        public void EventViewer()
        {
            Process.Start("eventvwr.msc");
        }

        public void IndexingService()
        {
            Process.Start("ciadv.msc");
        }

        public void IPAddressManage()
        {
            Process.Start("ipaddrmgmt.msc");
        }

        public void LicensingManager()
        {
            Process.Start("llsmgr.msc");
        }

        public void LocalCertificatesManagement()
        {
            Process.Start("certmgr.msc");
        }

        public void LocalGPOEdit()
        {
            Process.Start("gpedit.msc");
        }

        public void LocalSecuritySettings()
        {
            Process.Start("secpol.msc");
        }

        public void LocalUsersGroups()
        {
            Process.Start("lusrmgr.msc");
        }

        public void NetworkLoadBalancing()
        {
            Process.Start("nlbmgr.exe");
        }

        public void PerformanceMonitor()
        {
            Process.Start("perfmon.msc");
        }

        public void PKIViewer()
        {
            Process.Start("pkiview.msc");
        }

        public void PublicKeyManagement()
        {
            Process.Start("pkmgmt.msc");
        }

        public void QoS()
        {
            Process.Start("acssnap.msc");
        }

        public void RemoteDesktops()
        {
            Process.Start("tsmmc.msc");
        }

        public void RemoteStorage()
        {
            Process.Start("rsadmin.msc");
        }

        public void RemovableStorage()
        {
            Process.Start("ntmsmgr.msc");
        }

        public void RoutingandRemote()
        {
            Process.Start("rrasmgmt.msc");
        }

        public void SchemaManagement()
        {
            Process.Start("schmmgmt.msc");
        }

        public void ServicesManagement()
        {
            Process.Start("services.msc");
        }

        public void SharedFolders()
        {
            Process.Start("fsmgmt.msc");
        }

        public void TelephonyManagement()
        {
            Process.Start("tapimgmt.msc");
        }

        public void TerminalServer()
        {
            Process.Start("tscc.msc");
        }

        public void WINSManagement()
        {
            Process.Start("winsmgmt.msc");
        }

        public void WMIManagement()
        {
            Process.Start("wmimgmt.msc");
        }
    }
}
