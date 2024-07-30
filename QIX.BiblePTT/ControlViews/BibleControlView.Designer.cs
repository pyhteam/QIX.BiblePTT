namespace QIX.BiblePTT.ControlViews
{
    partial class BibleControlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibleControlView));
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
            panelConfigRight = new Panel();
            pictureBoxBackground = new PictureBox();
            panelConfigLeft = new Panel();
            linkLabelChooseImage = new LinkLabel();
            btnSaveConfig = new Button();
            radioBold = new AntdUI.Radio();
            radioItalic = new AntdUI.Radio();
            radioUnderLine = new AntdUI.Radio();
            colorPickerTextColor = new AntdUI.ColorPicker();
            txtFontSize = new AntdUI.InputNumber();
            labelBackground = new AntdUI.Label();
            labelTextType = new AntdUI.Label();
            labelTextAlign = new AntdUI.Label();
            labelColor = new AntdUI.Label();
            labelFontSize = new AntdUI.Label();
            labelFont = new AntdUI.Label();
            selectTextAlign = new AntdUI.Select();
            selectFont = new AntdUI.Select();
            panelSilde.SuspendLayout();
            panelContentSection.SuspendLayout();
            flowLayoutPanelSection.SuspendLayout();
            panelChooseVerb.SuspendLayout();
            panelConfig.SuspendLayout();
            panelConfigRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            panelConfigLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelSilde
            // 
            panelSilde.BackColor = Color.White;
            panelSilde.BorderStyle = BorderStyle.FixedSingle;
            panelSilde.Controls.Add(menuBooks);
            panelSilde.Controls.Add(txtSearchBook);
            panelSilde.Controls.Add(selectBible);
            panelSilde.Dock = DockStyle.Left;
            panelSilde.Location = new Point(0, 0);
            panelSilde.Name = "panelSilde";
            panelSilde.Size = new Size(196, 627);
            panelSilde.TabIndex = 2;
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
            menuBooks.Size = new Size(194, 554);
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
            panelContentSection.Location = new Point(196, 0);
            panelContentSection.Name = "panelContentSection";
            panelContentSection.Size = new Size(711, 179);
            panelContentSection.TabIndex = 3;
            // 
            // richTextBoxContentSection
            // 
            richTextBoxContentSection.BorderStyle = BorderStyle.None;
            richTextBoxContentSection.Dock = DockStyle.Fill;
            richTextBoxContentSection.Location = new Point(212, 0);
            richTextBoxContentSection.Name = "richTextBoxContentSection";
            richTextBoxContentSection.Size = new Size(497, 177);
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
            panelChooseVerb.Location = new Point(196, 179);
            panelChooseVerb.Name = "panelChooseVerb";
            panelChooseVerb.Size = new Size(711, 34);
            panelChooseVerb.TabIndex = 4;
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
            panelBottom.Location = new Point(196, 589);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(711, 38);
            panelBottom.TabIndex = 5;
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.White;
            panelConfig.BorderStyle = BorderStyle.FixedSingle;
            panelConfig.Controls.Add(panelConfigRight);
            panelConfig.Controls.Add(panelConfigLeft);
            panelConfig.Dock = DockStyle.Fill;
            panelConfig.Location = new Point(196, 213);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(711, 376);
            panelConfig.TabIndex = 8;
            // 
            // panelConfigRight
            // 
            panelConfigRight.BorderStyle = BorderStyle.FixedSingle;
            panelConfigRight.Controls.Add(pictureBoxBackground);
            panelConfigRight.Dock = DockStyle.Fill;
            panelConfigRight.Location = new Point(319, 0);
            panelConfigRight.Name = "panelConfigRight";
            panelConfigRight.Size = new Size(390, 374);
            panelConfigRight.TabIndex = 2;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Dock = DockStyle.Fill;
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(388, 372);
            pictureBoxBackground.TabIndex = 0;
            pictureBoxBackground.TabStop = false;
            // 
            // panelConfigLeft
            // 
            panelConfigLeft.Controls.Add(linkLabelChooseImage);
            panelConfigLeft.Controls.Add(btnSaveConfig);
            panelConfigLeft.Controls.Add(radioBold);
            panelConfigLeft.Controls.Add(radioItalic);
            panelConfigLeft.Controls.Add(radioUnderLine);
            panelConfigLeft.Controls.Add(colorPickerTextColor);
            panelConfigLeft.Controls.Add(txtFontSize);
            panelConfigLeft.Controls.Add(labelBackground);
            panelConfigLeft.Controls.Add(labelTextType);
            panelConfigLeft.Controls.Add(labelTextAlign);
            panelConfigLeft.Controls.Add(labelColor);
            panelConfigLeft.Controls.Add(labelFontSize);
            panelConfigLeft.Controls.Add(labelFont);
            panelConfigLeft.Controls.Add(selectTextAlign);
            panelConfigLeft.Controls.Add(selectFont);
            panelConfigLeft.Dock = DockStyle.Left;
            panelConfigLeft.Location = new Point(0, 0);
            panelConfigLeft.Name = "panelConfigLeft";
            panelConfigLeft.Size = new Size(319, 374);
            panelConfigLeft.TabIndex = 1;
            // 
            // linkLabelChooseImage
            // 
            linkLabelChooseImage.AutoSize = true;
            linkLabelChooseImage.Location = new Point(123, 203);
            linkLabelChooseImage.Name = "linkLabelChooseImage";
            linkLabelChooseImage.Size = new Size(83, 15);
            linkLabelChooseImage.TabIndex = 15;
            linkLabelChooseImage.TabStop = true;
            linkLabelChooseImage.Text = "Choose Image";
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Location = new Point(123, 226);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(71, 27);
            btnSaveConfig.TabIndex = 14;
            btnSaveConfig.Text = "Save";
            btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // radioBold
            // 
            radioBold.AutoCheck = true;
            radioBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioBold.Location = new Point(219, 166);
            radioBold.Name = "radioBold";
            radioBold.Size = new Size(42, 23);
            radioBold.TabIndex = 13;
            radioBold.Text = "B";
            // 
            // radioItalic
            // 
            radioItalic.AutoCheck = true;
            radioItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            radioItalic.Location = new Point(171, 166);
            radioItalic.Name = "radioItalic";
            radioItalic.Size = new Size(42, 23);
            radioItalic.TabIndex = 13;
            radioItalic.Text = "I";
            // 
            // radioUnderLine
            // 
            radioUnderLine.AutoCheck = true;
            radioUnderLine.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Underline, GraphicsUnit.Point);
            radioUnderLine.Location = new Point(123, 166);
            radioUnderLine.Name = "radioUnderLine";
            radioUnderLine.Size = new Size(42, 23);
            radioUnderLine.TabIndex = 13;
            radioUnderLine.Text = "U";
            // 
            // colorPickerTextColor
            // 
            colorPickerTextColor.Location = new Point(123, 80);
            colorPickerTextColor.Name = "colorPickerTextColor";
            colorPickerTextColor.Size = new Size(75, 31);
            colorPickerTextColor.TabIndex = 11;
            colorPickerTextColor.Text = "colorPicker1";
            colorPickerTextColor.Value = Color.FromArgb(22, 119, 255);
            // 
            // txtFontSize
            // 
            txtFontSize.Location = new Point(120, 40);
            txtFontSize.Name = "txtFontSize";
            txtFontSize.Size = new Size(78, 34);
            txtFontSize.TabIndex = 10;
            txtFontSize.Text = "0";
            // 
            // labelBackground
            // 
            labelBackground.Location = new Point(3, 203);
            labelBackground.Name = "labelBackground";
            labelBackground.Size = new Size(111, 23);
            labelBackground.TabIndex = 5;
            labelBackground.Text = "Background";
            // 
            // labelTextType
            // 
            labelTextType.Location = new Point(3, 166);
            labelTextType.Name = "labelTextType";
            labelTextType.Size = new Size(111, 23);
            labelTextType.TabIndex = 5;
            labelTextType.Text = "Text Type";
            // 
            // labelTextAlign
            // 
            labelTextAlign.Location = new Point(3, 117);
            labelTextAlign.Name = "labelTextAlign";
            labelTextAlign.Size = new Size(111, 34);
            labelTextAlign.TabIndex = 6;
            labelTextAlign.Text = "Text Align";
            // 
            // labelColor
            // 
            labelColor.Location = new Point(3, 80);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(111, 23);
            labelColor.TabIndex = 7;
            labelColor.Text = "Color";
            // 
            // labelFontSize
            // 
            labelFontSize.Location = new Point(3, 40);
            labelFontSize.Name = "labelFontSize";
            labelFontSize.Size = new Size(111, 34);
            labelFontSize.TabIndex = 8;
            labelFontSize.Text = "Font Size";
            // 
            // labelFont
            // 
            labelFont.Location = new Point(3, 9);
            labelFont.Name = "labelFont";
            labelFont.Size = new Size(111, 28);
            labelFont.TabIndex = 9;
            labelFont.Text = "Font";
            // 
            // selectTextAlign
            // 
            selectTextAlign.Items.AddRange(new object[] { "Left", "Center", "Right" });
            selectTextAlign.Location = new Point(120, 117);
            selectTextAlign.Name = "selectTextAlign";
            selectTextAlign.Size = new Size(193, 34);
            selectTextAlign.TabIndex = 4;
            // 
            // selectFont
            // 
            selectFont.Location = new Point(120, 3);
            selectFont.Name = "selectFont";
            selectFont.Size = new Size(193, 34);
            selectFont.TabIndex = 4;
            // 
            // BibleControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelConfig);
            Controls.Add(panelBottom);
            Controls.Add(panelChooseVerb);
            Controls.Add(panelContentSection);
            Controls.Add(panelSilde);
            Name = "BibleControlView";
            Size = new Size(907, 627);
            panelSilde.ResumeLayout(false);
            panelContentSection.ResumeLayout(false);
            flowLayoutPanelSection.ResumeLayout(false);
            panelChooseVerb.ResumeLayout(false);
            panelConfig.ResumeLayout(false);
            panelConfigRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            panelConfigLeft.ResumeLayout(false);
            panelConfigLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSilde;
        private AntdUI.Menu menuBooks;
        private AntdUI.Input txtSearchBook;
        private AntdUI.Select selectBible;
        private Panel panelContentSection;
        private RichTextBox richTextBoxContentSection;
        private Panel panelChooseSection;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanelSection;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panelChooseVerb;
        private Button button6;
        private AntdUI.InputNumber txtVerbTo;
        private AntdUI.Label labelToVerb;
        private AntdUI.InputNumber txtVerbFrom;
        private AntdUI.Label labelChooseVerb;
        private Panel panelBottom;
        private Panel panelConfig;
        private Panel panelConfigRight;
        private PictureBox pictureBoxBackground;
        private Panel panelConfigLeft;
        private LinkLabel linkLabelChooseImage;
        private Button btnSaveConfig;
        private AntdUI.Radio radioBold;
        private AntdUI.Radio radioItalic;
        private AntdUI.Radio radioUnderLine;
        private AntdUI.ColorPicker colorPickerTextColor;
        private AntdUI.InputNumber txtFontSize;
        private AntdUI.Label labelBackground;
        private AntdUI.Label labelTextType;
        private AntdUI.Label labelTextAlign;
        private AntdUI.Label labelColor;
        private AntdUI.Label labelFontSize;
        private AntdUI.Label labelFont;
        private AntdUI.Select selectTextAlign;
        private AntdUI.Select selectFont;
    }
}
