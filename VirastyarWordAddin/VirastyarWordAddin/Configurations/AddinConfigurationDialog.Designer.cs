﻿namespace VirastyarWordAddin.Configurations
{
    partial class AddinConfigurationDialog
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
            this.components = new System.ComponentModel.Container();
            SCICT.Utility.Keyboard.Hotkey hotkey1 = new SCICT.Utility.Keyboard.Hotkey();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinConfigurationDialog));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlButtonsContainer = new System.Windows.Forms.Panel();
            this.pnlTabContainer = new System.Windows.Forms.Panel();
            this.tabCtrlSettings = new System.Windows.Forms.TabControl();
            this.tbPageSpellCheck = new System.Windows.Forms.TabPage();
            this.groupBoxUserDictionaries = new System.Windows.Forms.GroupBox();
            this.lnkEditDictionary = new System.Windows.Forms.LinkLabel();
            this.progressBarBuildDictionary = new System.Windows.Forms.ProgressBar();
            this.linkLabelSpellCheckerCreateDictionary = new System.Windows.Forms.LinkLabel();
            this.linkLabelDeleteItem = new System.Windows.Forms.LinkLabel();
            this.linkLabelSpellCheckerAddExistingDic = new System.Windows.Forms.LinkLabel();
            this.listViewUserDictionaries = new System.Windows.Forms.ListView();
            this.columnHeaderDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDictionaries = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditDic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteDic = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDicPath = new System.Windows.Forms.GroupBox();
            this.lnkEditUserDic = new System.Windows.Forms.LinkLabel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpSpellCheckSettings = new System.Windows.Forms.GroupBox();
            this.cbDontCheckSingleLetters = new System.Windows.Forms.CheckBox();
            this.cbHaaShisakiToHaaYaa = new System.Windows.Forms.CheckBox();
            this.cbVocabSpaceCorrection = new System.Windows.Forms.CheckBox();
            this.nmrMaxSuggestionsCount = new System.Windows.Forms.NumericUpDown();
            this.nmrEditDistance = new System.Windows.Forms.NumericUpDown();
            this.tbPageWords = new System.Windows.Forms.TabPage();
            this.grpSynRhyme = new System.Windows.Forms.GroupBox();
            this.lnkRhyme = new System.Windows.Forms.LinkLabel();
            this.lnkPersian = new System.Windows.Forms.LinkLabel();
            this.lnkObsolete = new System.Windows.Forms.LinkLabel();
            this.lnkVulgar = new System.Windows.Forms.LinkLabel();
            this.lnkOral = new System.Windows.Forms.LinkLabel();
            this.lnkImpolite = new System.Windows.Forms.LinkLabel();
            this.tbPageRefineAll = new System.Windows.Forms.TabPage();
            this.grpRefineIgnoreList = new System.Windows.Forms.GroupBox();
            this.btnRemoveFromIgnoreList = new System.Windows.Forms.Button();
            this.btnAddLetterToIgnoreList = new System.Windows.Forms.Button();
            this.tetLetterToIgnore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewIgnoreList = new System.Windows.Forms.ListView();
            this.columnCharFace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDecimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.grpItemsToRefine = new System.Windows.Forms.GroupBox();
            this.cbRemoveHalfSpaces = new System.Windows.Forms.CheckBox();
            this.cbRefineErab = new System.Windows.Forms.CheckBox();
            this.cbRefineHalfSpaceChar = new System.Windows.Forms.CheckBox();
            this.cbRefineDigits = new System.Windows.Forms.CheckBox();
            this.cbRefineYaa = new System.Windows.Forms.CheckBox();
            this.cbRefineKaaf = new System.Windows.Forms.CheckBox();
            this.tbPagePreprocessSpell = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRefineAllAffixes = new System.Windows.Forms.CheckBox();
            this.cbRefineBe = new System.Windows.Forms.CheckBox();
            this.cbRefineHeYe = new System.Windows.Forms.CheckBox();
            this.cbRefineMee = new System.Windows.Forms.CheckBox();
            this.cbRefineHaa = new System.Windows.Forms.CheckBox();
            this.tbPageWordCompletion = new System.Windows.Forms.TabPage();
            this.gpWCFont = new System.Windows.Forms.GroupBox();
            this.numUpDownWCFontSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.gbWCMisc = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numUpDownWCMinWordLength = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbWCCompleteWithoutHotkey = new System.Windows.Forms.CheckBox();
            this.cbWCInsertSpace = new System.Windows.Forms.CheckBox();
            this.gbWCWordCount = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDownWCWordCount = new System.Windows.Forms.NumericUpDown();
            this.rbWCShowMaxWords = new System.Windows.Forms.RadioButton();
            this.rbWCShowAllWords = new System.Windows.Forms.RadioButton();
            this.tbPageShortcut = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstShortcuts = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnShortcut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentHotkey = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClearHotkey = new System.Windows.Forms.Button();
            this.btnAssignHotkey = new System.Windows.Forms.Button();
            this.lblShortcutDesc = new System.Windows.Forms.Label();
            this.hotkeyControl = new VirastyarWordAddin.Controls.HotkeyBox();
            this.tbPageAddinSettings = new System.Windows.Forms.TabPage();
            this.grpVirastyarUpdate = new System.Windows.Forms.GroupBox();
            this.btnCheckForUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoSendReportDecline = new System.Windows.Forms.RadioButton();
            this.rdoSendReportAccept = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpResetSettings = new System.Windows.Forms.GroupBox();
            this.btnRestoreDataFiles = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlButtonsContainer.SuspendLayout();
            this.pnlTabContainer.SuspendLayout();
            this.tabCtrlSettings.SuspendLayout();
            this.tbPageSpellCheck.SuspendLayout();
            this.groupBoxUserDictionaries.SuspendLayout();
            this.contextMenuStripDictionaries.SuspendLayout();
            this.grpDicPath.SuspendLayout();
            this.grpSpellCheckSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaxSuggestionsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEditDistance)).BeginInit();
            this.tbPageWords.SuspendLayout();
            this.grpSynRhyme.SuspendLayout();
            this.tbPageRefineAll.SuspendLayout();
            this.grpRefineIgnoreList.SuspendLayout();
            this.grpItemsToRefine.SuspendLayout();
            this.tbPagePreprocessSpell.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbPageWordCompletion.SuspendLayout();
            this.gpWCFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWCFontSize)).BeginInit();
            this.gbWCMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWCMinWordLength)).BeginInit();
            this.gbWCWordCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWCWordCount)).BeginInit();
            this.tbPageShortcut.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbPageAddinSettings.SuspendLayout();
            this.grpVirastyarUpdate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpResetSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(458, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "تأیید";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(4, 11);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(164, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "اعمال - غیرفعال است";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(377, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButtonsContainer
            // 
            this.pnlButtonsContainer.Controls.Add(this.btnApply);
            this.pnlButtonsContainer.Controls.Add(this.btnOK);
            this.pnlButtonsContainer.Controls.Add(this.btnCancel);
            this.pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsContainer.Location = new System.Drawing.Point(0, 495);
            this.pnlButtonsContainer.Name = "pnlButtonsContainer";
            this.pnlButtonsContainer.Size = new System.Drawing.Size(537, 44);
            this.pnlButtonsContainer.TabIndex = 0;
            // 
            // pnlTabContainer
            // 
            this.pnlTabContainer.Controls.Add(this.tabCtrlSettings);
            this.pnlTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTabContainer.Name = "pnlTabContainer";
            this.pnlTabContainer.Size = new System.Drawing.Size(537, 495);
            this.pnlTabContainer.TabIndex = 5;
            // 
            // tabCtrlSettings
            // 
            this.tabCtrlSettings.Controls.Add(this.tbPageSpellCheck);
            this.tabCtrlSettings.Controls.Add(this.tbPageWords);
            this.tabCtrlSettings.Controls.Add(this.tbPageRefineAll);
            this.tabCtrlSettings.Controls.Add(this.tbPagePreprocessSpell);
            this.tabCtrlSettings.Controls.Add(this.tbPageWordCompletion);
            this.tabCtrlSettings.Controls.Add(this.tbPageShortcut);
            this.tabCtrlSettings.Controls.Add(this.tbPageAddinSettings);
            this.tabCtrlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlSettings.Name = "tabCtrlSettings";
            this.tabCtrlSettings.RightToLeftLayout = true;
            this.tabCtrlSettings.SelectedIndex = 0;
            this.tabCtrlSettings.Size = new System.Drawing.Size(537, 495);
            this.tabCtrlSettings.TabIndex = 6;
            // 
            // tbPageSpellCheck
            // 
            this.tbPageSpellCheck.Controls.Add(this.groupBoxUserDictionaries);
            this.tbPageSpellCheck.Controls.Add(this.grpDicPath);
            this.tbPageSpellCheck.Controls.Add(this.grpSpellCheckSettings);
            this.tbPageSpellCheck.Location = new System.Drawing.Point(4, 22);
            this.tbPageSpellCheck.Name = "tbPageSpellCheck";
            this.tbPageSpellCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSpellCheck.Size = new System.Drawing.Size(529, 469);
            this.tbPageSpellCheck.TabIndex = 1;
            this.tbPageSpellCheck.Text = "غلط‌یاب";
            this.tbPageSpellCheck.ToolTipText = "تنظمیات مرتبط با غلط‌یاب";
            this.tbPageSpellCheck.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserDictionaries
            // 
            this.groupBoxUserDictionaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUserDictionaries.Controls.Add(this.lnkEditDictionary);
            this.groupBoxUserDictionaries.Controls.Add(this.progressBarBuildDictionary);
            this.groupBoxUserDictionaries.Controls.Add(this.linkLabelSpellCheckerCreateDictionary);
            this.groupBoxUserDictionaries.Controls.Add(this.linkLabelDeleteItem);
            this.groupBoxUserDictionaries.Controls.Add(this.linkLabelSpellCheckerAddExistingDic);
            this.groupBoxUserDictionaries.Controls.Add(this.listViewUserDictionaries);
            this.groupBoxUserDictionaries.Location = new System.Drawing.Point(6, 179);
            this.groupBoxUserDictionaries.Name = "groupBoxUserDictionaries";
            this.groupBoxUserDictionaries.Size = new System.Drawing.Size(515, 284);
            this.groupBoxUserDictionaries.TabIndex = 2;
            this.groupBoxUserDictionaries.TabStop = false;
            this.groupBoxUserDictionaries.Text = "واژه‌نامه(ها)‌ی اختیاری کاربر";
            // 
            // lnkEditDictionary
            // 
            this.lnkEditDictionary.AutoSize = true;
            this.lnkEditDictionary.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEditDictionary.Location = new System.Drawing.Point(428, 34);
            this.lnkEditDictionary.Name = "lnkEditDictionary";
            this.lnkEditDictionary.Size = new System.Drawing.Size(78, 13);
            this.lnkEditDictionary.TabIndex = 7;
            this.lnkEditDictionary.TabStop = true;
            this.lnkEditDictionary.Text = "ویرایش واژه‌نامه";
            this.lnkEditDictionary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditDictionary_LinkClicked);
            // 
            // progressBarBuildDictionary
            // 
            this.progressBarBuildDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBuildDictionary.Location = new System.Drawing.Point(6, 259);
            this.progressBarBuildDictionary.Name = "progressBarBuildDictionary";
            this.progressBarBuildDictionary.RightToLeftLayout = true;
            this.progressBarBuildDictionary.Size = new System.Drawing.Size(352, 15);
            this.progressBarBuildDictionary.TabIndex = 6;
            this.progressBarBuildDictionary.Visible = false;
            // 
            // linkLabelSpellCheckerCreateDictionary
            // 
            this.linkLabelSpellCheckerCreateDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSpellCheckerCreateDictionary.AutoSize = true;
            this.linkLabelSpellCheckerCreateDictionary.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelSpellCheckerCreateDictionary.Location = new System.Drawing.Point(364, 256);
            this.linkLabelSpellCheckerCreateDictionary.Name = "linkLabelSpellCheckerCreateDictionary";
            this.linkLabelSpellCheckerCreateDictionary.Size = new System.Drawing.Size(142, 13);
            this.linkLabelSpellCheckerCreateDictionary.TabIndex = 3;
            this.linkLabelSpellCheckerCreateDictionary.TabStop = true;
            this.linkLabelSpellCheckerCreateDictionary.Text = "ساختن واژه‌نامه از سند جاری ";
            this.linkLabelSpellCheckerCreateDictionary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSpellCheckerCreateDictionary_LinkClicked);
            // 
            // linkLabelDeleteItem
            // 
            this.linkLabelDeleteItem.AutoSize = true;
            this.linkLabelDeleteItem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelDeleteItem.Location = new System.Drawing.Point(31, 39);
            this.linkLabelDeleteItem.Name = "linkLabelDeleteItem";
            this.linkLabelDeleteItem.Size = new System.Drawing.Size(68, 13);
            this.linkLabelDeleteItem.TabIndex = 1;
            this.linkLabelDeleteItem.TabStop = true;
            this.linkLabelDeleteItem.Text = "حذف واژه‌نامه";
            this.linkLabelDeleteItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeleteItem_LinkClicked);
            // 
            // linkLabelSpellCheckerAddExistingDic
            // 
            this.linkLabelSpellCheckerAddExistingDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSpellCheckerAddExistingDic.AutoSize = true;
            this.linkLabelSpellCheckerAddExistingDic.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelSpellCheckerAddExistingDic.Location = new System.Drawing.Point(21, 17);
            this.linkLabelSpellCheckerAddExistingDic.Name = "linkLabelSpellCheckerAddExistingDic";
            this.linkLabelSpellCheckerAddExistingDic.Size = new System.Drawing.Size(78, 13);
            this.linkLabelSpellCheckerAddExistingDic.TabIndex = 0;
            this.linkLabelSpellCheckerAddExistingDic.TabStop = true;
            this.linkLabelSpellCheckerAddExistingDic.Text = "افزودن واژه‌نامه ";
            this.linkLabelSpellCheckerAddExistingDic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSpellCheckerAddExistingDic_LinkClicked);
            // 
            // listViewUserDictionaries
            // 
            this.listViewUserDictionaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUserDictionaries.CheckBoxes = true;
            this.listViewUserDictionaries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDesc,
            this.columnHeaderFile});
            this.listViewUserDictionaries.ContextMenuStrip = this.contextMenuStripDictionaries;
            this.listViewUserDictionaries.FullRowSelect = true;
            this.listViewUserDictionaries.HideSelection = false;
            this.listViewUserDictionaries.LabelEdit = true;
            this.listViewUserDictionaries.Location = new System.Drawing.Point(6, 61);
            this.listViewUserDictionaries.MultiSelect = false;
            this.listViewUserDictionaries.Name = "listViewUserDictionaries";
            this.listViewUserDictionaries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewUserDictionaries.Size = new System.Drawing.Size(499, 192);
            this.listViewUserDictionaries.TabIndex = 2;
            this.listViewUserDictionaries.UseCompatibleStateImageBehavior = false;
            this.listViewUserDictionaries.View = System.Windows.Forms.View.Details;
            this.listViewUserDictionaries.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewUserDictionaries_BeforeLabelEdit);
            // 
            // columnHeaderDesc
            // 
            this.columnHeaderDesc.Text = "عنوان";
            this.columnHeaderDesc.Width = 150;
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "مسیر فایل واژه‌نامه";
            this.columnHeaderFile.Width = 345;
            // 
            // contextMenuStripDictionaries
            // 
            this.contextMenuStripDictionaries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditDic,
            this.toolStripMenuItemDeleteDic});
            this.contextMenuStripDictionaries.Name = "contextMenuStripDictionaries";
            this.contextMenuStripDictionaries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStripDictionaries.Size = new System.Drawing.Size(147, 48);
            // 
            // toolStripMenuItemEditDic
            // 
            this.toolStripMenuItemEditDic.Name = "toolStripMenuItemEditDic";
            this.toolStripMenuItemEditDic.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemEditDic.Text = "ویرایش واژه‌نامه";
            this.toolStripMenuItemEditDic.Click += new System.EventHandler(this.toolStripMenuItemEditDic_Click);
            // 
            // toolStripMenuItemDeleteDic
            // 
            this.toolStripMenuItemDeleteDic.Name = "toolStripMenuItemDeleteDic";
            this.toolStripMenuItemDeleteDic.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemDeleteDic.Text = "حذف واژه‌نامه";
            this.toolStripMenuItemDeleteDic.Click += new System.EventHandler(this.toolStripMenuItemDeleteDic_Click);
            // 
            // grpDicPath
            // 
            this.grpDicPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDicPath.Controls.Add(this.lnkEditUserDic);
            this.grpDicPath.Controls.Add(this.txtFileName);
            this.grpDicPath.Controls.Add(this.label1);
            this.grpDicPath.Controls.Add(this.btnBrowse);
            this.grpDicPath.Location = new System.Drawing.Point(6, 6);
            this.grpDicPath.Name = "grpDicPath";
            this.grpDicPath.Size = new System.Drawing.Size(515, 78);
            this.grpDicPath.TabIndex = 0;
            this.grpDicPath.TabStop = false;
            // 
            // lnkEditUserDic
            // 
            this.lnkEditUserDic.AutoSize = true;
            this.lnkEditUserDic.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEditUserDic.Location = new System.Drawing.Point(428, 45);
            this.lnkEditUserDic.Name = "lnkEditUserDic";
            this.lnkEditUserDic.Size = new System.Drawing.Size(78, 13);
            this.lnkEditUserDic.TabIndex = 8;
            this.lnkEditUserDic.TabStop = true;
            this.lnkEditUserDic.Text = "ویرایش واژه‌نامه";
            this.lnkEditUserDic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditUserDic_LinkClicked);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(40, 41);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFileName.Size = new System.Drawing.Size(382, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسیر واژه‌نامه‌ی شخصی کاربر:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpSpellCheckSettings
            // 
            this.grpSpellCheckSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSpellCheckSettings.Controls.Add(this.cbDontCheckSingleLetters);
            this.grpSpellCheckSettings.Controls.Add(this.cbHaaShisakiToHaaYaa);
            this.grpSpellCheckSettings.Controls.Add(this.cbVocabSpaceCorrection);
            this.grpSpellCheckSettings.Controls.Add(this.nmrMaxSuggestionsCount);
            this.grpSpellCheckSettings.Controls.Add(this.nmrEditDistance);
            this.grpSpellCheckSettings.Location = new System.Drawing.Point(6, 90);
            this.grpSpellCheckSettings.Name = "grpSpellCheckSettings";
            this.grpSpellCheckSettings.Size = new System.Drawing.Size(515, 83);
            this.grpSpellCheckSettings.TabIndex = 1;
            this.grpSpellCheckSettings.TabStop = false;
            this.grpSpellCheckSettings.Text = "تنظیمات";
            // 
            // cbDontCheckSingleLetters
            // 
            this.cbDontCheckSingleLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDontCheckSingleLetters.AutoSize = true;
            this.cbDontCheckSingleLetters.Location = new System.Drawing.Point(324, 52);
            this.cbDontCheckSingleLetters.Name = "cbDontCheckSingleLetters";
            this.cbDontCheckSingleLetters.Size = new System.Drawing.Size(185, 17);
            this.cbDontCheckSingleLetters.TabIndex = 1;
            this.cbDontCheckSingleLetters.Text = "عدم غلط‌یابی حروف به صورت منفرد";
            this.cbDontCheckSingleLetters.UseVisualStyleBackColor = true;
            // 
            // cbHaaShisakiToHaaYaa
            // 
            this.cbHaaShisakiToHaaYaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHaaShisakiToHaaYaa.AutoSize = true;
            this.cbHaaShisakiToHaaYaa.Checked = true;
            this.cbHaaShisakiToHaaYaa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHaaShisakiToHaaYaa.Location = new System.Drawing.Point(202, 20);
            this.cbHaaShisakiToHaaYaa.Name = "cbHaaShisakiToHaaYaa";
            this.cbHaaShisakiToHaaYaa.Size = new System.Drawing.Size(307, 17);
            this.cbHaaShisakiToHaaYaa.TabIndex = 0;
            this.cbHaaShisakiToHaaYaa.Text = "در نظر گرفتن «ـۀ» به عنوان غلط املایی و تصحیح آن به «ـه‌ی»";
            this.cbHaaShisakiToHaaYaa.UseVisualStyleBackColor = true;
            // 
            // cbVocabSpaceCorrection
            // 
            this.cbVocabSpaceCorrection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVocabSpaceCorrection.AutoSize = true;
            this.cbVocabSpaceCorrection.Location = new System.Drawing.Point(147, 20);
            this.cbVocabSpaceCorrection.Name = "cbVocabSpaceCorrection";
            this.cbVocabSpaceCorrection.Size = new System.Drawing.Size(40, 17);
            this.cbVocabSpaceCorrection.TabIndex = 15;
            this.cbVocabSpaceCorrection.Tag = "اصلاح فاصله‌گذاری کلمات صحیح";
            this.cbVocabSpaceCorrection.Text = "اص";
            this.cbVocabSpaceCorrection.UseVisualStyleBackColor = true;
            this.cbVocabSpaceCorrection.Visible = false;
            // 
            // nmrMaxSuggestionsCount
            // 
            this.nmrMaxSuggestionsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrMaxSuggestionsCount.Location = new System.Drawing.Point(102, 16);
            this.nmrMaxSuggestionsCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrMaxSuggestionsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMaxSuggestionsCount.Name = "nmrMaxSuggestionsCount";
            this.nmrMaxSuggestionsCount.Size = new System.Drawing.Size(37, 21);
            this.nmrMaxSuggestionsCount.TabIndex = 14;
            this.nmrMaxSuggestionsCount.Tag = "تعداد پیشنهادات";
            this.nmrMaxSuggestionsCount.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nmrMaxSuggestionsCount.Visible = false;
            // 
            // nmrEditDistance
            // 
            this.nmrEditDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrEditDistance.Location = new System.Drawing.Point(65, 16);
            this.nmrEditDistance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrEditDistance.Name = "nmrEditDistance";
            this.nmrEditDistance.Size = new System.Drawing.Size(31, 21);
            this.nmrEditDistance.TabIndex = 12;
            this.nmrEditDistance.Tag = "فاصله ویرایشی";
            this.nmrEditDistance.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmrEditDistance.Visible = false;
            // 
            // tbPageWords
            // 
            this.tbPageWords.Controls.Add(this.grpSynRhyme);
            this.tbPageWords.Location = new System.Drawing.Point(4, 22);
            this.tbPageWords.Name = "tbPageWords";
            this.tbPageWords.Size = new System.Drawing.Size(529, 469);
            this.tbPageWords.TabIndex = 6;
            this.tbPageWords.Text = "واژه‌ها";
            this.tbPageWords.UseVisualStyleBackColor = true;
            // 
            // grpSynRhyme
            // 
            this.grpSynRhyme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSynRhyme.Controls.Add(this.lnkRhyme);
            this.grpSynRhyme.Controls.Add(this.lnkPersian);
            this.grpSynRhyme.Controls.Add(this.lnkObsolete);
            this.grpSynRhyme.Controls.Add(this.lnkVulgar);
            this.grpSynRhyme.Controls.Add(this.lnkOral);
            this.grpSynRhyme.Controls.Add(this.lnkImpolite);
            this.grpSynRhyme.Location = new System.Drawing.Point(3, 12);
            this.grpSynRhyme.Name = "grpSynRhyme";
            this.grpSynRhyme.Size = new System.Drawing.Size(518, 118);
            this.grpSynRhyme.TabIndex = 0;
            this.grpSynRhyme.TabStop = false;
            this.grpSynRhyme.Text = "ویرایش پایگاه داده";
            // 
            // lnkRhyme
            // 
            this.lnkRhyme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRhyme.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRhyme.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lnkRhyme.Location = new System.Drawing.Point(204, 85);
            this.lnkRhyme.Name = "lnkRhyme";
            this.lnkRhyme.Size = new System.Drawing.Size(126, 13);
            this.lnkRhyme.TabIndex = 5;
            this.lnkRhyme.TabStop = true;
            this.lnkRhyme.Text = "هم-قافیه ";
            this.lnkRhyme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRhyme_LinkClicked);
            // 
            // lnkPersian
            // 
            this.lnkPersian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPersian.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPersian.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lnkPersian.Location = new System.Drawing.Point(215, 57);
            this.lnkPersian.Name = "lnkPersian";
            this.lnkPersian.Size = new System.Drawing.Size(115, 13);
            this.lnkPersian.TabIndex = 4;
            this.lnkPersian.TabStop = true;
            this.lnkPersian.Text = "پارسی ";
            this.lnkPersian.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPersian_LinkClicked);
            // 
            // lnkObsolete
            // 
            this.lnkObsolete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkObsolete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkObsolete.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lnkObsolete.Location = new System.Drawing.Point(219, 33);
            this.lnkObsolete.Name = "lnkObsolete";
            this.lnkObsolete.Size = new System.Drawing.Size(111, 13);
            this.lnkObsolete.TabIndex = 3;
            this.lnkObsolete.TabStop = true;
            this.lnkObsolete.Text = "مهجور ";
            this.lnkObsolete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkObsolete_LinkClicked);
            // 
            // lnkVulgar
            // 
            this.lnkVulgar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkVulgar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkVulgar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lnkVulgar.Location = new System.Drawing.Point(372, 85);
            this.lnkVulgar.Name = "lnkVulgar";
            this.lnkVulgar.Size = new System.Drawing.Size(115, 13);
            this.lnkVulgar.TabIndex = 2;
            this.lnkVulgar.TabStop = true;
            this.lnkVulgar.Text = "عامیانه ";
            this.lnkVulgar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVulgar_LinkClicked);
            // 
            // lnkOral
            // 
            this.lnkOral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkOral.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkOral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lnkOral.Location = new System.Drawing.Point(365, 57);
            this.lnkOral.Name = "lnkOral";
            this.lnkOral.Size = new System.Drawing.Size(122, 13);
            this.lnkOral.TabIndex = 1;
            this.lnkOral.TabStop = true;
            this.lnkOral.Text = "شفاهی ";
            this.lnkOral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOral_LinkClicked);
            // 
            // lnkImpolite
            // 
            this.lnkImpolite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkImpolite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkImpolite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lnkImpolite.Location = new System.Drawing.Point(367, 33);
            this.lnkImpolite.Name = "lnkImpolite";
            this.lnkImpolite.Size = new System.Drawing.Size(120, 13);
            this.lnkImpolite.TabIndex = 0;
            this.lnkImpolite.TabStop = true;
            this.lnkImpolite.Text = "نامودبانه ";
            this.lnkImpolite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImpolite_LinkClicked);
            // 
            // tbPageRefineAll
            // 
            this.tbPageRefineAll.Controls.Add(this.grpRefineIgnoreList);
            this.tbPageRefineAll.Controls.Add(this.grpItemsToRefine);
            this.tbPageRefineAll.Location = new System.Drawing.Point(4, 22);
            this.tbPageRefineAll.Name = "tbPageRefineAll";
            this.tbPageRefineAll.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageRefineAll.Size = new System.Drawing.Size(529, 469);
            this.tbPageRefineAll.TabIndex = 5;
            this.tbPageRefineAll.Text = "اصلاح نویسه‌ها";
            this.tbPageRefineAll.UseVisualStyleBackColor = true;
            // 
            // grpRefineIgnoreList
            // 
            this.grpRefineIgnoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRefineIgnoreList.Controls.Add(this.btnRemoveFromIgnoreList);
            this.grpRefineIgnoreList.Controls.Add(this.btnAddLetterToIgnoreList);
            this.grpRefineIgnoreList.Controls.Add(this.tetLetterToIgnore);
            this.grpRefineIgnoreList.Controls.Add(this.label7);
            this.grpRefineIgnoreList.Controls.Add(this.listViewIgnoreList);
            this.grpRefineIgnoreList.Controls.Add(this.label6);
            this.grpRefineIgnoreList.Location = new System.Drawing.Point(7, 169);
            this.grpRefineIgnoreList.Name = "grpRefineIgnoreList";
            this.grpRefineIgnoreList.Size = new System.Drawing.Size(514, 294);
            this.grpRefineIgnoreList.TabIndex = 1;
            this.grpRefineIgnoreList.TabStop = false;
            this.grpRefineIgnoreList.Text = "حروف زیر را نادیده بگیر";
            // 
            // btnRemoveFromIgnoreList
            // 
            this.btnRemoveFromIgnoreList.Location = new System.Drawing.Point(6, 50);
            this.btnRemoveFromIgnoreList.Name = "btnRemoveFromIgnoreList";
            this.btnRemoveFromIgnoreList.Size = new System.Drawing.Size(68, 23);
            this.btnRemoveFromIgnoreList.TabIndex = 5;
            this.btnRemoveFromIgnoreList.Text = "حذف";
            this.btnRemoveFromIgnoreList.UseVisualStyleBackColor = true;
            this.btnRemoveFromIgnoreList.Click += new System.EventHandler(this.btnRemoveFromIgnoreList_Click);
            // 
            // btnAddLetterToIgnoreList
            // 
            this.btnAddLetterToIgnoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLetterToIgnoreList.Location = new System.Drawing.Point(254, 50);
            this.btnAddLetterToIgnoreList.Name = "btnAddLetterToIgnoreList";
            this.btnAddLetterToIgnoreList.Size = new System.Drawing.Size(68, 23);
            this.btnAddLetterToIgnoreList.TabIndex = 4;
            this.btnAddLetterToIgnoreList.Text = "افزودن";
            this.btnAddLetterToIgnoreList.UseVisualStyleBackColor = true;
            this.btnAddLetterToIgnoreList.Click += new System.EventHandler(this.btnAddLetterToIgnoreList_Click);
            // 
            // tetLetterToIgnore
            // 
            this.tetLetterToIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tetLetterToIgnore.Location = new System.Drawing.Point(328, 52);
            this.tetLetterToIgnore.Name = "tetLetterToIgnore";
            this.tetLetterToIgnore.Size = new System.Drawing.Size(79, 21);
            this.tetLetterToIgnore.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "حرف را وارد کنید:";
            // 
            // listViewIgnoreList
            // 
            this.listViewIgnoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIgnoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCharFace,
            this.columnHex,
            this.columnDecimal});
            this.listViewIgnoreList.FullRowSelect = true;
            this.listViewIgnoreList.Location = new System.Drawing.Point(6, 79);
            this.listViewIgnoreList.MultiSelect = false;
            this.listViewIgnoreList.Name = "listViewIgnoreList";
            this.listViewIgnoreList.RightToLeftLayout = true;
            this.listViewIgnoreList.Size = new System.Drawing.Size(499, 209);
            this.listViewIgnoreList.TabIndex = 1;
            this.listViewIgnoreList.UseCompatibleStateImageBehavior = false;
            this.listViewIgnoreList.View = System.Windows.Forms.View.Details;
            // 
            // columnCharFace
            // 
            this.columnCharFace.Text = "نویسه‌ی حرف";
            this.columnCharFace.Width = 150;
            // 
            // columnHex
            // 
            this.columnHex.Text = "کد هگزا دسیمال";
            this.columnHex.Width = 120;
            // 
            // columnDecimal
            // 
            this.columnDecimal.Text = "کد دسیمال";
            this.columnDecimal.Width = 225;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(502, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "اگر می‌خواهید نرم‌افزار حرف خاصی را اصلاح نکند، آن را به فهرست زیر بیفزایید:";
            // 
            // grpItemsToRefine
            // 
            this.grpItemsToRefine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpItemsToRefine.Controls.Add(this.cbRemoveHalfSpaces);
            this.grpItemsToRefine.Controls.Add(this.cbRefineErab);
            this.grpItemsToRefine.Controls.Add(this.cbRefineHalfSpaceChar);
            this.grpItemsToRefine.Controls.Add(this.cbRefineDigits);
            this.grpItemsToRefine.Controls.Add(this.cbRefineYaa);
            this.grpItemsToRefine.Controls.Add(this.cbRefineKaaf);
            this.grpItemsToRefine.Location = new System.Drawing.Point(6, 6);
            this.grpItemsToRefine.Name = "grpItemsToRefine";
            this.grpItemsToRefine.Size = new System.Drawing.Size(515, 160);
            this.grpItemsToRefine.TabIndex = 0;
            this.grpItemsToRefine.TabStop = false;
            this.grpItemsToRefine.Text = "مواردی که اصلاح می‌شوند";
            // 
            // cbRemoveHalfSpaces
            // 
            this.cbRemoveHalfSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRemoveHalfSpaces.AutoSize = true;
            this.cbRemoveHalfSpaces.Checked = true;
            this.cbRemoveHalfSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveHalfSpaces.Location = new System.Drawing.Point(311, 135);
            this.cbRemoveHalfSpaces.Name = "cbRemoveHalfSpaces";
            this.cbRemoveHalfSpaces.Size = new System.Drawing.Size(198, 17);
            this.cbRemoveHalfSpaces.TabIndex = 5;
            this.cbRemoveHalfSpaces.Text = "حذف و جابجایی نیم‌فاصله‌های اضافی";
            this.toolTip.SetToolTip(this.cbRemoveHalfSpaces, "چنانچه بیش از یک نیم‌فاصله پشت سر هم درج شود نیم‌فاصله‌های اضافی حذف می‌شوند.\r\nهم" +
        "‌چنین اگر بعد از حرف‌های غیرچسبان (مثل د و ر) نیم‌فاصله درج شده باشد این نیم‌فاص" +
        "له نیز اضافی بوده و حذف خواهد شد.");
            this.cbRemoveHalfSpaces.UseVisualStyleBackColor = true;
            // 
            // cbRefineErab
            // 
            this.cbRefineErab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineErab.AutoSize = true;
            this.cbRefineErab.Checked = true;
            this.cbRefineErab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineErab.Location = new System.Drawing.Point(427, 112);
            this.cbRefineErab.Name = "cbRefineErab";
            this.cbRefineErab.Size = new System.Drawing.Size(82, 17);
            this.cbRefineErab.TabIndex = 4;
            this.cbRefineErab.Text = "اصلاح اعراب";
            this.toolTip.SetToolTip(this.cbRefineErab, "برخی فونت‌های فارسی، کاراکترهای غیر استانداردی برای اعراب اضافه کرده‌اند که با ای" +
        "ن گزینه\r\n می‌توان آن‌ها را به معادل استانداردشان تبدیل کرد.");
            this.cbRefineErab.UseVisualStyleBackColor = true;
            // 
            // cbRefineHalfSpaceChar
            // 
            this.cbRefineHalfSpaceChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineHalfSpaceChar.AutoSize = true;
            this.cbRefineHalfSpaceChar.Checked = true;
            this.cbRefineHalfSpaceChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineHalfSpaceChar.Location = new System.Drawing.Point(369, 89);
            this.cbRefineHalfSpaceChar.Name = "cbRefineHalfSpaceChar";
            this.cbRefineHalfSpaceChar.Size = new System.Drawing.Size(140, 17);
            this.cbRefineHalfSpaceChar.TabIndex = 3;
            this.cbRefineHalfSpaceChar.Text = "اصلاح نویسه‌ی نیم فاصله";
            this.toolTip.SetToolTip(this.cbRefineHalfSpaceChar, "برخی کاراکترهای نیم‌فاصله که در برنامه‌های مختلف استفاده می‌شود با هم متفاوت هستن" +
        "د.\r\nبا این گزینه می‌توان تمامی آن‌ها را به کاراکتر نیم‌فاصله‌ی استاندارد تغییر د" +
        "اد.");
            this.cbRefineHalfSpaceChar.UseVisualStyleBackColor = true;
            // 
            // cbRefineDigits
            // 
            this.cbRefineDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineDigits.AutoSize = true;
            this.cbRefineDigits.Checked = true;
            this.cbRefineDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineDigits.Location = new System.Drawing.Point(322, 66);
            this.cbRefineDigits.Name = "cbRefineDigits";
            this.cbRefineDigits.Size = new System.Drawing.Size(187, 17);
            this.cbRefineDigits.TabIndex = 2;
            this.cbRefineDigits.Text = "اصلاح ارقام عربی به معادل فارسی";
            this.toolTip.SetToolTip(this.cbRefineDigits, "مثلا تبدیل «٤ به ۴»  یا  «٦ به ۶»");
            this.cbRefineDigits.UseVisualStyleBackColor = true;
            // 
            // cbRefineYaa
            // 
            this.cbRefineYaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineYaa.AutoSize = true;
            this.cbRefineYaa.Checked = true;
            this.cbRefineYaa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineYaa.Location = new System.Drawing.Point(205, 43);
            this.cbRefineYaa.Name = "cbRefineYaa";
            this.cbRefineYaa.Size = new System.Drawing.Size(304, 17);
            this.cbRefineYaa.TabIndex = 1;
            this.cbRefineYaa.Text = "اصلاح انواع حرف «ی»: تبدیل «ى ي ﻱ ﻲ ...» به ی استاندارد\r\n";
            this.cbRefineYaa.UseVisualStyleBackColor = true;
            // 
            // cbRefineKaaf
            // 
            this.cbRefineKaaf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineKaaf.AutoSize = true;
            this.cbRefineKaaf.Checked = true;
            this.cbRefineKaaf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineKaaf.Location = new System.Drawing.Point(226, 20);
            this.cbRefineKaaf.Name = "cbRefineKaaf";
            this.cbRefineKaaf.Size = new System.Drawing.Size(283, 17);
            this.cbRefineKaaf.TabIndex = 0;
            this.cbRefineKaaf.Text = "اصلاح انواع حرف «ک»: تبدیل «ڪ ك ﻚ ...» به ک استاندارد\r\n";
            this.cbRefineKaaf.UseVisualStyleBackColor = true;
            // 
            // tbPagePreprocessSpell
            // 
            this.tbPagePreprocessSpell.Controls.Add(this.groupBox1);
            this.tbPagePreprocessSpell.Location = new System.Drawing.Point(4, 22);
            this.tbPagePreprocessSpell.Name = "tbPagePreprocessSpell";
            this.tbPagePreprocessSpell.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagePreprocessSpell.Size = new System.Drawing.Size(529, 469);
            this.tbPagePreprocessSpell.TabIndex = 8;
            this.tbPagePreprocessSpell.Text = "پیش‌پردازش املایی";
            this.tbPagePreprocessSpell.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbRefineAllAffixes);
            this.groupBox1.Controls.Add(this.cbRefineBe);
            this.groupBox1.Controls.Add(this.cbRefineHeYe);
            this.groupBox1.Controls.Add(this.cbRefineMee);
            this.groupBox1.Controls.Add(this.cbRefineHaa);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مواردی که هنگام پیش‌پردازش املایی اصلاح می‌شوند";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(195, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 10);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cbRefineAllAffixes
            // 
            this.cbRefineAllAffixes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineAllAffixes.AutoSize = true;
            this.cbRefineAllAffixes.Checked = true;
            this.cbRefineAllAffixes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineAllAffixes.Location = new System.Drawing.Point(382, 131);
            this.cbRefineAllAffixes.Name = "cbRefineAllAffixes";
            this.cbRefineAllAffixes.Size = new System.Drawing.Size(118, 17);
            this.cbRefineAllAffixes.TabIndex = 4;
            this.cbRefineAllAffixes.Text = "اصلاح تمام موارد بالا";
            this.cbRefineAllAffixes.ThreeState = true;
            this.cbRefineAllAffixes.UseVisualStyleBackColor = true;
            this.cbRefineAllAffixes.CheckStateChanged += new System.EventHandler(this.cbRefineAllAffixes_CheckStateChanged);
            // 
            // cbRefineBe
            // 
            this.cbRefineBe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineBe.AutoSize = true;
            this.cbRefineBe.Checked = true;
            this.cbRefineBe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineBe.Location = new System.Drawing.Point(230, 94);
            this.cbRefineBe.Name = "cbRefineBe";
            this.cbRefineBe.Size = new System.Drawing.Size(270, 17);
            this.cbRefineBe.TabIndex = 3;
            this.cbRefineBe.Text = "اصلاح «بـ»: تبدیل «ب» متصل به ابتدای واژه‌ها به «به»\r\n";
            this.cbRefineBe.UseVisualStyleBackColor = true;
            this.cbRefineBe.CheckedChanged += new System.EventHandler(this.cbSpellCheckRefiners_CheckedChanged);
            // 
            // cbRefineHeYe
            // 
            this.cbRefineHeYe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineHeYe.AutoSize = true;
            this.cbRefineHeYe.Checked = true;
            this.cbRefineHeYe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineHeYe.Location = new System.Drawing.Point(329, 71);
            this.cbRefineHeYe.Name = "cbRefineHeYe";
            this.cbRefineHeYe.Size = new System.Drawing.Size(171, 17);
            this.cbRefineHeYe.TabIndex = 2;
            this.cbRefineHeYe.Text = "اصلاح «ـۀ»: تبدیل «‍ـۀ» به «‍ه‌ی»";
            this.cbRefineHeYe.UseVisualStyleBackColor = true;
            this.cbRefineHeYe.CheckedChanged += new System.EventHandler(this.cbSpellCheckRefiners_CheckedChanged);
            // 
            // cbRefineMee
            // 
            this.cbRefineMee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineMee.AutoSize = true;
            this.cbRefineMee.Checked = true;
            this.cbRefineMee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineMee.Location = new System.Drawing.Point(215, 48);
            this.cbRefineMee.Name = "cbRefineMee";
            this.cbRefineMee.Size = new System.Drawing.Size(285, 17);
            this.cbRefineMee.TabIndex = 1;
            this.cbRefineMee.Text = "اصلاح «می»: اصلاح فاصله‌گذاری «می» در ابتدای واژه‌ها";
            this.cbRefineMee.UseVisualStyleBackColor = true;
            this.cbRefineMee.CheckedChanged += new System.EventHandler(this.cbSpellCheckRefiners_CheckedChanged);
            // 
            // cbRefineHaa
            // 
            this.cbRefineHaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRefineHaa.AutoSize = true;
            this.cbRefineHaa.Checked = true;
            this.cbRefineHaa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRefineHaa.Location = new System.Drawing.Point(221, 25);
            this.cbRefineHaa.Name = "cbRefineHaa";
            this.cbRefineHaa.Size = new System.Drawing.Size(279, 17);
            this.cbRefineHaa.TabIndex = 0;
            this.cbRefineHaa.Text = "اصلاح «ها»: اصلاح فاصله‌گذاری «ها» در انتهای واژه‌ها";
            this.cbRefineHaa.UseVisualStyleBackColor = true;
            this.cbRefineHaa.CheckedChanged += new System.EventHandler(this.cbSpellCheckRefiners_CheckedChanged);
            // 
            // tbPageWordCompletion
            // 
            this.tbPageWordCompletion.Controls.Add(this.gpWCFont);
            this.tbPageWordCompletion.Controls.Add(this.gbWCMisc);
            this.tbPageWordCompletion.Controls.Add(this.gbWCWordCount);
            this.tbPageWordCompletion.Location = new System.Drawing.Point(4, 22);
            this.tbPageWordCompletion.Name = "tbPageWordCompletion";
            this.tbPageWordCompletion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageWordCompletion.Size = new System.Drawing.Size(529, 469);
            this.tbPageWordCompletion.TabIndex = 7;
            this.tbPageWordCompletion.Text = "تکمیل خودکار کلمات";
            this.tbPageWordCompletion.UseVisualStyleBackColor = true;
            // 
            // gpWCFont
            // 
            this.gpWCFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpWCFont.Controls.Add(this.numUpDownWCFontSize);
            this.gpWCFont.Controls.Add(this.label11);
            this.gpWCFont.Location = new System.Drawing.Point(8, 226);
            this.gpWCFont.Name = "gpWCFont";
            this.gpWCFont.Size = new System.Drawing.Size(513, 55);
            this.gpWCFont.TabIndex = 3;
            this.gpWCFont.TabStop = false;
            this.gpWCFont.Text = "اندازه فونت";
            // 
            // numUpDownWCFontSize
            // 
            this.numUpDownWCFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownWCFontSize.Location = new System.Drawing.Point(251, 22);
            this.numUpDownWCFontSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numUpDownWCFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownWCFontSize.Name = "numUpDownWCFontSize";
            this.numUpDownWCFontSize.Size = new System.Drawing.Size(46, 21);
            this.numUpDownWCFontSize.TabIndex = 4;
            this.numUpDownWCFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "اندازه‌ی فونت پنجره‌ی تکمیل خودکار کلمات";
            // 
            // gbWCMisc
            // 
            this.gbWCMisc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWCMisc.Controls.Add(this.label9);
            this.gbWCMisc.Controls.Add(this.numUpDownWCMinWordLength);
            this.gbWCMisc.Controls.Add(this.label8);
            this.gbWCMisc.Controls.Add(this.cbWCCompleteWithoutHotkey);
            this.gbWCMisc.Controls.Add(this.cbWCInsertSpace);
            this.gbWCMisc.Location = new System.Drawing.Point(8, 104);
            this.gbWCMisc.Name = "gbWCMisc";
            this.gbWCMisc.Size = new System.Drawing.Size(513, 116);
            this.gbWCMisc.TabIndex = 1;
            this.gbWCMisc.TabStop = false;
            this.gbWCMisc.Text = "تنظیمات";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "حرف باشد.";
            // 
            // numUpDownWCMinWordLength
            // 
            this.numUpDownWCMinWordLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownWCMinWordLength.Location = new System.Drawing.Point(174, 70);
            this.numUpDownWCMinWordLength.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownWCMinWordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownWCMinWordLength.Name = "numUpDownWCMinWordLength";
            this.numUpDownWCMinWordLength.Size = new System.Drawing.Size(46, 21);
            this.numUpDownWCMinWordLength.TabIndex = 3;
            this.numUpDownWCMinWordLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "حداقل طول کلمه جهت تکمیل خودکار بدون فشردن میانبر";
            // 
            // cbWCCompleteWithoutHotkey
            // 
            this.cbWCCompleteWithoutHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWCCompleteWithoutHotkey.AutoSize = true;
            this.cbWCCompleteWithoutHotkey.Checked = true;
            this.cbWCCompleteWithoutHotkey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWCCompleteWithoutHotkey.Location = new System.Drawing.Point(249, 43);
            this.cbWCCompleteWithoutHotkey.Name = "cbWCCompleteWithoutHotkey";
            this.cbWCCompleteWithoutHotkey.Size = new System.Drawing.Size(258, 17);
            this.cbWCCompleteWithoutHotkey.TabIndex = 1;
            this.cbWCCompleteWithoutHotkey.Text = "بدون فشردن میانبر تکمیل خودکار کلمات فعال شود";
            this.cbWCCompleteWithoutHotkey.UseVisualStyleBackColor = true;
            this.cbWCCompleteWithoutHotkey.CheckedChanged += new System.EventHandler(this.cbWCCompleteWithoutHotkey_CheckedChanged);
            // 
            // cbWCInsertSpace
            // 
            this.cbWCInsertSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWCInsertSpace.AutoSize = true;
            this.cbWCInsertSpace.Checked = true;
            this.cbWCInsertSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWCInsertSpace.Location = new System.Drawing.Point(330, 20);
            this.cbWCInsertSpace.Name = "cbWCInsertSpace";
            this.cbWCInsertSpace.Size = new System.Drawing.Size(177, 17);
            this.cbWCInsertSpace.TabIndex = 0;
            this.cbWCInsertSpace.Text = "پس از تکمیل کلمه فاصله درج شود";
            this.cbWCInsertSpace.UseVisualStyleBackColor = true;
            // 
            // gbWCWordCount
            // 
            this.gbWCWordCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWCWordCount.Controls.Add(this.label4);
            this.gbWCWordCount.Controls.Add(this.numUpDownWCWordCount);
            this.gbWCWordCount.Controls.Add(this.rbWCShowMaxWords);
            this.gbWCWordCount.Controls.Add(this.rbWCShowAllWords);
            this.gbWCWordCount.Location = new System.Drawing.Point(8, 6);
            this.gbWCWordCount.Name = "gbWCWordCount";
            this.gbWCWordCount.Size = new System.Drawing.Size(513, 92);
            this.gbWCWordCount.TabIndex = 0;
            this.gbWCWordCount.TabStop = false;
            this.gbWCWordCount.Text = "تعداد کلمات پیشنهادی";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "کلمه";
            // 
            // numUpDownWCWordCount
            // 
            this.numUpDownWCWordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownWCWordCount.Location = new System.Drawing.Point(326, 58);
            this.numUpDownWCWordCount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numUpDownWCWordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownWCWordCount.Name = "numUpDownWCWordCount";
            this.numUpDownWCWordCount.Size = new System.Drawing.Size(76, 21);
            this.numUpDownWCWordCount.TabIndex = 2;
            this.numUpDownWCWordCount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // rbWCShowMaxWords
            // 
            this.rbWCShowMaxWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbWCShowMaxWords.Checked = true;
            this.rbWCShowMaxWords.Location = new System.Drawing.Point(406, 60);
            this.rbWCShowMaxWords.Name = "rbWCShowMaxWords";
            this.rbWCShowMaxWords.Size = new System.Drawing.Size(101, 17);
            this.rbWCShowMaxWords.TabIndex = 1;
            this.rbWCShowMaxWords.TabStop = true;
            this.rbWCShowMaxWords.Text = "نمایش حداکثر";
            this.rbWCShowMaxWords.UseVisualStyleBackColor = true;
            this.rbWCShowMaxWords.CheckedChanged += new System.EventHandler(this.rbWCShowMaxWords_CheckedChanged);
            // 
            // rbWCShowAllWords
            // 
            this.rbWCShowAllWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbWCShowAllWords.AutoSize = true;
            this.rbWCShowAllWords.Location = new System.Drawing.Point(338, 30);
            this.rbWCShowAllWords.Name = "rbWCShowAllWords";
            this.rbWCShowAllWords.Size = new System.Drawing.Size(169, 17);
            this.rbWCShowAllWords.TabIndex = 0;
            this.rbWCShowAllWords.Text = "نمایش تمامی کلمات پیشنهادی";
            this.rbWCShowAllWords.UseVisualStyleBackColor = true;
            // 
            // tbPageShortcut
            // 
            this.tbPageShortcut.Controls.Add(this.panel2);
            this.tbPageShortcut.Controls.Add(this.panel1);
            this.tbPageShortcut.Location = new System.Drawing.Point(4, 22);
            this.tbPageShortcut.Name = "tbPageShortcut";
            this.tbPageShortcut.Size = new System.Drawing.Size(529, 469);
            this.tbPageShortcut.TabIndex = 3;
            this.tbPageShortcut.Text = "میانبرها";
            this.tbPageShortcut.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstShortcuts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 294);
            this.panel2.TabIndex = 3;
            // 
            // lstShortcuts
            // 
            this.lstShortcuts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstShortcuts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnShortcut});
            this.lstShortcuts.FullRowSelect = true;
            this.lstShortcuts.HideSelection = false;
            this.lstShortcuts.Location = new System.Drawing.Point(8, 15);
            this.lstShortcuts.MultiSelect = false;
            this.lstShortcuts.Name = "lstShortcuts";
            this.lstShortcuts.RightToLeftLayout = true;
            this.lstShortcuts.Size = new System.Drawing.Size(513, 273);
            this.lstShortcuts.TabIndex = 1;
            this.lstShortcuts.UseCompatibleStateImageBehavior = false;
            this.lstShortcuts.View = System.Windows.Forms.View.Details;
            this.lstShortcuts.SelectedIndexChanged += new System.EventHandler(this.lstShortcuts_SelectedIndexChanged);
            // 
            // clmnName
            // 
            this.clmnName.Text = "دستور";
            this.clmnName.Width = 260;
            // 
            // clmnShortcut
            // 
            this.clmnShortcut.Text = "میانبر فعلی";
            this.clmnShortcut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmnShortcut.Width = 204;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCurrentHotkey);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnClearHotkey);
            this.panel1.Controls.Add(this.btnAssignHotkey);
            this.panel1.Controls.Add(this.lblShortcutDesc);
            this.panel1.Controls.Add(this.hotkeyControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 175);
            this.panel1.TabIndex = 2;
            // 
            // lblCurrentHotkey
            // 
            this.lblCurrentHotkey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCurrentHotkey.Location = new System.Drawing.Point(0, 134);
            this.lblCurrentHotkey.Name = "lblCurrentHotkey";
            this.lblCurrentHotkey.Size = new System.Drawing.Size(529, 41);
            this.lblCurrentHotkey.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(221, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "میانبر موردنظر خود را انتخاب کرده و دکمه تعیین را کلیک کنید:";
            // 
            // btnClearHotkey
            // 
            this.btnClearHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHotkey.Location = new System.Drawing.Point(176, 94);
            this.btnClearHotkey.Name = "btnClearHotkey";
            this.btnClearHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnClearHotkey.TabIndex = 4;
            this.btnClearHotkey.Text = "حذف";
            this.btnClearHotkey.UseVisualStyleBackColor = true;
            this.btnClearHotkey.Click += new System.EventHandler(this.btnClearHotkey_Click);
            // 
            // btnAssignHotkey
            // 
            this.btnAssignHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignHotkey.Location = new System.Drawing.Point(257, 94);
            this.btnAssignHotkey.Name = "btnAssignHotkey";
            this.btnAssignHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnAssignHotkey.TabIndex = 2;
            this.btnAssignHotkey.Text = "تعیین";
            this.btnAssignHotkey.UseVisualStyleBackColor = true;
            this.btnAssignHotkey.Click += new System.EventHandler(this.btnAssignShortcut_Click);
            // 
            // lblShortcutDesc
            // 
            this.lblShortcutDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShortcutDesc.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblShortcutDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShortcutDesc.Location = new System.Drawing.Point(8, 1);
            this.lblShortcutDesc.Name = "lblShortcutDesc";
            this.lblShortcutDesc.Size = new System.Drawing.Size(513, 62);
            this.lblShortcutDesc.TabIndex = 1;
            // 
            // hotkeyControl
            // 
            this.hotkeyControl.Hotkey = hotkey1;
            this.hotkeyControl.Location = new System.Drawing.Point(338, 96);
            this.hotkeyControl.Name = "hotkeyControl";
            this.hotkeyControl.Size = new System.Drawing.Size(180, 21);
            this.hotkeyControl.TabIndex = 8;
            this.hotkeyControl.HotkeyChanged += new System.EventHandler(this.hotkeyControl_HotkeyChanged);
            // 
            // tbPageAddinSettings
            // 
            this.tbPageAddinSettings.Controls.Add(this.grpVirastyarUpdate);
            this.tbPageAddinSettings.Controls.Add(this.groupBox2);
            this.tbPageAddinSettings.Controls.Add(this.grpResetSettings);
            this.tbPageAddinSettings.Location = new System.Drawing.Point(4, 22);
            this.tbPageAddinSettings.Name = "tbPageAddinSettings";
            this.tbPageAddinSettings.Size = new System.Drawing.Size(529, 469);
            this.tbPageAddinSettings.TabIndex = 4;
            this.tbPageAddinSettings.Text = "افزونه";
            this.tbPageAddinSettings.UseVisualStyleBackColor = true;
            // 
            // grpVirastyarUpdate
            // 
            this.grpVirastyarUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVirastyarUpdate.Controls.Add(this.btnCheckForUpdate);
            this.grpVirastyarUpdate.Controls.Add(this.label12);
            this.grpVirastyarUpdate.Location = new System.Drawing.Point(8, 256);
            this.grpVirastyarUpdate.Name = "grpVirastyarUpdate";
            this.grpVirastyarUpdate.Size = new System.Drawing.Size(513, 80);
            this.grpVirastyarUpdate.TabIndex = 5;
            this.grpVirastyarUpdate.TabStop = false;
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckForUpdate.Location = new System.Drawing.Point(347, 43);
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(160, 23);
            this.btnCheckForUpdate.TabIndex = 4;
            this.btnCheckForUpdate.Text = "بررسی نسخه‌ی جدید";
            this.btnCheckForUpdate.UseVisualStyleBackColor = true;
            this.btnCheckForUpdate.Click += new System.EventHandler(this.btnCheckForUpdate_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(501, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "از وجود نسخه‌های جدیدتر ویراستیار مطلع شوید:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdoSendReportDecline);
            this.groupBox2.Controls.Add(this.rdoSendReportAccept);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کمک به بهبود ویراستیار";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(337, 155);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "» مشاهده اطلاعات جمع‌آوری شده";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 88);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // rdoSendReportDecline
            // 
            this.rdoSendReportDecline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoSendReportDecline.AutoSize = true;
            this.rdoSendReportDecline.Location = new System.Drawing.Point(413, 208);
            this.rdoSendReportDecline.Name = "rdoSendReportDecline";
            this.rdoSendReportDecline.Size = new System.Drawing.Size(82, 17);
            this.rdoSendReportDecline.TabIndex = 4;
            this.rdoSendReportDecline.Text = "موافق نیستم";
            this.rdoSendReportDecline.UseVisualStyleBackColor = true;
            // 
            // rdoSendReportAccept
            // 
            this.rdoSendReportAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoSendReportAccept.AutoSize = true;
            this.rdoSendReportAccept.Checked = true;
            this.rdoSendReportAccept.Location = new System.Drawing.Point(440, 185);
            this.rdoSendReportAccept.Name = "rdoSendReportAccept";
            this.rdoSendReportAccept.Size = new System.Drawing.Size(55, 17);
            this.rdoSendReportAccept.TabIndex = 3;
            this.rdoSendReportAccept.TabStop = true;
            this.rdoSendReportAccept.Text = "موافقم";
            this.rdoSendReportAccept.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "ویراستیار می‌تواند بصورت خودکار گزارشی از عملکرد و خطاهای رخ‌داده در برنامه را جم" +
    "ع‌آوری و ارسال کند.\r\nبا فعال‌سازی این قابلیت می‌توانید به بهبود ویراستیار کمک کن" +
    "ید.";
            // 
            // grpResetSettings
            // 
            this.grpResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResetSettings.Controls.Add(this.btnRestoreDataFiles);
            this.grpResetSettings.Controls.Add(this.btnResetSettings);
            this.grpResetSettings.Controls.Add(this.label5);
            this.grpResetSettings.Location = new System.Drawing.Point(8, 342);
            this.grpResetSettings.Name = "grpResetSettings";
            this.grpResetSettings.Size = new System.Drawing.Size(513, 90);
            this.grpResetSettings.TabIndex = 3;
            this.grpResetSettings.TabStop = false;
            // 
            // btnRestoreDataFiles
            // 
            this.btnRestoreDataFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDataFiles.Location = new System.Drawing.Point(168, 58);
            this.btnRestoreDataFiles.Name = "btnRestoreDataFiles";
            this.btnRestoreDataFiles.Size = new System.Drawing.Size(160, 23);
            this.btnRestoreDataFiles.TabIndex = 5;
            this.btnRestoreDataFiles.Text = "بازگرداندن فایل‌های دادگان";
            this.btnRestoreDataFiles.UseVisualStyleBackColor = true;
            this.btnRestoreDataFiles.Click += new System.EventHandler(this.btnRestoreDataFiles_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSettings.Location = new System.Drawing.Point(347, 58);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(160, 23);
            this.btnResetSettings.TabIndex = 4;
            this.btnResetSettings.Text = "بازگرداندن تنظیمات پیش‌فرض";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "اگر مشکلی در اجرای قابلیت‌های افزونه مشاهده می‌کنید، می‌توانید تنظیمات یا فایل‌ها" +
    "ی دادگان ویراستیار را به حالت پیش‌فرض برگردانید:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // AddinConfigurationDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(537, 539);
            this.Controls.Add(this.pnlTabContainer);
            this.Controls.Add(this.pnlButtonsContainer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddinConfigurationDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات افزونه";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.AddinConfigurationDialog_HelpButtonClicked);
            this.pnlButtonsContainer.ResumeLayout(false);
            this.pnlTabContainer.ResumeLayout(false);
            this.tabCtrlSettings.ResumeLayout(false);
            this.tbPageSpellCheck.ResumeLayout(false);
            this.groupBoxUserDictionaries.ResumeLayout(false);
            this.groupBoxUserDictionaries.PerformLayout();
            this.contextMenuStripDictionaries.ResumeLayout(false);
            this.grpDicPath.ResumeLayout(false);
            this.grpDicPath.PerformLayout();
            this.grpSpellCheckSettings.ResumeLayout(false);
            this.grpSpellCheckSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaxSuggestionsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEditDistance)).EndInit();
            this.tbPageWords.ResumeLayout(false);
            this.grpSynRhyme.ResumeLayout(false);
            this.tbPageRefineAll.ResumeLayout(false);
            this.grpRefineIgnoreList.ResumeLayout(false);
            this.grpRefineIgnoreList.PerformLayout();
            this.grpItemsToRefine.ResumeLayout(false);
            this.grpItemsToRefine.PerformLayout();
            this.tbPagePreprocessSpell.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbPageWordCompletion.ResumeLayout(false);
            this.gpWCFont.ResumeLayout(false);
            this.gpWCFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWCFontSize)).EndInit();
            this.gbWCMisc.ResumeLayout(false);
            this.gbWCMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWCMinWordLength)).EndInit();
            this.gbWCWordCount.ResumeLayout(false);
            this.gbWCWordCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWCWordCount)).EndInit();
            this.tbPageShortcut.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbPageAddinSettings.ResumeLayout(false);
            this.grpVirastyarUpdate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpResetSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.Panel pnlTabContainer;
        private System.Windows.Forms.TabControl tabCtrlSettings;
        private System.Windows.Forms.TabPage tbPageSpellCheck;
        private System.Windows.Forms.TabPage tbPageShortcut;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrEditDistance;
        private System.Windows.Forms.GroupBox grpSpellCheckSettings;
        private System.Windows.Forms.GroupBox grpDicPath;
        private System.Windows.Forms.NumericUpDown nmrMaxSuggestionsCount;
        private System.Windows.Forms.TabPage tbPageAddinSettings;
        private System.Windows.Forms.GroupBox grpResetSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbPageRefineAll;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnShortcut;
        private System.Windows.Forms.ListView lstShortcuts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblShortcutDesc;
        private System.Windows.Forms.Button btnAssignHotkey;
        private System.Windows.Forms.GroupBox grpItemsToRefine;
        private System.Windows.Forms.CheckBox cbRemoveHalfSpaces;
        private System.Windows.Forms.CheckBox cbRefineErab;
        private System.Windows.Forms.CheckBox cbRefineHalfSpaceChar;
        private System.Windows.Forms.CheckBox cbRefineDigits;
        private System.Windows.Forms.CheckBox cbRefineYaa;
        private System.Windows.Forms.CheckBox cbRefineKaaf;
        private System.Windows.Forms.GroupBox grpRefineIgnoreList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tetLetterToIgnore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewIgnoreList;
        private System.Windows.Forms.ColumnHeader columnCharFace;
        private System.Windows.Forms.ColumnHeader columnHex;
        private System.Windows.Forms.ColumnHeader columnDecimal;
        private System.Windows.Forms.Button btnAddLetterToIgnoreList;
        private System.Windows.Forms.Button btnRemoveFromIgnoreList;
        private System.Windows.Forms.TabPage tbPageWords;
        private System.Windows.Forms.GroupBox grpSynRhyme;
        private System.Windows.Forms.LinkLabel lnkRhyme;
        private System.Windows.Forms.LinkLabel lnkPersian;
        private System.Windows.Forms.LinkLabel lnkObsolete;
        private System.Windows.Forms.LinkLabel lnkVulgar;
        private System.Windows.Forms.LinkLabel lnkOral;
        private System.Windows.Forms.LinkLabel lnkImpolite;
        private System.Windows.Forms.TabPage tbPageWordCompletion;
        private System.Windows.Forms.GroupBox gbWCWordCount;
        private System.Windows.Forms.RadioButton rbWCShowMaxWords;
        private System.Windows.Forms.RadioButton rbWCShowAllWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDownWCWordCount;
        private System.Windows.Forms.GroupBox gbWCMisc;
        private System.Windows.Forms.CheckBox cbWCInsertSpace;
        private System.Windows.Forms.CheckBox cbWCCompleteWithoutHotkey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numUpDownWCMinWordLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpWCFont;
        private System.Windows.Forms.NumericUpDown numUpDownWCFontSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxUserDictionaries;
        private System.Windows.Forms.ListView listViewUserDictionaries;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.LinkLabel linkLabelDeleteItem;
        private System.Windows.Forms.LinkLabel linkLabelSpellCheckerAddExistingDic;
        private System.Windows.Forms.LinkLabel linkLabelSpellCheckerCreateDictionary;
        private System.Windows.Forms.ColumnHeader columnHeaderDesc;
        private System.Windows.Forms.CheckBox cbVocabSpaceCorrection;
        private System.Windows.Forms.CheckBox cbHaaShisakiToHaaYaa;
        private System.Windows.Forms.TabPage tbPagePreprocessSpell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRefineHeYe;
        private System.Windows.Forms.CheckBox cbRefineMee;
        private System.Windows.Forms.CheckBox cbRefineHaa;
        private System.Windows.Forms.CheckBox cbRefineAllAffixes;
        private System.Windows.Forms.CheckBox cbRefineBe;
        private System.Windows.Forms.Button btnClearHotkey;
        private System.Windows.Forms.Label label10;
        private VirastyarWordAddin.Controls.HotkeyBox hotkeyControl;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.ProgressBar progressBarBuildDictionary;
        private System.Windows.Forms.CheckBox cbDontCheckSingleLetters;
        private System.Windows.Forms.Label lblCurrentHotkey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSendReportDecline;
        private System.Windows.Forms.RadioButton rdoSendReportAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkEditDictionary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDictionaries;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditDic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteDic;
        private System.Windows.Forms.LinkLabel lnkEditUserDic;
        private System.Windows.Forms.GroupBox grpVirastyarUpdate;
        private System.Windows.Forms.Button btnCheckForUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRestoreDataFiles;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}