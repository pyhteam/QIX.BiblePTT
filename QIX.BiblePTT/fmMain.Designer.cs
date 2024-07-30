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
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            windowBarApp = new AntdUI.WindowBar();
            panelSilde = new Panel();
            menuBooks = new AntdUI.Menu();
            txtSearchBook = new AntdUI.Input();
            selectBible = new AntdUI.Select();
            panelContentSection = new Panel();
            richTextBoxContentSection = new RichTextBox();
            panelChooseSection = new Panel();
            flowLayoutPanelSection = new AntdUI.In.FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panelChooseVerb = new Panel();
            button6 = new Button();
            txtVerbTo = new AntdUI.InputNumber();
            labelToVerb = new AntdUI.Label();
            txtVerbFrom = new AntdUI.InputNumber();
            labelChooseVerb = new AntdUI.Label();
            panelBottom = new Panel();
            panelConfig = new Panel();
            panelSilde.SuspendLayout();
            panelContentSection.SuspendLayout();
            flowLayoutPanelSection.SuspendLayout();
            panelChooseVerb.SuspendLayout();
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
            windowBarApp.Size = new Size(833, 39);
            windowBarApp.TabIndex = 0;
            windowBarApp.Text = "Bible PPT";
            // 
            // panelSilde
            // 
            panelSilde.BackColor = Color.White;
            panelSilde.BorderStyle = BorderStyle.FixedSingle;
            panelSilde.Controls.Add(menuBooks);
            panelSilde.Controls.Add(txtSearchBook);
            panelSilde.Controls.Add(selectBible);
            panelSilde.Dock = DockStyle.Left;
            panelSilde.Location = new Point(0, 39);
            panelSilde.Name = "panelSilde";
            panelSilde.Size = new Size(196, 462);
            panelSilde.TabIndex = 1;
            // 
            // menuBooks
            // 
            menuBooks.BackActive = SystemColors.ActiveCaption;
            menuBooks.BackColor = Color.White;
            menuBooks.Dock = DockStyle.Fill;
            menuItem1.Select = false;
            menuItem1.Text = "Chiv keeb";
            menuItem2.Select = false;
            menuItem2.Text = "Khiav dim";
            menuItem3.Select = false;
            menuItem3.Text = "Levis Kevcai";
            menuBooks.Items.Add(menuItem1);
            menuBooks.Items.Add(menuItem2);
            menuBooks.Items.Add(menuItem3);
            menuBooks.Location = new Point(0, 71);
            menuBooks.Name = "menuBooks";
            menuBooks.Size = new Size(194, 389);
            menuBooks.TabIndex = 2;
            menuBooks.Text = "menuBook";
            // 
            // txtSearchBook
            // 
            txtSearchBook.Dock = DockStyle.Top;
            txtSearchBook.IconRatio = 0.5F;
            txtSearchBook.Location = new Point(0, 36);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(194, 35);
            txtSearchBook.TabIndex = 3;
            // 
            // selectBible
            // 
            selectBible.Dock = DockStyle.Top;
            selectBible.Items.AddRange(new object[] { "HMOWSV", "BD2011", "VIE1925" });
            selectBible.Location = new Point(0, 0);
            selectBible.Name = "selectBible";
            selectBible.Size = new Size(194, 36);
            selectBible.TabIndex = 2;
            selectBible.Text = "Choose Bible";
            // 
            // panelContentSection
            // 
            panelContentSection.BackColor = Color.White;
            panelContentSection.BorderStyle = BorderStyle.FixedSingle;
            panelContentSection.Controls.Add(richTextBoxContentSection);
            panelContentSection.Controls.Add(panelChooseSection);
            panelContentSection.Controls.Add(flowLayoutPanelSection);
            panelContentSection.Dock = DockStyle.Top;
            panelContentSection.Location = new Point(196, 39);
            panelContentSection.Name = "panelContentSection";
            panelContentSection.Size = new Size(637, 179);
            panelContentSection.TabIndex = 2;
            // 
            // richTextBoxContentSection
            // 
            richTextBoxContentSection.BorderStyle = BorderStyle.None;
            richTextBoxContentSection.Dock = DockStyle.Fill;
            richTextBoxContentSection.Location = new Point(212, 0);
            richTextBoxContentSection.Name = "richTextBoxContentSection";
            richTextBoxContentSection.Size = new Size(423, 177);
            richTextBoxContentSection.TabIndex = 3;
            richTextBoxContentSection.Text = resources.GetString("richTextBoxContentSection.Text");
            // 
            // panelChooseSection
            // 
            panelChooseSection.BackColor = Color.DimGray;
            panelChooseSection.Dock = DockStyle.Left;
            panelChooseSection.Location = new Point(209, 0);
            panelChooseSection.Name = "panelChooseSection";
            panelChooseSection.Size = new Size(3, 177);
            panelChooseSection.TabIndex = 1;
            // 
            // flowLayoutPanelSection
            // 
            flowLayoutPanelSection.Controls.Add(button1);
            flowLayoutPanelSection.Controls.Add(button2);
            flowLayoutPanelSection.Controls.Add(button3);
            flowLayoutPanelSection.Controls.Add(button4);
            flowLayoutPanelSection.Controls.Add(button5);
            flowLayoutPanelSection.Dock = DockStyle.Left;
            flowLayoutPanelSection.Location = new Point(0, 0);
            flowLayoutPanelSection.Name = "flowLayoutPanelSection";
            flowLayoutPanelSection.Size = new Size(209, 177);
            flowLayoutPanelSection.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(35, 33);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(44, 3);
            button2.Name = "button2";
            button2.Size = new Size(35, 33);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(85, 3);
            button3.Name = "button3";
            button3.Size = new Size(35, 33);
            button3.TabIndex = 0;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(126, 3);
            button4.Name = "button4";
            button4.Size = new Size(35, 33);
            button4.TabIndex = 0;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(167, 3);
            button5.Name = "button5";
            button5.Size = new Size(35, 33);
            button5.TabIndex = 0;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // panelChooseVerb
            // 
            panelChooseVerb.BackColor = Color.White;
            panelChooseVerb.BorderStyle = BorderStyle.FixedSingle;
            panelChooseVerb.Controls.Add(button6);
            panelChooseVerb.Controls.Add(txtVerbTo);
            panelChooseVerb.Controls.Add(labelToVerb);
            panelChooseVerb.Controls.Add(txtVerbFrom);
            panelChooseVerb.Controls.Add(labelChooseVerb);
            panelChooseVerb.Dock = DockStyle.Top;
            panelChooseVerb.Location = new Point(196, 218);
            panelChooseVerb.Name = "panelChooseVerb";
            panelChooseVerb.Size = new Size(637, 34);
            panelChooseVerb.TabIndex = 3;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Left;
            button6.Location = new Point(285, 0);
            button6.Name = "button6";
            button6.Size = new Size(81, 32);
            button6.TabIndex = 4;
            button6.Text = "Apply";
            button6.UseVisualStyleBackColor = true;
            // 
            // txtVerbTo
            // 
            txtVerbTo.Dock = DockStyle.Left;
            txtVerbTo.Location = new Point(200, 0);
            txtVerbTo.Name = "txtVerbTo";
            txtVerbTo.Size = new Size(85, 32);
            txtVerbTo.TabIndex = 3;
            txtVerbTo.Text = "0";
            txtVerbTo.TextAlign = HorizontalAlignment.Center;
            // 
            // labelToVerb
            // 
            labelToVerb.Dock = DockStyle.Left;
            labelToVerb.Location = new Point(180, 0);
            labelToVerb.Name = "labelToVerb";
            labelToVerb.Size = new Size(20, 32);
            labelToVerb.TabIndex = 2;
            labelToVerb.Text = "To";
            // 
            // txtVerbFrom
            // 
            txtVerbFrom.Dock = DockStyle.Left;
            txtVerbFrom.Location = new Point(93, 0);
            txtVerbFrom.Name = "txtVerbFrom";
            txtVerbFrom.Size = new Size(87, 32);
            txtVerbFrom.TabIndex = 1;
            txtVerbFrom.Text = "0";
            txtVerbFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // labelChooseVerb
            // 
            labelChooseVerb.Dock = DockStyle.Left;
            labelChooseVerb.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelChooseVerb.Location = new Point(0, 0);
            labelChooseVerb.Name = "labelChooseVerb";
            labelChooseVerb.Size = new Size(93, 32);
            labelChooseVerb.TabIndex = 0;
            labelChooseVerb.Text = "Choose Verb";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(196, 471);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(637, 30);
            panelBottom.TabIndex = 4;
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.White;
            panelConfig.BorderStyle = BorderStyle.FixedSingle;
            panelConfig.Dock = DockStyle.Fill;
            panelConfig.Location = new Point(196, 252);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(637, 219);
            panelConfig.TabIndex = 7;
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 205, 212);
            ClientSize = new Size(833, 501);
            Controls.Add(panelConfig);
            Controls.Add(panelBottom);
            Controls.Add(panelChooseVerb);
            Controls.Add(panelContentSection);
            Controls.Add(panelSilde);
            Controls.Add(windowBarApp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fmMain";
            Opacity = 0.97D;
            Text = "Bible To PPT";
            panelSilde.ResumeLayout(false);
            panelContentSection.ResumeLayout(false);
            flowLayoutPanelSection.ResumeLayout(false);
            panelChooseVerb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBarApp;
        private Panel panelSilde;
        private AntdUI.Select selectBible;
        private AntdUI.Menu menuBooks;
        private AntdUI.Input txtSearchBook;
        private Panel panelContentSection;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanelSection;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panelChooseSection;
        private RichTextBox richTextBoxContentSection;
        private Panel panelChooseVerb;
        private AntdUI.Label labelChooseVerb;
        private AntdUI.InputNumber txtVerbTo;
        private AntdUI.Label labelToVerb;
        private AntdUI.InputNumber txtVerbFrom;
        private Button button6;
        private Panel panelBottom;
        private Panel panelConfig;
    }
}
