namespace Softphone
{
    partial class Form1
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
            this.filepathTextbox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadSyncButton = new System.Windows.Forms.Button();
            this.playOnceSyncButton = new System.Windows.Forms.Button();
            this.playOnceAsyncButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playLoopAsyncButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.loadAsyncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filepathTextbox
            // 
            this.filepathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.filepathTextbox.Location = new System.Drawing.Point(7, 25);
            this.filepathTextbox.Name = "filepathTextbox";
            this.filepathTextbox.Size = new System.Drawing.Size(263, 20);
            this.filepathTextbox.TabIndex = 1;
            this.filepathTextbox.Text = "";
            this.filepathTextbox.TextChanged += new System.EventHandler(this.filepathTextbox_TextChanged);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Location = new System.Drawing.Point(276, 25);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(23, 21);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "...";
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = ".wav path or URL:";
            // 
            // loadSyncButton
            // 
            this.loadSyncButton.Location = new System.Drawing.Point(7, 53);
            this.loadSyncButton.Name = "loadSyncButton";
            this.loadSyncButton.Size = new System.Drawing.Size(142, 23);
            this.loadSyncButton.TabIndex = 4;
            this.loadSyncButton.Text = "Load Synchronously";
            this.loadSyncButton.Click += new System.EventHandler(this.loadSyncButton_Click);
            // 
            // playOnceSyncButton
            // 
            this.playOnceSyncButton.Location = new System.Drawing.Point(7, 86);
            this.playOnceSyncButton.Name = "playOnceSyncButton";
            this.playOnceSyncButton.Size = new System.Drawing.Size(142, 23);
            this.playOnceSyncButton.TabIndex = 5;
            this.playOnceSyncButton.Text = "Play Once Synchronously";
            this.playOnceSyncButton.Click += new System.EventHandler(this.playOnceSyncButton_Click);
            // 
            // playOnceAsyncButton
            // 
            this.playOnceAsyncButton.Location = new System.Drawing.Point(149, 86);
            this.playOnceAsyncButton.Name = "playOnceAsyncButton";
            this.playOnceAsyncButton.Size = new System.Drawing.Size(147, 23);
            this.playOnceAsyncButton.TabIndex = 6;
            this.playOnceAsyncButton.Text = "Play Once Asynchronously";
            this.playOnceAsyncButton.Click += new System.EventHandler(this.playOnceAsyncButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(149, 109);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(147, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playLoopAsyncButton
            // 
            this.playLoopAsyncButton.Location = new System.Drawing.Point(7, 109);
            this.playLoopAsyncButton.Name = "playLoopAsyncButton";
            this.playLoopAsyncButton.Size = new System.Drawing.Size(142, 23);
            this.playLoopAsyncButton.TabIndex = 8;
            this.playLoopAsyncButton.Text = "Loop Asynchronously";
            this.playLoopAsyncButton.Click += new System.EventHandler(this.playLoopAsyncButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 146);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(306, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 9;
            this.statusBar.Text = "(no status)";
            // 
            // loadAsyncButton
            // 
            this.loadAsyncButton.Location = new System.Drawing.Point(149, 53);
            this.loadAsyncButton.Name = "loadAsyncButton";
            this.loadAsyncButton.Size = new System.Drawing.Size(147, 23);
            this.loadAsyncButton.TabIndex = 10;
            this.loadAsyncButton.Text = "Load Asynchronously";
            this.loadAsyncButton.Click += new System.EventHandler(this.loadAsyncButton_Click);
            // 
            // SoundTestForm
            // 
            this.ClientSize = new System.Drawing.Size(306, 168);
            this.Controls.Add(this.loadAsyncButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.playLoopAsyncButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playOnceAsyncButton);
            this.Controls.Add(this.playOnceSyncButton);
            this.Controls.Add(this.loadSyncButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.filepathTextbox);
            this.MinimumSize = new System.Drawing.Size(310, 165);
            this.Name = "SoundTestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sound API Test Form";
            this.ResumeLayout(false);

        }

        #endregion
    }
}