namespace QIX.BiblePTT
{
    partial class fmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAbout));
            windowBarApp = new AntdUI.WindowBar();
            panel1 = new Panel();
            label12 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            panel2 = new Panel();
            lbWebsite = new AntdUI.Label();
            lbEmail = new AntdUI.Label();
            lbGithub = new AntdUI.Label();
            lbFacebook = new AntdUI.Label();
            labelName = new AntdUI.Label();
            label9 = new AntdUI.Label();
            label10 = new AntdUI.Label();
            label11 = new AntdUI.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // windowBarApp
            // 
            windowBarApp.BackColor = Color.FromArgb(94, 95, 97);
            windowBarApp.BadgeBack = SystemColors.ActiveBorder;
            windowBarApp.BadgeMode = true;
            windowBarApp.Dock = DockStyle.Top;
            windowBarApp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            windowBarApp.ForeColor = SystemColors.ButtonHighlight;
            windowBarApp.Icon = (Image)resources.GetObject("windowBarApp.Icon");
            windowBarApp.Location = new Point(0, 0);
            windowBarApp.Name = "windowBarApp";
            windowBarApp.Size = new Size(445, 39);
            windowBarApp.TabIndex = 1;
            windowBarApp.Text = "About";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 241);
            panel1.TabIndex = 3;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(0, 136);
            label12.Name = "label12";
            label12.Size = new Size(94, 34);
            label12.TabIndex = 4;
            label12.Text = "Website";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(0, 102);
            label4.Name = "label4";
            label4.Size = new Size(94, 34);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(0, 68);
            label3.Name = "label3";
            label3.Size = new Size(94, 34);
            label3.TabIndex = 2;
            label3.Text = "Github";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 34);
            label2.Name = "label2";
            label2.Size = new Size(94, 34);
            label2.TabIndex = 1;
            label2.Text = "Facebook";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 34);
            label1.TabIndex = 0;
            label1.Text = "Author";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbWebsite);
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(lbGithub);
            panel2.Controls.Add(lbFacebook);
            panel2.Controls.Add(labelName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(96, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 171);
            panel2.TabIndex = 4;
            // 
            // lbWebsite
            // 
            lbWebsite.Cursor = Cursors.Hand;
            lbWebsite.Dock = DockStyle.Top;
            lbWebsite.Font = new Font("Segoe UI", 12F);
            lbWebsite.Location = new Point(0, 136);
            lbWebsite.Name = "lbWebsite";
            lbWebsite.Size = new Size(347, 34);
            lbWebsite.TabIndex = 5;
            lbWebsite.Text = "www.hmoozoo.com";
            lbWebsite.MouseClick += lbWebsite_MouseClick;
            lbWebsite.MouseLeave += lbWebsite_MouseLeave;
            lbWebsite.MouseHover += lbWebsite_MouseHover;
            // 
            // lbEmail
            // 
            lbEmail.Cursor = Cursors.Hand;
            lbEmail.Dock = DockStyle.Top;
            lbEmail.Font = new Font("Segoe UI", 12F);
            lbEmail.Location = new Point(0, 102);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(347, 34);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "senms9x@gmail.com";
            lbEmail.Click += label8_Click;
            lbEmail.MouseLeave += label8_MouseLeave;
            lbEmail.MouseHover += label8_MouseHover;
            // 
            // lbGithub
            // 
            lbGithub.Cursor = Cursors.Hand;
            lbGithub.Dock = DockStyle.Top;
            lbGithub.Font = new Font("Segoe UI", 12F);
            lbGithub.Location = new Point(0, 68);
            lbGithub.Name = "lbGithub";
            lbGithub.Size = new Size(347, 34);
            lbGithub.TabIndex = 3;
            lbGithub.Text = "www.github.com/pyhteam";
            lbGithub.Click += label7_Click;
            lbGithub.MouseLeave += label7_MouseLeave;
            lbGithub.MouseHover += label7_MouseHover;
            // 
            // lbFacebook
            // 
            lbFacebook.BackColor = Color.Transparent;
            lbFacebook.Cursor = Cursors.Hand;
            lbFacebook.Dock = DockStyle.Top;
            lbFacebook.Font = new Font("Segoe UI", 12F);
            lbFacebook.Location = new Point(0, 34);
            lbFacebook.Name = "lbFacebook";
            lbFacebook.Size = new Size(347, 34);
            lbFacebook.TabIndex = 2;
            lbFacebook.Text = "www.facebook.com/senms9x";
            lbFacebook.Click += label6_Click;
            lbFacebook.MouseLeave += label6_MouseLeave;
            lbFacebook.MouseHover += label6_MouseHover;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(347, 34);
            labelName.TabIndex = 1;
            labelName.Text = "Ma Seo Sen";
            labelName.Click += label5_Click;
            labelName.MouseLeave += label5_MouseLeave;
            labelName.MouseHover += label5_MouseHover;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(102, 216);
            label9.Name = "label9";
            label9.Size = new Size(167, 23);
            label9.TabIndex = 5;
            label9.Text = "Pab txhawb zog (Donate)";
            // 
            // label10
            // 
            label10.Location = new Point(102, 234);
            label10.Name = "label10";
            label10.Size = new Size(182, 25);
            label10.TabIndex = 5;
            label10.Text = "Vietcombank: 0061001134560";
            // 
            // label11
            // 
            label11.Location = new Point(102, 253);
            label11.Name = "label11";
            label11.Size = new Size(182, 22);
            label11.TabIndex = 6;
            label11.Text = "Paypal: ihmong@outlook.com";
            // 
            // fmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 280);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(windowBarApp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fmAbout";
            Text = "About";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBarApp;
        private Panel panel1;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private Panel panel2;
        private AntdUI.Label label4;
        private AntdUI.Label lbEmail;
        private AntdUI.Label lbGithub;
        private AntdUI.Label lbFacebook;
        private AntdUI.Label labelName;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label label11;
        private AntdUI.Label label12;
        private AntdUI.Label lbWebsite;
    }
}