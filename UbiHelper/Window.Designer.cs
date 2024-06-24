namespace UbiHelper
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 221);
            button1.Name = "button1";
            button1.Size = new Size(119, 32);
            button1.TabIndex = 0;
            button1.Text = "Save Manager";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 24);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 9F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(107, 4);
            label1.Name = "label1";
            label1.Size = new Size(252, 14);
            label1.TabIndex = 2;
            label1.Text = "Developed and maintained by UNKNØWN";
            // 
            // button2
            // 
            button2.Location = new Point(290, 221);
            button2.Name = "button2";
            button2.Size = new Size(163, 32);
            button2.TabIndex = 2;
            button2.Text = "Uncompress Screenshots";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 43);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(225, 16);
            progressBar1.TabIndex = 3;
            progressBar1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 4;
            label2.Text = "Welcome, USERNAME!";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(364, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(413, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 217);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 11;
            label3.Text = "ℹ️ Information";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Bahnschrift", 9F);
            linkLabel1.LinkColor = Color.FromArgb(128, 255, 255);
            linkLabel1.Location = new Point(27, 246);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 14);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Discord";
            linkLabel1.VisitedLinkColor = Color.FromArgb(255, 128, 255);
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Red;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Bahnschrift", 9F);
            linkLabel2.LinkColor = Color.FromArgb(128, 255, 255);
            linkLabel2.Location = new Point(81, 246);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(44, 14);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "GitHub";
            linkLabel2.VisitedLinkColor = Color.FromArgb(255, 128, 255);
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(22, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(242, 93);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(209, 109);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 16;
            label4.Text = "Screenshot Preview";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(469, 295);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Window";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubi Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private ProgressBar progressBar1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
    }
}
