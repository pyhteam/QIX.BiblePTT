namespace QIX.BiblePTT
{
    partial class fmMain
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
            windowBarApp = new AntdUI.WindowBar();
            openFileDialogBackgroud = new OpenFileDialog();
            panelMain = new Panel();
            menuStripMain = new MenuStrip();
            phooNtawvToolStripMenuItem = new ToolStripMenuItem();
            vajLusKubToolStripMenuItem = new ToolStripMenuItem();
            phooNkaujToolStripMenuItem = new ToolStripMenuItem();
            lusSibDhoToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            panelMain.SuspendLayout();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // windowBarApp
            // 
            windowBarApp.BackColor = Color.FromArgb(94, 95, 97);
            windowBarApp.BadgeBack = SystemColors.ActiveBorder;
            windowBarApp.BadgeMode = true;
            windowBarApp.Dock = DockStyle.Top;
            windowBarApp.Icon = Properties.Resources.open_book_icon_png;
            windowBarApp.Location = new Point(0, 0);
            windowBarApp.Name = "windowBarApp";
            windowBarApp.Size = new Size(896, 39);
            windowBarApp.TabIndex = 0;
            windowBarApp.Text = "Pawg Ntseeg Hmoob VN";
            // 
            // openFileDialogBackgroud
            // 
            openFileDialogBackgroud.FileName = "openFileDialog1";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(menuStripMain);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 39);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(896, 567);
            panelMain.TabIndex = 1;
            // 
            // menuStripMain
            // 
            menuStripMain.Dock = DockStyle.Bottom;
            menuStripMain.Items.AddRange(new ToolStripItem[] { phooNtawvToolStripMenuItem, aboutToolStripMenuItem, updateToolStripMenuItem });
            menuStripMain.Location = new Point(0, 543);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(896, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // phooNtawvToolStripMenuItem
            // 
            phooNtawvToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vajLusKubToolStripMenuItem, phooNkaujToolStripMenuItem, lusSibDhoToolStripMenuItem });
            phooNtawvToolStripMenuItem.Name = "phooNtawvToolStripMenuItem";
            phooNtawvToolStripMenuItem.Size = new Size(84, 20);
            phooNtawvToolStripMenuItem.Text = "Phoo Ntawv";
            // 
            // vajLusKubToolStripMenuItem
            // 
            vajLusKubToolStripMenuItem.Name = "vajLusKubToolStripMenuItem";
            vajLusKubToolStripMenuItem.Size = new Size(180, 22);
            vajLusKubToolStripMenuItem.Text = "Vaj Lus Kub";
            // 
            // phooNkaujToolStripMenuItem
            // 
            phooNkaujToolStripMenuItem.Name = "phooNkaujToolStripMenuItem";
            phooNkaujToolStripMenuItem.Size = new Size(180, 22);
            phooNkaujToolStripMenuItem.Text = "Phoo Nkauj";
            // 
            // lusSibDhoToolStripMenuItem
            // 
            lusSibDhoToolStripMenuItem.Name = "lusSibDhoToolStripMenuItem";
            lusSibDhoToolStripMenuItem.Size = new Size(180, 22);
            lusSibDhoToolStripMenuItem.Text = "Lus Sib Dho";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(57, 20);
            updateToolStripMenuItem.Text = "Update";
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 205, 212);
            ClientSize = new Size(896, 606);
            Controls.Add(panelMain);
            Controls.Add(windowBarApp);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripMain;
            Name = "fmMain";
            Opacity = 0.97D;
            Text = "Bible To PPT";
            Load += fmMain_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBarApp;
        private OpenFileDialog openFileDialogBackgroud;
        private Panel panelMain;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem phooNtawvToolStripMenuItem;
        private ToolStripMenuItem vajLusKubToolStripMenuItem;
        private ToolStripMenuItem phooNkaujToolStripMenuItem;
        private ToolStripMenuItem lusSibDhoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
    }
}
