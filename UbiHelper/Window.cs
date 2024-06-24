using System;
using System.Diagnostics;
using System.IO;

namespace UbiHelper
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            Framework.Functions.RunSetup();
            Framework.Interface.SetInterface(this, panel1, label1, label2, pictureBox3, pictureBox1);

            //imageFiles = Directory.GetFiles(@"G:\Pictures\Wallpapers", "*.jpg");
            imageFiles = Directory.GetFiles(@"G:\Pictures\Wallpapers"/*Variables.screenshotDirectoryUbi*/, "*.jpg", SearchOption.AllDirectories);
            timer1.Interval = 5000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Variables.savegameDirectory, "test");
            DialogResult result = Framework.Interface.CustomMessageBox("Do you want to backup or restore your savegames?", "Save Manager", "Backup", "Restore");
            if (result == DialogResult.Yes) { Framework.Functions.CopyDirectory(Variables.userIdFolder, Variables.savegameDirectory); }
            else if (result == DialogResult.No) { Framework.Functions.CopyDirectory(Variables.savegameDirectory, Variables.userIdFolder); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Framework.Functions.UncompressScreenshots(progressBar1);
        }

        private string[] imageFiles;
        private Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageFiles.Length > 0)
            {
                string randomImage = imageFiles[random.Next(imageFiles.Length)];
                string randomImage2 = imageFiles[random.Next(imageFiles.Length)];
                pictureBox2.Image = Image.FromFile(randomImage);
                pictureBox4.Image = Image.FromFile(randomImage2);
            }
            else
            {
                // Handle the case where there are no image files
                pictureBox2.Image = null;
                pictureBox4.Image = null;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"/e,{Variables.screenshotDirectory}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"/e,{Variables.savegameDirectory}");
        }
    }
}