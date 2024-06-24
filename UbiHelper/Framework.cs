using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UbiHelper
{
    public static class Framework
    {
        public static class Functions
        {
            public static void CopyDirectory(string sourceDirectory, string targetDirectory)
            {
                Directory.CreateDirectory(targetDirectory);

                foreach (string file in Directory.GetFiles(sourceDirectory))
                {
                    string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(file));
                    File.Copy(file, targetFilePath, true); // true to overwrite if file already exists
                }

                foreach (string subdirectory in Directory.GetDirectories(sourceDirectory))
                {
                    string targetSubdirectoryPath = Path.Combine(targetDirectory, Path.GetFileName(subdirectory));
                    CopyDirectory(subdirectory, targetSubdirectoryPath);
                }
            }

            public static void UncompressScreenshots(ProgressBar progressBar)
            {
                progressBar.Visible = true;
                int totalFolders = Directory.EnumerateDirectories(Variables.screenshotDirectoryUbi).Count();
                int currentFolder = 0;

                foreach (string folder in Directory.EnumerateDirectories(Variables.screenshotDirectoryUbi))
                {
                    currentFolder++;
                    progressBar.Value = (int)((currentFolder / (double)totalFolders) * 50);

                    bool hasPngFiles = false;
                    int totalFiles = Directory.EnumerateFiles(folder, "*.jpg").Count();
                    int currentFile = 0;

                    foreach (string file in Directory.EnumerateFiles(folder, "*.jpg"))
                    {
                        currentFile++;
                        progressBar.Value = (int)((currentFolder / (double)totalFolders) * 50 + (currentFile / (double)totalFiles) * 50);

                        string pngFilePath = file.Replace(".jpg", ".png");
                        if (File.Exists(pngFilePath)) { hasPngFiles = true; }
                        File.Delete(file); 
                    }

                    if (hasPngFiles)
                    {
                        string folderName = Path.GetFileName(folder);
                        string targetFolder = Path.Combine(Variables.screenshotDirectory, folderName);

                        Directory.Move(folder, targetFolder);
                    }

                    Application.DoEvents();
                }

                progressBar.Value = 100;
                MessageBox.Show("Successfully removed compressed screenshots!", "Process complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar.Visible = false;
            }

            public static void RunSetup()
            {
                if (!Directory.Exists(Variables.dataDirectory) && !Directory.Exists(Variables.savegameDirectory) && !Directory.Exists(Variables.screenshotDirectory))
                {
                    Directory.CreateDirectory(Variables.dataDirectory);
                    Directory.CreateDirectory(Variables.savegameDirectory);
                    Directory.CreateDirectory(Variables.screenshotDirectory);
                }
            }
        }

        public static class Interface
        {
            public static DialogResult CustomMessageBox(string message, string caption, string backupButtonText, string restoreButtonText)
            {
                Form dialogForm = new Form();
                dialogForm.Text = caption;
                dialogForm.Size = new Size(310, 125);
                dialogForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialogForm.MaximizeBox = false;
                dialogForm.MinimizeBox = false;
                dialogForm.StartPosition = FormStartPosition.CenterParent;
                dialogForm.TopMost = true;

                Label messageLabel = new Label();
                messageLabel.Text = message;
                messageLabel.AutoSize = true;
                messageLabel.Location = new Point(10, 10);

                Button backupButton = new Button();
                backupButton.Text = backupButtonText;
                backupButton.Location = new Point(10, 50);
                backupButton.DialogResult = DialogResult.Yes;

                Button restoreButton = new Button();
                restoreButton.Text = restoreButtonText;
                restoreButton.Location = new Point(180, 50);
                restoreButton.DialogResult = DialogResult.No;

                dialogForm.Controls.Add(messageLabel);
                dialogForm.Controls.Add(backupButton);
                dialogForm.Controls.Add(restoreButton);

                dialogForm.AcceptButton = backupButton;
                dialogForm.CancelButton = restoreButton;

                return dialogForm.ShowDialog();
            }

            public static bool IsDarkModeEnabled()
            {
                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object? value = key.GetValue("AppsUseLightTheme");
                        return value != null && (int)value == 0;
                    }
                }

                return false;
            }

            public static void SetInterface(Form form, Control control, Control control2, Control control3, Control tooltipControl, Control tooltipControl2)
            {
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                control3.Text = $"Welcome, {Variables.username}!";
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(tooltipControl, "View Screenshots");
                ToolTip toolTip2 = new ToolTip();
                toolTip2.SetToolTip(tooltipControl2, "View Savegames");

                if (IsDarkModeEnabled())
                {
                    form.BackColor = Color.FromArgb(32, 32, 32);
                    control.BackColor = Color.FromArgb(24, 24, 24);
                    control2.ForeColor = Color.FromArgb(200, 200, 200);
                    control3.ForeColor = Color.FromArgb(200, 200, 200);
                }
                else
                {
                    form.BackColor = Color.FromArgb(200, 200, 200);
                    control.BackColor = Color.FromArgb(175, 175, 175);
                    control2.ForeColor = Color.FromArgb(24, 24, 24);
                    control3.ForeColor = Color.FromArgb(24, 24, 24);
                }
            }
        }
    }
}