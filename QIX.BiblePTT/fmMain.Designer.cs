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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            windowBarApp = new AntdUI.WindowBar();
            menuStripMain = new MenuStrip();
            phooNtawToolStripMenuItem = new ToolStripMenuItem();
            lusSibDhoToolStripMenuItem = new ToolStripMenuItem();
            phooNkaujToolStripMenuItem = new ToolStripMenuItem();
            vajLusKubToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            docToolStripMenuItemTutorial = new ToolStripMenuItem();
            updateToolStripMenuItemCheckUpdate = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStripMain.SuspendLayout();
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
            windowBarApp.Size = new Size(1000, 39);
            windowBarApp.TabIndex = 0;
            windowBarApp.Text = "Pawg Ntseeg Hmoob VN";
            // 
            // menuStripMain
            // 
            menuStripMain.Dock = DockStyle.Bottom;
            menuStripMain.Items.AddRange(new ToolStripItem[] { phooNtawToolStripMenuItem, aboutToolStripMenuItem, updateToolStripMenuItem });
            menuStripMain.Location = new Point(0, 674);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1000, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStrip1";
            // 
            // phooNtawToolStripMenuItem
            // 
            phooNtawToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lusSibDhoToolStripMenuItem, phooNkaujToolStripMenuItem, vajLusKubToolStripMenuItem });
            phooNtawToolStripMenuItem.Name = "phooNtawToolStripMenuItem";
            phooNtawToolStripMenuItem.Size = new Size(78, 20);
            phooNtawToolStripMenuItem.Text = "Phoo Ntaw";
            // 
            // lusSibDhoToolStripMenuItem
            // 
            lusSibDhoToolStripMenuItem.Name = "lusSibDhoToolStripMenuItem";
            lusSibDhoToolStripMenuItem.Size = new Size(136, 22);
            lusSibDhoToolStripMenuItem.Text = "Lus Sib Dho";
            lusSibDhoToolStripMenuItem.Click += lusSibDhoToolStripMenuItem_Click;
            // 
            // phooNkaujToolStripMenuItem
            // 
            phooNkaujToolStripMenuItem.Name = "phooNkaujToolStripMenuItem";
            phooNkaujToolStripMenuItem.Size = new Size(136, 22);
            phooNkaujToolStripMenuItem.Text = "Phoo Nkauj";
            phooNkaujToolStripMenuItem.Click += phooNkaujToolStripMenuItem_Click;
            // 
            // vajLusKubToolStripMenuItem
            // 
            vajLusKubToolStripMenuItem.Name = "vajLusKubToolStripMenuItem";
            vajLusKubToolStripMenuItem.Size = new Size(136, 22);
            vajLusKubToolStripMenuItem.Text = "Vaj Lus Kub";
            vajLusKubToolStripMenuItem.Click += vajLusKubToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { docToolStripMenuItemTutorial, updateToolStripMenuItemCheckUpdate });
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(44, 20);
            updateToolStripMenuItem.Text = "Help";
            // 
            // docToolStripMenuItemTutorial
            // 
            docToolStripMenuItemTutorial.Name = "docToolStripMenuItemTutorial";
            docToolStripMenuItemTutorial.Size = new Size(180, 22);
            docToolStripMenuItemTutorial.Text = "Qhia siv";
            docToolStripMenuItemTutorial.Click += docToolStripMenuItemTutorial_Click;
            // 
            // updateToolStripMenuItemCheckUpdate
            // 
            updateToolStripMenuItemCheckUpdate.Name = "updateToolStripMenuItemCheckUpdate";
            updateToolStripMenuItemCheckUpdate.Size = new Size(180, 22);
            updateToolStripMenuItemCheckUpdate.Text = "Update";
            updateToolStripMenuItemCheckUpdate.Click += updateToolStripMenuItemCheckUpdate_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 39);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1000, 635);
            panelMain.TabIndex = 2;
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 205, 212);
            ClientSize = new Size(1000, 698);
            Controls.Add(panelMain);
            Controls.Add(windowBarApp);
            Controls.Add(menuStripMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmMain";
            Opacity = 0.97D;
            Text = "Bible To PPT";
            Load += fmMain_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.WindowBar windowBarApp;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem phooNtawToolStripMenuItem;
        private ToolStripMenuItem lusSibDhoToolStripMenuItem;
        private ToolStripMenuItem phooNkaujToolStripMenuItem;
        private ToolStripMenuItem vajLusKubToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItemCheckUpdate;
        private ToolStripMenuItem docToolStripMenuItemTutorial;
        private Panel panelMain;
    }
}
