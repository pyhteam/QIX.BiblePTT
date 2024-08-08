namespace QIX.BiblePTT.ControlViews
{
    partial class HymnsControlView
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
            panelContent = new Panel();
            richTextBoxContentSection = new RichTextBox();
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
            panelChooseVerb = new Panel();
            btnShowPTT = new Button();
            btnFilterVerb = new Button();
            txtVerbTo = new AntdUI.InputNumber();
            labelToVerb = new AntdUI.Label();
            txtVerbFrom = new AntdUI.InputNumber();
            labelChooseVerb = new AntdUI.Label();
            panelSilde = new Panel();
            menuHymns = new AntdUI.Menu();
            txtSearchHymn = new AntdUI.Input();
            selectHymn = new AntdUI.Select();
            panelContent.SuspendLayout();
            panelConfig.SuspendLayout();
            panelConfigRight.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            panel1.SuspendLayout();
            panelChooseVerb.SuspendLayout();
            panelSilde.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(richTextBoxContentSection);
            panelContent.Controls.Add(panelConfig);
            panelContent.Controls.Add(panelChooseVerb);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(196, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(583, 491);
            panelContent.TabIndex = 13;
            // 
            // richTextBoxContentSection
            // 
            richTextBoxContentSection.AutoWordSelection = true;
            richTextBoxContentSection.BorderStyle = BorderStyle.None;
            richTextBoxContentSection.Dock = DockStyle.Fill;
            richTextBoxContentSection.Location = new Point(0, 302);
            richTextBoxContentSection.Name = "richTextBoxContentSection";
            richTextBoxContentSection.Size = new Size(583, 189);
            richTextBoxContentSection.TabIndex = 10;
            richTextBoxContentSection.Text = "";
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.White;
            panelConfig.BorderStyle = BorderStyle.FixedSingle;
            panelConfig.Controls.Add(panelConfigRight);
            panelConfig.Dock = DockStyle.Top;
            panelConfig.Location = new Point(0, 34);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(583, 268);
            panelConfig.TabIndex = 9;
            // 
            // panelConfigRight
            // 
            panelConfigRight.BorderStyle = BorderStyle.FixedSingle;
            panelConfigRight.Controls.Add(panelImage);
            panelConfigRight.Controls.Add(panel1);
            panelConfigRight.Dock = DockStyle.Fill;
            panelConfigRight.Location = new Point(0, 0);
            panelConfigRight.Name = "panelConfigRight";
            panelConfigRight.Size = new Size(581, 266);
            panelConfigRight.TabIndex = 2;
            // 
            // panelImage
            // 
            panelImage.Controls.Add(pictureBoxBackground);
            panelImage.Dock = DockStyle.Fill;
            panelImage.Location = new Point(297, 0);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(282, 264);
            panelImage.TabIndex = 18;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(282, 264);
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
            panel1.Size = new Size(297, 264);
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
            labelColor.Text = "Text Color";
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
            colorPickerTextColor.Value = Color.Black;
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
            linkLabelChooseImage.Click += linkLabelChooseImage_Click;
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
            selectTextAlign.SelectedValueChanged += selectTextAlign_SelectedValueChanged;
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
            btnRemoveBackground.Text = "Reset";
            btnRemoveBackground.UseVisualStyleBackColor = true;
            btnRemoveBackground.Click += btnRemoveBackground_Click;
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
            panelChooseVerb.Location = new Point(0, 0);
            panelChooseVerb.Name = "panelChooseVerb";
            panelChooseVerb.Size = new Size(583, 34);
            panelChooseVerb.TabIndex = 5;
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
            // panelSilde
            // 
            panelSilde.BackColor = Color.White;
            panelSilde.BorderStyle = BorderStyle.FixedSingle;
            panelSilde.Controls.Add(menuHymns);
            panelSilde.Controls.Add(txtSearchHymn);
            panelSilde.Controls.Add(selectHymn);
            panelSilde.Dock = DockStyle.Left;
            panelSilde.Location = new Point(0, 0);
            panelSilde.Name = "panelSilde";
            panelSilde.Size = new Size(196, 491);
            panelSilde.TabIndex = 10;
            // 
            // menuHymns
            // 
            menuHymns.BackActive = SystemColors.ActiveCaption;
            menuHymns.BackColor = Color.White;
            menuHymns.Dock = DockStyle.Fill;
            menuHymns.Location = new Point(0, 71);
            menuHymns.Name = "menuHymns";
            menuHymns.Size = new Size(194, 418);
            menuHymns.TabIndex = 2;
            menuHymns.Text = "menuBook";
            menuHymns.SelectChanged += menuHymns_SelectChanged;
            // 
            // txtSearchHymn
            // 
            txtSearchHymn.Dock = DockStyle.Top;
            txtSearchHymn.IconRatio = 0.5F;
            txtSearchHymn.Location = new Point(0, 36);
            txtSearchHymn.Name = "txtSearchHymn";
            txtSearchHymn.Size = new Size(194, 35);
            txtSearchHymn.TabIndex = 3;
            txtSearchHymn.KeyPress += txtSearchHymn_KeyPress;
            // 
            // selectHymn
            // 
            selectHymn.Dock = DockStyle.Top;
            selectHymn.List = true;
            selectHymn.ListAutoWidth = true;
            selectHymn.Location = new Point(0, 0);
            selectHymn.Multiline = true;
            selectHymn.Name = "selectHymn";
            selectHymn.Size = new Size(194, 36);
            selectHymn.TabIndex = 2;
            selectHymn.Text = "Choose Phoo Nkauj";
            selectHymn.SelectedValueChanged += selectHymn_SelectedValueChanged;
            // 
            // HymnsControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelSilde);
            Name = "HymnsControlView";
            Size = new Size(779, 491);
            Load += HymnsControlView_Load;
            panelContent.ResumeLayout(false);
            panelConfig.ResumeLayout(false);
            panelConfigRight.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelChooseVerb.ResumeLayout(false);
            panelSilde.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Panel panelSilde;
        private AntdUI.Menu menuHymns;
        private AntdUI.Input txtSearchHymn;
        private AntdUI.Select selectHymn;
        private Panel panelChooseVerb;
        private Button btnShowPTT;
        private Button btnFilterVerb;
        private AntdUI.InputNumber txtVerbTo;
        private AntdUI.Label labelToVerb;
        private AntdUI.InputNumber txtVerbFrom;
        private AntdUI.Label labelChooseVerb;
        private Panel panelConfig;
        private Panel panelConfigRight;
        private Panel panelImage;
        private PictureBox pictureBoxBackground;
        private Panel panel1;
        private AntdUI.Label labelFont;
        private AntdUI.Checkbox checkboxBold;
        private AntdUI.Label labelTextType;
        private AntdUI.Checkbox checkboxItalic;
        private AntdUI.Label labelBackground;
        private AntdUI.InputNumber txtFontSize;
        private AntdUI.Label labelTextAlign;
        private AntdUI.Checkbox checkboxUnderline;
        private AntdUI.Label labelColor;
        private AntdUI.Select selectFont;
        private AntdUI.ColorPicker colorPickerTextColor;
        private LinkLabel linkLabelChooseImage;
        private AntdUI.Label labelFontSize;
        private AntdUI.Select selectTextAlign;
        private Button btnSaveConfig;
        private Button btnRemoveBackground;
        private RichTextBox richTextBoxContentSection;
    }
}
