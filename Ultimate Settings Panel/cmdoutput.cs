using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework;

namespace Ultimate_Settings_Panel
{
    public partial class cmdoutput : MetroForm
    {
        public cmdoutput(string ipconfigoutput)
        {
            InitializeComponent();
            txtboxcmdoutput.Text = ipconfigoutput;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            exporttotxt();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        public void exporttotxt()
        {
            try
            {
                saveFileDialog.Title = "Save Image";
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.FilterIndex = 1;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName == "")
                    {
                        return;
                    }
                    else
                    {
                        File.WriteAllText(saveFileDialog.FileName, txtboxcmdoutput.Text);
                    }
                }
                else
                {
                    // Nothing
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString(), "Export Error");
            }
        }
    }
}
