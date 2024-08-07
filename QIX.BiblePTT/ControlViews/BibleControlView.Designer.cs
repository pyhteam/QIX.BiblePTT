﻿namespace QIX.BiblePTT.ControlViews
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
            panelSilde = new Panel();
            menuBooks = new AntdUI.Menu();
            txtSearchBook = new AntdUI.Input();
            selectBible = new AntdUI.Select();
            panelChooseVerb = new Panel();
            btnShowPTT = new Button();
            btnFilterVerb = new Button();
            txtVerbTo = new AntdUI.InputNumber();
            labelToVerb = new AntdUI.Label();
            txtVerbFrom = new AntdUI.InputNumber();
            labelChooseVerb = new AntdUI.Label();
            panelConfig = new Panel();
            panelConfigRight = new Panel();
            panelImage = new Panel();
            pictureBoxBackground = new PictureBox();
            panel1 = new Panel();
            labelFont = new AntdUI.Label();
            checkboxBold = new AntdUI.Checkbox();
            labelTextType = new AntdUI.Label();
            checkboxItalic = new AntdUI.Checkbox();
            labelBackground = new AntdUI.Label();
            txtFontSize = new AntdUI.InputNumber();
            labelTextAlign = new AntdUI.Label();
            checkboxUnderline = new AntdUI.Checkbox();
            labelColor = new AntdUI.Label();
            selectFont = new AntdUI.Select();
            colorPickerTextColor = new AntdUI.ColorPicker();
            linkLabelChooseImage = new LinkLabel();
            labelFontSize = new AntdUI.Label();
            selectTextAlign = new AntdUI.Select();
            btnSaveConfig = new Button();
            btnRemoveBackground = new Button();
            panelConfigLeft = new Panel();
            flowLayoutPanelSection = new AntdUI.In.FlowLayoutPanel();
            panelContent = new Panel();
            richTextBoxContentSection = new RichTextBox();
            panelSilde.SuspendLayout();
            panelChooseVerb.SuspendLayout();
            panelConfig.SuspendLayout();
            panelConfigRight.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            panel1.SuspendLayout();
            panelConfigLeft.SuspendLayout();
            panelContent.SuspendLayout();
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
            menuBooks.Location = new Point(0, 71);
            menuBooks.Name = "menuBooks";
            menuBooks.Size = new Size(194, 554);
            menuBooks.TabIndex = 2;
            menuBooks.Text = "menuBook";
            menuBooks.SelectChanged += menuBooks_SelectChanged;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Dock = DockStyle.Top;
            txtSearchBook.IconRatio = 0.5F;
            txtSearchBook.Location = new Point(0, 36);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(194, 35);
            txtSearchBook.TabIndex = 3;
            txtSearchBook.KeyPress += txtSearchBook_KeyPress;
            // 
            // selectBible
            // 
            selectBible.Dock = DockStyle.Top;
            selectBible.List = true;
            selectBible.ListAutoWidth = true;
            selectBible.Location = new Point(0, 0);
            selectBible.Multiline = true;
            selectBible.Name = "selectBible";
            selectBible.Size = new Size(194, 36);
            selectBible.TabIndex = 2;
            selectBible.Text = "Choose Vaj Lus Kub";
            selectBible.SelectedValueChanged += selectBible_SelectedValueChanged;
            selectBible.MouseHover += selectBible_MouseHover;
            // 
            // panelChooseVerb
            // 
            panelChooseVerb.BackColor = Color.White;
            panelChooseVerb.BorderStyle = BorderStyle.FixedSingle;
            panelChooseVerb.Controls.Add(btnShowPTT);
            panelChooseVerb.Controls.Add(btnFilterVerb);
            panelChooseVerb.Controls.Add(txtVerbTo);
            panelChooseVerb.Controls.Add(labelToVerb);
            panelChooseVerb.Controls.Add(txtVerbFrom);
            panelChooseVerb.Controls.Add(labelChooseVerb);
            panelChooseVerb.Dock = DockStyle.Top;
            panelChooseVerb.Location = new Point(196, 0);
            panelChooseVerb.Name = "panelChooseVerb";
            panelChooseVerb.Size = new Size(711, 34);
            panelChooseVerb.TabIndex = 4;
            // 
            // btnShowPTT
            // 
            btnShowPTT.Dock = DockStyle.Left;
            btnShowPTT.Location = new Point(373, 0);
            btnShowPTT.Name = "btnShowPTT";
            btnShowPTT.Size = new Size(130, 32);
            btnShowPTT.TabIndex = 5;
            btnShowPTT.Text = "Qhib PowerPoint";
            btnShowPTT.UseVisualStyleBackColor = true;
            btnShowPTT.Click += btnShowPTT_Click;
            // 
            // btnFilterVerb
            // 
            btnFilterVerb.Dock = DockStyle.Left;
            btnFilterVerb.Location = new Point(298, 0);
            btnFilterVerb.Name = "btnFilterVerb";
            btnFilterVerb.Size = new Size(75, 32);
            btnFilterVerb.TabIndex = 4;
            btnFilterVerb.Text = "Nrhiav";
            btnFilterVerb.UseVisualStyleBackColor = true;
            btnFilterVerb.Click += btnFilterVerb_Click;
            // 
            // txtVerbTo
            // 
            txtVerbTo.Dock = DockStyle.Left;
            txtVerbTo.Location = new Point(213, 0);
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
            labelToVerb.Size = new Size(33, 32);
            labelToVerb.TabIndex = 2;
            labelToVerb.Text = "Txog";
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
            labelChooseVerb.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelChooseVerb.Location = new Point(0, 0);
            labelChooseVerb.Name = "labelChooseVerb";
            labelChooseVerb.Size = new Size(93, 32);
            labelChooseVerb.TabIndex = 0;
            labelChooseVerb.Text = "Nrhiav Nqi";
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.White;
            panelConfig.BorderStyle = BorderStyle.FixedSingle;
            panelConfig.Controls.Add(panelConfigRight);
            panelConfig.Controls.Add(panelConfigLeft);
            panelConfig.Dock = DockStyle.Top;
            panelConfig.Location = new Point(196, 34);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(711, 273);
            panelConfig.TabIndex = 8;
            // 
            // panelConfigRight
            // 
            panelConfigRight.BorderStyle = BorderStyle.FixedSingle;
            panelConfigRight.Controls.Add(panelImage);
            panelConfigRight.Controls.Add(panel1);
            panelConfigRight.Dock = DockStyle.Fill;
            panelConfigRight.Location = new Point(319, 0);
            panelConfigRight.Name = "panelConfigRight";
            panelConfigRight.Size = new Size(390, 271);
            panelConfigRight.TabIndex = 2;
            // 
            // panelImage
            // 
            panelImage.Controls.Add(pictureBoxBackground);
            panelImage.Dock = DockStyle.Fill;
            panelImage.Location = new Point(291, 0);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(97, 269);
            panelImage.TabIndex = 18;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Dock = DockStyle.Fill;
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(97, 269);
            pictureBoxBackground.TabIndex = 0;
            pictureBoxBackground.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelFont);
            panel1.Controls.Add(checkboxBold);
            panel1.Controls.Add(labelTextType);
            panel1.Controls.Add(checkboxItalic);
            panel1.Controls.Add(labelBackground);
            panel1.Controls.Add(txtFontSize);
            panel1.Controls.Add(labelTextAlign);
            panel1.Controls.Add(checkboxUnderline);
            panel1.Controls.Add(labelColor);
            panel1.Controls.Add(selectFont);
            panel1.Controls.Add(colorPickerTextColor);
            panel1.Controls.Add(linkLabelChooseImage);
            panel1.Controls.Add(labelFontSize);
            panel1.Controls.Add(selectTextAlign);
            panel1.Controls.Add(btnSaveConfig);
            panel1.Controls.Add(btnRemoveBackground);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 269);
            panel1.TabIndex = 17;
            // 
            // labelFont
            // 
            labelFont.Location = new Point(15, 16);
            labelFont.Name = "labelFont";
            labelFont.Size = new Size(70, 28);
            labelFont.TabIndex = 9;
            labelFont.Text = "Font";
            // 
            // checkboxBold
            // 
            checkboxBold.AutoCheck = true;
            checkboxBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkboxBold.Location = new Point(175, 174);
            checkboxBold.Name = "checkboxBold";
            checkboxBold.Size = new Size(42, 22);
            checkboxBold.TabIndex = 16;
            checkboxBold.Text = "U";
            checkboxBold.CheckedChanged += checkboxBold_CheckedChanged;
            // 
            // labelTextType
            // 
            labelTextType.Location = new Point(15, 173);
            labelTextType.Name = "labelTextType";
            labelTextType.Size = new Size(70, 23);
            labelTextType.TabIndex = 5;
            labelTextType.Text = "Text Type";
            // 
            // checkboxItalic
            // 
            checkboxItalic.AutoCheck = true;
            checkboxItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            checkboxItalic.Location = new Point(133, 174);
            checkboxItalic.Name = "checkboxItalic";
            checkboxItalic.Size = new Size(36, 22);
            checkboxItalic.TabIndex = 16;
            checkboxItalic.Text = "I";
            checkboxItalic.CheckedChanged += checkboxItalic_CheckedChanged;
            // 
            // labelBackground
            // 
            labelBackground.Location = new Point(15, 210);
            labelBackground.Name = "labelBackground";
            labelBackground.Size = new Size(70, 23);
            labelBackground.TabIndex = 5;
            labelBackground.Text = "Background";
            // 
            // txtFontSize
            // 
            txtFontSize.Location = new Point(91, 47);
            txtFontSize.Name = "txtFontSize";
            txtFontSize.Size = new Size(197, 34);
            txtFontSize.TabIndex = 10;
            txtFontSize.Text = "12";
            txtFontSize.Value = new decimal(new int[] { 12, 0, 0, 0 });
            txtFontSize.ValueChanged += txtFontSize_ValueChanged;
            // 
            // labelTextAlign
            // 
            labelTextAlign.Location = new Point(15, 124);
            labelTextAlign.Name = "labelTextAlign";
            labelTextAlign.Size = new Size(70, 34);
            labelTextAlign.TabIndex = 6;
            labelTextAlign.Text = "Text Align";
            // 
            // checkboxUnderline
            // 
            checkboxUnderline.AutoCheck = true;
            checkboxUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            checkboxUnderline.Location = new Point(91, 174);
            checkboxUnderline.Name = "checkboxUnderline";
            checkboxUnderline.Size = new Size(44, 22);
            checkboxUnderline.TabIndex = 16;
            checkboxUnderline.Text = "U";
            checkboxUnderline.CheckedChanged += checkboxUnderline_CheckedChanged;
            // 
            // labelColor
            // 
            labelColor.Location = new Point(15, 87);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(70, 23);
            labelColor.TabIndex = 7;
            labelColor.Text = "Color";
            // 
            // selectFont
            // 
            selectFont.Location = new Point(91, 10);
            selectFont.Name = "selectFont";
            selectFont.Size = new Size(197, 34);
            selectFont.TabIndex = 4;
            selectFont.SelectedValueChanged += selectFont_SelectedValueChanged;
            // 
            // colorPickerTextColor
            // 
            colorPickerTextColor.Location = new Point(91, 87);
            colorPickerTextColor.Name = "colorPickerTextColor";
            colorPickerTextColor.Size = new Size(197, 31);
            colorPickerTextColor.TabIndex = 11;
            colorPickerTextColor.Text = "colorPicker1";
            colorPickerTextColor.Value = Color.FromArgb(22, 119, 255);
            colorPickerTextColor.ValueChanged += colorPickerTextColor_ValueChanged;
            // 
            // linkLabelChooseImage
            // 
            linkLabelChooseImage.AutoSize = true;
            linkLabelChooseImage.Location = new Point(91, 210);
            linkLabelChooseImage.Name = "linkLabelChooseImage";
            linkLabelChooseImage.Size = new Size(83, 15);
            linkLabelChooseImage.TabIndex = 15;
            linkLabelChooseImage.TabStop = true;
            linkLabelChooseImage.Text = "Choose Image";
            linkLabelChooseImage.LinkClicked += linkLabelChooseImage_LinkClicked;
            // 
            // labelFontSize
            // 
            labelFontSize.Location = new Point(15, 47);
            labelFontSize.Name = "labelFontSize";
            labelFontSize.Size = new Size(70, 34);
            labelFontSize.TabIndex = 8;
            labelFontSize.Text = "Font Size";
            // 
            // selectTextAlign
            // 
            selectTextAlign.Items.AddRange(new object[] { "Left", "Center", "Right" });
            selectTextAlign.Location = new Point(91, 124);
            selectTextAlign.Name = "selectTextAlign";
            selectTextAlign.Size = new Size(197, 34);
            selectTextAlign.TabIndex = 4;
            selectTextAlign.SelectedIndexChanged += selectTextAlign_SelectedIndexChanged;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Location = new Point(91, 233);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(90, 26);
            btnSaveConfig.TabIndex = 14;
            btnSaveConfig.Text = "Save Config";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // btnRemoveBackground
            // 
            btnRemoveBackground.Location = new Point(187, 233);
            btnRemoveBackground.Name = "btnRemoveBackground";
            btnRemoveBackground.Size = new Size(65, 26);
            btnRemoveBackground.TabIndex = 14;
            btnRemoveBackground.Text = "Clear";
            btnRemoveBackground.UseVisualStyleBackColor = true;
            btnRemoveBackground.Click += btnRemoveBackground_Click;
            // 
            // panelConfigLeft
            // 
            panelConfigLeft.Controls.Add(flowLayoutPanelSection);
            panelConfigLeft.Dock = DockStyle.Left;
            panelConfigLeft.Location = new Point(0, 0);
            panelConfigLeft.Name = "panelConfigLeft";
            panelConfigLeft.Size = new Size(319, 271);
            panelConfigLeft.TabIndex = 1;
            // 
            // flowLayoutPanelSection
            // 
            flowLayoutPanelSection.AllowDrop = true;
            flowLayoutPanelSection.AutoScroll = true;
            flowLayoutPanelSection.Dock = DockStyle.Fill;
            flowLayoutPanelSection.Location = new Point(0, 0);
            flowLayoutPanelSection.Name = "flowLayoutPanelSection";
            flowLayoutPanelSection.Size = new Size(319, 271);
            flowLayoutPanelSection.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(richTextBoxContentSection);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(196, 307);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(711, 320);
            panelContent.TabIndex = 9;
            // 
            // richTextBoxContentSection
            // 
            richTextBoxContentSection.AutoWordSelection = true;
            richTextBoxContentSection.BorderStyle = BorderStyle.None;
            richTextBoxContentSection.Dock = DockStyle.Fill;
            richTextBoxContentSection.Location = new Point(0, 0);
            richTextBoxContentSection.Name = "richTextBoxContentSection";
            richTextBoxContentSection.Size = new Size(711, 320);
            richTextBoxContentSection.TabIndex = 4;
            richTextBoxContentSection.Text = "";
            // 
            // BibleControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelConfig);
            Controls.Add(panelChooseVerb);
            Controls.Add(panelSilde);
            Name = "BibleControlView";
            Size = new Size(907, 627);
            Load += BibleControlView_Load;
            panelSilde.ResumeLayout(false);
            panelChooseVerb.ResumeLayout(false);
            panelConfig.ResumeLayout(false);
            panelConfigRight.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelConfigLeft.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSilde;
        private AntdUI.Menu menuBooks;
        private AntdUI.Input txtSearchBook;
        private AntdUI.Select selectBible;
        private Panel panelChooseVerb;
        private Button btnFilterVerb;
        private AntdUI.InputNumber txtVerbTo;
        private AntdUI.Label labelToVerb;
        private AntdUI.InputNumber txtVerbFrom;
        private AntdUI.Label labelChooseVerb;
        private Panel panelConfig;
        private Panel panelConfigRight;
        private PictureBox pictureBoxBackground;
        private Panel panelConfigLeft;
        private LinkLabel linkLabelChooseImage;
        private Button btnSaveConfig;
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
        private Button btnShowPTT;
        private AntdUI.Checkbox checkboxBold;
        private AntdUI.Checkbox checkboxItalic;
        private AntdUI.Checkbox checkboxUnderline;
        private Button btnRemoveBackground;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanelSection;
        private Panel panelContent;
        private RichTextBox richTextBoxContentSection;
        private Panel panel1;
        private Panel panelImage;
    }
}
