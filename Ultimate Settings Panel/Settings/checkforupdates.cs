using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Ultimate_Settings_Panel.Settings
{
    class checkforupdates
    {
        private string updateXMLstring = "https://blog.techygeekshome.info/downloads/updates/usp/USPUpdate.xml";

        public void updateUSP()
        {
            string fileName = "";
            Version version = null;
            string str2 = "";
            string updateXMLstring = this.updateXMLstring;
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(updateXMLstring);
                reader.MoveToContent();
                string name = "";
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "appinfo"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            name = reader.Name;
                        }
                        else if ((reader.NodeType == XmlNodeType.Text) && reader.HasValue)
                        {
                            if (name != "version")
                            {
                                if (name == "url")
                                {
                                    goto Label_00B7;
                                }
                                if (name == "about")
                                {
                                    goto Label_00C1;
                                }
                            }
                            else
                            {
                                version = new Version(reader.Value);
                            }
                        }
                        continue;
                    Label_00B7:
                        fileName = reader.Value;
                        continue;
                    Label_00C1:
                        str2 = reader.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Environment.Exit(1);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            Version version2 = Assembly.GetExecutingAssembly().GetName().Version;
            if (version2.CompareTo(version) < 0)
            {
                string str5 = $"New version found! Your version: { version2}.Newest version: { version}.Added in this version: { str2}. ";
                if (DialogResult.No != MessageBox.Show(str5 + "\nWould you like to download this update?", "Check for updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        Process.Start(fileName);
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Your version: " + version2 + "  is up to date.", "Check for Updates", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}