using System;

namespace Softphone
{
    partial class frmSoftphone
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Today", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoftphone));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuParentsoftphone = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuParentcontact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubCaddcontact = new System.Windows.Forms.ToolStripMenuItem();
            this.newGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuParentview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubVdailpad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubVcontact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubVhistory = new System.Windows.Forms.ToolStripMenuItem();
            this.logFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlControlMain = new System.Windows.Forms.Panel();
            this.tvHistory = new System.Windows.Forms.TreeView();
            this.imageHistory = new System.Windows.Forms.ImageList(this.components);
            this.pnlDialPad = new System.Windows.Forms.Panel();
            this.btnHashtag = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAsterisk = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.btnShowcontact = new System.Windows.Forms.Button();
            this.btnShowdialpad = new System.Windows.Forms.Button();
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.llblAccount = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.llblRetry = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnDial = new System.Windows.Forms.Button();
            this.pcMicro = new System.Windows.Forms.ProgressBar();
            this.pcSpeaker = new System.Windows.Forms.ProgressBar();
            this.pnlControlCall = new System.Windows.Forms.Panel();
            this.lblHideMicro = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.lblTimerCall = new System.Windows.Forms.Label();
            this.btnHangup = new System.Windows.Forms.Button();
            this.lblNumberCaller = new System.Windows.Forms.Label();
            this.pnlControlIncoming = new System.Windows.Forms.Panel();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnAccpect = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfoCall = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnTranfer = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDialpad = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.TimerRegister = new System.Windows.Forms.Timer(this.components);
            this.timeCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.timerCall = new System.Windows.Forms.Timer(this.components);
            this.meterSoundMicro = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlControlMain.SuspendLayout();
            this.pnlDialPad.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.pnlControlCall.SuspendLayout();
            this.pnlControlIncoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuParentsoftphone,
            this.menuParentcontact,
            this.menuParentview});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuSoftphone";
            // 
            // menuParentsoftphone
            // 
            this.menuParentsoftphone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuParentsoftphone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuParentsoftphone.Image = global::Softphone.Properties.Resources.Phone;
            this.menuParentsoftphone.Name = "menuParentsoftphone";
            this.menuParentsoftphone.Size = new System.Drawing.Size(110, 34);
            this.menuParentsoftphone.Text = "Softphone";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Image = global::Softphone.Properties.Resources.Customer;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Softphone.Properties.Resources.Settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Softphone.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuParentcontact
            // 
            this.menuParentcontact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubCaddcontact,
            this.newGroupToolStripMenuItem});
            this.menuParentcontact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuParentcontact.Image = global::Softphone.Properties.Resources.Contacts;
            this.menuParentcontact.Name = "menuParentcontact";
            this.menuParentcontact.Size = new System.Drawing.Size(91, 34);
            this.menuParentcontact.Text = "Contact";
            // 
            // menuSubCaddcontact
            // 
            this.menuSubCaddcontact.Image = global::Softphone.Properties.Resources.Contact;
            this.menuSubCaddcontact.Name = "menuSubCaddcontact";
            this.menuSubCaddcontact.Size = new System.Drawing.Size(165, 26);
            this.menuSubCaddcontact.Text = "Add Contact";
            // 
            // newGroupToolStripMenuItem
            // 
            this.newGroupToolStripMenuItem.Image = global::Softphone.Properties.Resources.Group;
            this.newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            this.newGroupToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGroupToolStripMenuItem.Text = "New group";
            // 
            // menuParentview
            // 
            this.menuParentview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubVdailpad,
            this.menuSubVcontact,
            this.menuSubVhistory,
            this.logFileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuParentview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuParentview.Image = global::Softphone.Properties.Resources.List_View;
            this.menuParentview.Name = "menuParentview";
            this.menuParentview.Size = new System.Drawing.Size(72, 34);
            this.menuParentview.Text = "View";
            // 
            // menuSubVdailpad
            // 
            this.menuSubVdailpad.Checked = true;
            this.menuSubVdailpad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSubVdailpad.Name = "menuSubVdailpad";
            this.menuSubVdailpad.Size = new System.Drawing.Size(133, 26);
            this.menuSubVdailpad.Text = "Dialpad";
            this.menuSubVdailpad.Click += new System.EventHandler(this.menuSubVdailpad_Click);
            // 
            // menuSubVcontact
            // 
            this.menuSubVcontact.Checked = true;
            this.menuSubVcontact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSubVcontact.Name = "menuSubVcontact";
            this.menuSubVcontact.Size = new System.Drawing.Size(133, 26);
            this.menuSubVcontact.Text = "Contact";
            // 
            // menuSubVhistory
            // 
            this.menuSubVhistory.Checked = true;
            this.menuSubVhistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSubVhistory.Name = "menuSubVhistory";
            this.menuSubVhistory.Size = new System.Drawing.Size(133, 26);
            this.menuSubVhistory.Text = "History";
            // 
            // logFileToolStripMenuItem
            // 
            this.logFileToolStripMenuItem.Name = "logFileToolStripMenuItem";
            this.logFileToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.logFileToolStripMenuItem.Text = "LogFile";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Softphone.Properties.Resources.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlControlMain);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlMain.Location = new System.Drawing.Point(0, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(288, 531);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlControlMain
            // 
            this.pnlControlMain.Controls.Add(this.tvHistory);
            this.pnlControlMain.Controls.Add(this.pnlDialPad);
            this.pnlControlMain.Controls.Add(this.panel6);
            this.pnlControlMain.Controls.Add(this.lb_Log);
            this.pnlControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlMain.Location = new System.Drawing.Point(0, 151);
            this.pnlControlMain.Name = "pnlControlMain";
            this.pnlControlMain.Size = new System.Drawing.Size(288, 350);
            this.pnlControlMain.TabIndex = 4;
            // 
            // tvHistory
            // 
            this.tvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvHistory.ImageIndex = 0;
            this.tvHistory.ImageList = this.imageHistory;
            this.tvHistory.LineColor = System.Drawing.Color.White;
            this.tvHistory.Location = new System.Drawing.Point(0, 0);
            this.tvHistory.Name = "tvHistory";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Node1";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.ImageIndex = -2;
            treeNode2.Name = "nToday";
            treeNode2.Text = "Today";
            this.tvHistory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvHistory.SelectedImageIndex = 0;
            this.tvHistory.Size = new System.Drawing.Size(288, 280);
            this.tvHistory.TabIndex = 18;
            this.tvHistory.Visible = false;
            // 
            // imageHistory
            // 
            this.imageHistory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageHistory.ImageStream")));
            this.imageHistory.TransparentColor = System.Drawing.Color.Transparent;
            this.imageHistory.Images.SetKeyName(0, "Calendar_48px.png");
            this.imageHistory.Images.SetKeyName(1, "Callback_48px.png");
            this.imageHistory.Images.SetKeyName(2, "Missed Call_48px.png");
            this.imageHistory.Images.SetKeyName(3, "Phone_48px.png");
            // 
            // pnlDialPad
            // 
            this.pnlDialPad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlDialPad.Controls.Add(this.btnHashtag);
            this.pnlDialPad.Controls.Add(this.btn0);
            this.pnlDialPad.Controls.Add(this.btnAsterisk);
            this.pnlDialPad.Controls.Add(this.btn9);
            this.pnlDialPad.Controls.Add(this.btn8);
            this.pnlDialPad.Controls.Add(this.btn7);
            this.pnlDialPad.Controls.Add(this.btn6);
            this.pnlDialPad.Controls.Add(this.btn5);
            this.pnlDialPad.Controls.Add(this.btn4);
            this.pnlDialPad.Controls.Add(this.btn3);
            this.pnlDialPad.Controls.Add(this.btn2);
            this.pnlDialPad.Controls.Add(this.btn1);
            this.pnlDialPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialPad.Enabled = false;
            this.pnlDialPad.Location = new System.Drawing.Point(0, 0);
            this.pnlDialPad.Name = "pnlDialPad";
            this.pnlDialPad.Size = new System.Drawing.Size(288, 280);
            this.pnlDialPad.TabIndex = 6;
            // 
            // btnHashtag
            // 
            this.btnHashtag.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnHashtag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHashtag.FlatAppearance.BorderSize = 0;
            this.btnHashtag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHashtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashtag.ForeColor = System.Drawing.Color.OldLace;
            this.btnHashtag.Location = new System.Drawing.Point(170, 205);
            this.btnHashtag.Name = "btnHashtag";
            this.btnHashtag.Size = new System.Drawing.Size(69, 64);
            this.btnHashtag.TabIndex = 17;
            this.btnHashtag.Text = "#";
            this.btnHashtag.UseVisualStyleBackColor = false;
            this.btnHashtag.Click += new System.EventHandler(this.btnHashtag_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.OldLace;
            this.btn0.Location = new System.Drawing.Point(99, 205);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 64);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAsterisk
            // 
            this.btnAsterisk.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAsterisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsterisk.FlatAppearance.BorderSize = 0;
            this.btnAsterisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsterisk.ForeColor = System.Drawing.Color.OldLace;
            this.btnAsterisk.Location = new System.Drawing.Point(28, 205);
            this.btnAsterisk.Name = "btnAsterisk";
            this.btnAsterisk.Size = new System.Drawing.Size(69, 64);
            this.btnAsterisk.TabIndex = 15;
            this.btnAsterisk.Text = "*";
            this.btnAsterisk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsterisk.UseVisualStyleBackColor = false;
            this.btnAsterisk.Click += new System.EventHandler(this.btnAsterisk_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.OldLace;
            this.btn9.Location = new System.Drawing.Point(170, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 64);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.OldLace;
            this.btn8.Location = new System.Drawing.Point(99, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 64);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.OldLace;
            this.btn7.Location = new System.Drawing.Point(28, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 64);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.OldLace;
            this.btn6.Location = new System.Drawing.Point(170, 74);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 64);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.OldLace;
            this.btn5.Location = new System.Drawing.Point(99, 74);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 64);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.OldLace;
            this.btn4.Location = new System.Drawing.Point(28, 74);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 64);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Wheat;
            this.btn3.Location = new System.Drawing.Point(170, 9);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 64);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.OldLace;
            this.btn2.Location = new System.Drawing.Point(99, 9);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 64);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.OldLace;
            this.btn1.Location = new System.Drawing.Point(28, 9);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 64);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.btnShowLog);
            this.panel6.Controls.Add(this.btnShowHistory);
            this.panel6.Controls.Add(this.btnShowcontact);
            this.panel6.Controls.Add(this.btnShowdialpad);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 280);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 70);
            this.panel6.TabIndex = 5;
            // 
            // btnShowLog
            // 
            this.btnShowLog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLog.FlatAppearance.BorderSize = 0;
            this.btnShowLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowLog.Image = global::Softphone.Properties.Resources.Document_48px;
            this.btnShowLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowLog.Location = new System.Drawing.Point(217, 0);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(64, 70);
            this.btnShowLog.TabIndex = 9;
            this.btnShowLog.Text = "Log";
            this.btnShowLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowLog.UseVisualStyleBackColor = false;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowlog_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHistory.FlatAppearance.BorderSize = 0;
            this.btnShowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowHistory.Image = global::Softphone.Properties.Resources.Timesheet_48px;
            this.btnShowHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowHistory.Location = new System.Drawing.Point(147, 0);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(64, 70);
            this.btnShowHistory.TabIndex = 8;
            this.btnShowHistory.Text = "History";
            this.btnShowHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowHistory.UseVisualStyleBackColor = false;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnShowcontact
            // 
            this.btnShowcontact.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowcontact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowcontact.FlatAppearance.BorderSize = 0;
            this.btnShowcontact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowcontact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowcontact.Image = global::Softphone.Properties.Resources.Contact_Details_52px;
            this.btnShowcontact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowcontact.Location = new System.Drawing.Point(77, 0);
            this.btnShowcontact.Name = "btnShowcontact";
            this.btnShowcontact.Size = new System.Drawing.Size(64, 70);
            this.btnShowcontact.TabIndex = 7;
            this.btnShowcontact.Text = "Contacts";
            this.btnShowcontact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowcontact.UseVisualStyleBackColor = false;
            this.btnShowcontact.Click += new System.EventHandler(this.btnShowcontact_Click);
            // 
            // btnShowdialpad
            // 
            this.btnShowdialpad.BackColor = System.Drawing.Color.DarkOrange;
            this.btnShowdialpad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowdialpad.FlatAppearance.BorderSize = 0;
            this.btnShowdialpad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowdialpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowdialpad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowdialpad.Image = global::Softphone.Properties.Resources.Office_Phone;
            this.btnShowdialpad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowdialpad.Location = new System.Drawing.Point(7, 0);
            this.btnShowdialpad.Name = "btnShowdialpad";
            this.btnShowdialpad.Size = new System.Drawing.Size(64, 70);
            this.btnShowdialpad.TabIndex = 6;
            this.btnShowdialpad.Text = "Dialpad";
            this.btnShowdialpad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowdialpad.UseVisualStyleBackColor = false;
            this.btnShowdialpad.Click += new System.EventHandler(this.btnShowdialpad_Click);
            // 
            // lb_Log
            // 
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(0, 0);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(285, 277);
            this.lb_Log.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 30);
            this.panel4.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Turquoise;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMinimize.Location = new System.Drawing.Point(252, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 28);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "<";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNumber);
            this.panel3.Controls.Add(this.llblAccount);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.llblRetry);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.pbxStatus);
            this.panel3.Controls.Add(this.cbxStatus);
            this.panel3.Controls.Add(this.btnDial);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 151);
            this.panel3.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(9, 103);
            this.txtNumber.MaxLength = 30;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(208, 31);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // llblAccount
            // 
            this.llblAccount.AutoSize = true;
            this.llblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAccount.Location = new System.Drawing.Point(24, 65);
            this.llblAccount.Name = "llblAccount";
            this.llblAccount.Size = new System.Drawing.Size(68, 20);
            this.llblAccount.TabIndex = 26;
            this.llblAccount.TabStop = true;
            this.llblAccount.Text = "Account";
            this.llblAccount.Visible = false;
            this.llblAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAccount_LinkClicked);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(146, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 49);
            this.label1.TabIndex = 25;
            // 
            // llblRetry
            // 
            this.llblRetry.AutoSize = true;
            this.llblRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRetry.Location = new System.Drawing.Point(181, 65);
            this.llblRetry.Name = "llblRetry";
            this.llblRetry.Size = new System.Drawing.Size(47, 20);
            this.llblRetry.TabIndex = 24;
            this.llblRetry.TabStop = true;
            this.llblRetry.Text = "Retry";
            this.llblRetry.Visible = false;
            this.llblRetry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRetry_LinkClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(83, 1);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 20);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbxStatus
            // 
            this.pbxStatus.Image = global::Softphone.Properties.Resources.offline;
            this.pbxStatus.Location = new System.Drawing.Point(9, 0);
            this.pbxStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(60, 60);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 22;
            this.pbxStatus.TabStop = false;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Offline",
            "Online",
            "On Phone",
            "Busy"});
            this.cbxStatus.Location = new System.Drawing.Point(76, 25);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxStatus.Size = new System.Drawing.Size(70, 24);
            this.cbxStatus.TabIndex = 21;
            // 
            // btnDial
            // 
            this.btnDial.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDial.Enabled = false;
            this.btnDial.Image = global::Softphone.Properties.Resources.Answer1;
            this.btnDial.Location = new System.Drawing.Point(218, 92);
            this.btnDial.Name = "btnDial";
            this.btnDial.Size = new System.Drawing.Size(67, 53);
            this.btnDial.TabIndex = 10;
            this.btnDial.UseVisualStyleBackColor = false;
            this.btnDial.Click += new System.EventHandler(this.btnDial_Click);
            // 
            // pcMicro
            // 
            this.pcMicro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcMicro.ForeColor = System.Drawing.Color.DarkOrange;
            this.pcMicro.Location = new System.Drawing.Point(10, 88);
            this.pcMicro.Name = "pcMicro";
            this.pcMicro.Size = new System.Drawing.Size(72, 5);
            this.pcMicro.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pcMicro.TabIndex = 9;
            // 
            // pcSpeaker
            // 
            this.pcSpeaker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcSpeaker.ForeColor = System.Drawing.Color.DarkOrange;
            this.pcSpeaker.Location = new System.Drawing.Point(158, 88);
            this.pcSpeaker.Name = "pcSpeaker";
            this.pcSpeaker.Size = new System.Drawing.Size(72, 5);
            this.pcSpeaker.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pcSpeaker.TabIndex = 12;
            // 
            // pnlControlCall
            // 
            this.pnlControlCall.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlControlCall.Controls.Add(this.lblHideMicro);
            this.pnlControlCall.Controls.Add(this.lblHide);
            this.pnlControlCall.Controls.Add(this.pcSpeaker);
            this.pnlControlCall.Controls.Add(this.pcMicro);
            this.pnlControlCall.Controls.Add(this.lblTimerCall);
            this.pnlControlCall.Controls.Add(this.btnHangup);
            this.pnlControlCall.Controls.Add(this.lblNumberCaller);
            this.pnlControlCall.Controls.Add(this.pnlControlIncoming);
            this.pnlControlCall.Controls.Add(this.lblName);
            this.pnlControlCall.Controls.Add(this.lblInfoCall);
            this.pnlControlCall.Controls.Add(this.pictureBox1);
            this.pnlControlCall.Controls.Add(this.pnlControl);
            this.pnlControlCall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlControlCall.Location = new System.Drawing.Point(288, 38);
            this.pnlControlCall.Name = "pnlControlCall";
            this.pnlControlCall.Size = new System.Drawing.Size(463, 531);
            this.pnlControlCall.TabIndex = 2;
            // 
            // lblHideMicro
            // 
            this.lblHideMicro.Location = new System.Drawing.Point(10, 88);
            this.lblHideMicro.Name = "lblHideMicro";
            this.lblHideMicro.Size = new System.Drawing.Size(72, 5);
            this.lblHideMicro.TabIndex = 14;
            // 
            // lblHide
            // 
            this.lblHide.Location = new System.Drawing.Point(158, 88);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(72, 5);
            this.lblHide.TabIndex = 13;
            // 
            // lblTimerCall
            // 
            this.lblTimerCall.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblTimerCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCall.ForeColor = System.Drawing.Color.Red;
            this.lblTimerCall.Location = new System.Drawing.Point(187, 329);
            this.lblTimerCall.Name = "lblTimerCall";
            this.lblTimerCall.Size = new System.Drawing.Size(69, 36);
            this.lblTimerCall.TabIndex = 8;
            this.lblTimerCall.Text = "00:00";
            this.lblTimerCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimerCall.Visible = false;
            // 
            // btnHangup
            // 
            this.btnHangup.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnHangup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHangup.FlatAppearance.BorderSize = 0;
            this.btnHangup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangup.ForeColor = System.Drawing.Color.Red;
            this.btnHangup.Image = global::Softphone.Properties.Resources.End_Call;
            this.btnHangup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHangup.Location = new System.Drawing.Point(170, 381);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHangup.Size = new System.Drawing.Size(108, 60);
            this.btnHangup.TabIndex = 7;
            this.btnHangup.Text = "Hangup";
            this.btnHangup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHangup.UseVisualStyleBackColor = false;
            this.btnHangup.Visible = false;
            this.btnHangup.Click += new System.EventHandler(this.btnHangup_Click);
            // 
            // lblNumberCaller
            // 
            this.lblNumberCaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberCaller.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNumberCaller.Location = new System.Drawing.Point(224, 242);
            this.lblNumberCaller.Name = "lblNumberCaller";
            this.lblNumberCaller.Size = new System.Drawing.Size(110, 38);
            this.lblNumberCaller.TabIndex = 6;
            this.lblNumberCaller.Text = "Name";
            this.lblNumberCaller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControlIncoming
            // 
            this.pnlControlIncoming.Controls.Add(this.btnIgnore);
            this.pnlControlIncoming.Controls.Add(this.btnAccpect);
            this.pnlControlIncoming.Controls.Add(this.btnReject);
            this.pnlControlIncoming.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlIncoming.Location = new System.Drawing.Point(0, 447);
            this.pnlControlIncoming.Name = "pnlControlIncoming";
            this.pnlControlIncoming.Size = new System.Drawing.Size(463, 84);
            this.pnlControlIncoming.TabIndex = 5;
            this.pnlControlIncoming.Visible = false;
            // 
            // btnIgnore
            // 
            this.btnIgnore.BackColor = System.Drawing.Color.Orange;
            this.btnIgnore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgnore.FlatAppearance.BorderSize = 0;
            this.btnIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgnore.ForeColor = System.Drawing.Color.MintCream;
            this.btnIgnore.Image = global::Softphone.Properties.Resources.Do_Not_Disturb;
            this.btnIgnore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIgnore.Location = new System.Drawing.Point(284, 21);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(93, 40);
            this.btnIgnore.TabIndex = 9;
            this.btnIgnore.Text = "Ignore";
            this.btnIgnore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIgnore.UseVisualStyleBackColor = false;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnAccpect
            // 
            this.btnAccpect.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAccpect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccpect.FlatAppearance.BorderSize = 0;
            this.btnAccpect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccpect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccpect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAccpect.Image = global::Softphone.Properties.Resources.Answer1;
            this.btnAccpect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccpect.Location = new System.Drawing.Point(71, 21);
            this.btnAccpect.Name = "btnAccpect";
            this.btnAccpect.Size = new System.Drawing.Size(104, 40);
            this.btnAccpect.TabIndex = 7;
            this.btnAccpect.Text = "Accpect";
            this.btnAccpect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccpect.UseVisualStyleBackColor = false;
            this.btnAccpect.Click += new System.EventHandler(this.btnAccpect_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReject.Image = global::Softphone.Properties.Resources.End_Callpng;
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.Location = new System.Drawing.Point(181, 21);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(97, 40);
            this.btnReject.TabIndex = 8;
            this.btnReject.Text = "Reject";
            this.btnReject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(224, 204);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 38);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoCall
            // 
            this.lblInfoCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCall.ForeColor = System.Drawing.Color.Red;
            this.lblInfoCall.Location = new System.Drawing.Point(146, 135);
            this.lblInfoCall.Name = "lblInfoCall";
            this.lblInfoCall.Size = new System.Drawing.Size(110, 38);
            this.lblInfoCall.TabIndex = 2;
            this.lblInfoCall.Text = "Calling";
            this.lblInfoCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Softphone.Properties.Resources.Account_call;
            this.pictureBox1.Location = new System.Drawing.Point(71, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnTranfer);
            this.pnlControl.Controls.Add(this.btnRecord);
            this.pnlControl.Controls.Add(this.btnDialpad);
            this.pnlControl.Controls.Add(this.btnHold);
            this.pnlControl.Controls.Add(this.btnSpeaker);
            this.pnlControl.Controls.Add(this.btnMute);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(463, 88);
            this.pnlControl.TabIndex = 0;
            // 
            // btnTranfer
            // 
            this.btnTranfer.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnTranfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranfer.FlatAppearance.BorderSize = 0;
            this.btnTranfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranfer.ForeColor = System.Drawing.Color.OldLace;
            this.btnTranfer.Image = global::Softphone.Properties.Resources.Curved_Arrow;
            this.btnTranfer.Location = new System.Drawing.Point(383, 21);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.Size = new System.Drawing.Size(72, 67);
            this.btnTranfer.TabIndex = 11;
            this.btnTranfer.Text = "Tranfer";
            this.btnTranfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTranfer.UseVisualStyleBackColor = false;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.OldLace;
            this.btnRecord.Image = global::Softphone.Properties.Resources.Music_Record;
            this.btnRecord.Location = new System.Drawing.Point(308, 21);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(72, 67);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnDialpad
            // 
            this.btnDialpad.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnDialpad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDialpad.FlatAppearance.BorderSize = 0;
            this.btnDialpad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDialpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDialpad.ForeColor = System.Drawing.Color.OldLace;
            this.btnDialpad.Image = global::Softphone.Properties.Resources.Phone_Keys;
            this.btnDialpad.Location = new System.Drawing.Point(233, 21);
            this.btnDialpad.Name = "btnDialpad";
            this.btnDialpad.Size = new System.Drawing.Size(72, 67);
            this.btnDialpad.TabIndex = 9;
            this.btnDialpad.Text = "Dialpad";
            this.btnDialpad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDialpad.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.OldLace;
            this.btnHold.Image = global::Softphone.Properties.Resources.Pause_Button;
            this.btnHold.Location = new System.Drawing.Point(83, 21);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(72, 67);
            this.btnHold.TabIndex = 8;
            this.btnHold.Text = "Hold";
            this.btnHold.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeaker.FlatAppearance.BorderSize = 0;
            this.btnSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeaker.ForeColor = System.Drawing.Color.OldLace;
            this.btnSpeaker.Image = global::Softphone.Properties.Resources.No_Audio_32px;
            this.btnSpeaker.Location = new System.Drawing.Point(158, 21);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(72, 67);
            this.btnSpeaker.TabIndex = 7;
            this.btnSpeaker.Text = "Speaker";
            this.btnSpeaker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSpeaker.UseVisualStyleBackColor = false;
            this.btnSpeaker.Click += new System.EventHandler(this.btnSpeaker_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMute.FlatAppearance.BorderSize = 0;
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.ForeColor = System.Drawing.Color.OldLace;
            this.btnMute.Image = global::Softphone.Properties.Resources.Mute;
            this.btnMute.Location = new System.Drawing.Point(8, 21);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(72, 67);
            this.btnMute.TabIndex = 5;
            this.btnMute.Text = "Mute";
            this.btnMute.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // TimerRegister
            // 
            this.TimerRegister.Interval = 5000;
            this.TimerRegister.Tick += new System.EventHandler(this.TimerRegister_Tick);
            // 
            // timeCheckStatus
            // 
            this.timeCheckStatus.Interval = 2000;
            this.timeCheckStatus.Tick += new System.EventHandler(this.timeCheckStatus_Tick);
            // 
            // timerCall
            // 
            this.timerCall.Interval = 1000;
            this.timerCall.Tick += new System.EventHandler(this.timerCall_Tick);
            // 
            // meterSoundMicro
            // 
            this.meterSoundMicro.Interval = 10;
            this.meterSoundMicro.Tick += new System.EventHandler(this.meterSoundMicro_Tick);
            // 
            // frmSoftphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 569);
            this.Controls.Add(this.pnlControlCall);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSoftphone";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow";
            this.Load += new System.EventHandler(this.frmSoftphone_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlControlMain.ResumeLayout(false);
            this.pnlDialPad.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.pnlControlCall.ResumeLayout(false);
            this.pnlControlIncoming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuParentsoftphone;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuParentcontact;
        private System.Windows.Forms.ToolStripMenuItem menuSubCaddcontact;
        private System.Windows.Forms.ToolStripMenuItem newGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuParentview;
        private System.Windows.Forms.ToolStripMenuItem menuSubVdailpad;
        private System.Windows.Forms.ToolStripMenuItem menuSubVcontact;
        private System.Windows.Forms.ToolStripMenuItem menuSubVhistory;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControlCall;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfoCall;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlControlIncoming;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.Label lblNumberCaller;
        private System.Windows.Forms.Button btnDial;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDialpad;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblRetry;
        private System.Windows.Forms.LinkLabel llblAccount;
        private System.Windows.Forms.Timer TimerRegister;
        private System.Windows.Forms.Timer timeCheckStatus;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Panel pnlControlMain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Button btnShowcontact;
        private System.Windows.Forms.Button btnShowdialpad;
        private System.Windows.Forms.Panel pnlDialPad;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnHashtag;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAsterisk;
        private System.Windows.Forms.ToolStripMenuItem logFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccpect;
        private System.Windows.Forms.Button btnHangup;
        private System.Windows.Forms.Timer timerCall;
        private System.Windows.Forms.Label lblTimerCall;
        private System.Windows.Forms.TreeView tvHistory;
        private System.Windows.Forms.ImageList imageHistory;
        private System.Windows.Forms.Timer meterSoundMicro;
        private System.Windows.Forms.ProgressBar pcSpeaker;
        private System.Windows.Forms.ProgressBar pcMicro;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Label lblHideMicro;
    }
}