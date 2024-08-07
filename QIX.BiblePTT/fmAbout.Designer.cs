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
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            panel2 = new Panel();
            label8 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label5 = new AntdUI.Label();
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
            windowBarApp.Size = new Size(583, 39);
            windowBarApp.TabIndex = 1;
            windowBarApp.Text = "About";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 257);
            panel1.TabIndex = 3;
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
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(96, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 257);
            panel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(0, 102);
            label8.Name = "label8";
            label8.Size = new Size(485, 34);
            label8.TabIndex = 4;
            label8.Text = "senms9x@gmail.com";
            label8.MouseLeave += label8_MouseLeave;
            label8.MouseHover += label8_MouseHover;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(0, 68);
            label7.Name = "label7";
            label7.Size = new Size(485, 34);
            label7.TabIndex = 3;
            label7.Text = "https://github.com/pyhteam";
            label7.MouseLeave += label7_MouseLeave;
            label7.MouseHover += label7_MouseHover;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(0, 34);
            label6.Name = "label6";
            label6.Size = new Size(485, 34);
            label6.TabIndex = 2;
            label6.Text = "www.facebook.com/senms9x";
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseHover += label6_MouseHover;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(485, 34);
            label5.TabIndex = 1;
            label5.Text = "Ma Seo Sen";
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseHover += label5_MouseHover;
            // 
            // fmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 296);
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
        private AntdUI.Label label8;
        private AntdUI.Label label7;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
    }
}