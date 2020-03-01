namespace Ultimate_Settings_Panel
{
    partial class cmdoutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxcmdoutput = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtboxcmdoutput
            // 
            // 
            // 
            // 
            this.txtboxcmdoutput.CustomButton.Image = null;
            this.txtboxcmdoutput.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.txtboxcmdoutput.CustomButton.Name = "";
            this.txtboxcmdoutput.CustomButton.Size = new System.Drawing.Size(495, 495);
            this.txtboxcmdoutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxcmdoutput.CustomButton.TabIndex = 1;
            this.txtboxcmdoutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxcmdoutput.CustomButton.UseSelectable = true;
            this.txtboxcmdoutput.CustomButton.Visible = false;
            this.txtboxcmdoutput.Lines = new string[0];
            this.txtboxcmdoutput.Location = new System.Drawing.Point(12, 63);
            this.txtboxcmdoutput.MaxLength = 32767;
            this.txtboxcmdoutput.Multiline = true;
            this.txtboxcmdoutput.Name = "txtboxcmdoutput";
            this.txtboxcmdoutput.PasswordChar = '\0';
            this.txtboxcmdoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxcmdoutput.SelectedText = "";
            this.txtboxcmdoutput.SelectionLength = 0;
            this.txtboxcmdoutput.SelectionStart = 0;
            this.txtboxcmdoutput.ShortcutsEnabled = true;
            this.txtboxcmdoutput.Size = new System.Drawing.Size(563, 449);
            this.txtboxcmdoutput.TabIndex = 0;
            this.txtboxcmdoutput.UseSelectable = true;
            this.txtboxcmdoutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxcmdoutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(359, 518);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 36);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Export to TXT";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(460, 518);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(95, 36);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Close";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cmdoutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 561);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtboxcmdoutput);
            this.Name = "cmdoutput";
            this.Text = "Command Output";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtboxcmdoutput;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}