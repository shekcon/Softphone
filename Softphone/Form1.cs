using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Media;


namespace Softphone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Initialize Forms Designer generated code.
            InitializeComponent();

            // Disable playback controls until a valid .wav file 
            // is selected.
            EnablePlaybackControls(false);

            // Set up the status bar and other controls.
            InitializeControls();

            // Set up the SoundPlayer object.
            InitializeSound();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filepathTextbox;
        private System.Windows.Forms.Button playOnceSyncButton;
        private System.Windows.Forms.Button playOnceAsyncButton;
        private System.Windows.Forms.Button playLoopAsyncButton;
        private System.Windows.Forms.Button selectFileButton;

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Button loadSyncButton;
        private System.Windows.Forms.Button loadAsyncButton;
        private SoundPlayer player;

        
        // Sets up the status bar and other controls.
        private void InitializeControls()
        {
            // Set up the status bar.
            StatusBarPanel panel = new StatusBarPanel();
            panel.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panel.Text = "Ready.";
            panel.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBar.ShowPanels = true;
            this.statusBar.Panels.Add(panel);
        }

        // Sets up the SoundPlayer object.
        private void InitializeSound()
        {
            // Create an instance of the SoundPlayer class.
            player = new SoundPlayer();

            // Listen for the LoadCompleted event.
            player.LoadCompleted += new AsyncCompletedEventHandler(player_LoadCompleted);

            // Listen for the SoundLocationChanged event.
            player.SoundLocationChanged += new EventHandler(player_LocationChanged);
        }

        private void selectFileButton_Click(object sender,
            System.EventArgs e)
        {
            // Create a new OpenFileDialog.
            OpenFileDialog dlg = new OpenFileDialog();

            // Make sure the dialog checks for existence of the 
            // selected file.
            dlg.CheckFileExists = true;

            // Allow selection of .wav files only.
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            // Activate the file selection dialog.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog.
                this.filepathTextbox.Text = dlg.FileName;

                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = filepathTextbox.Text;
            }
        }

        // Convenience method for setting message text in 
        // the status bar.
        private void ReportStatus(string statusMessage)
        {
            // If the caller passed in a message...
            if ((statusMessage != null) && (statusMessage != String.Empty))
            {
                // ...post the caller's message to the status bar.
                this.statusBar.Panels[0].Text = statusMessage;
            }
        }

        // Enables and disables play controls.
        private void EnablePlaybackControls(bool enabled)
        {
            this.playOnceSyncButton.Enabled = enabled;
            this.playOnceAsyncButton.Enabled = enabled;
            this.playLoopAsyncButton.Enabled = enabled;
            this.stopButton.Enabled = enabled;
        }

        private void filepathTextbox_TextChanged(object sender,
            EventArgs e)
        {
            // Disable playback controls until the new .wav is loaded.
            EnablePlaybackControls(false);
        }

        private void loadSyncButton_Click(object sender,
            System.EventArgs e)
        {
            // Disable playback controls until the .wav is 
            // successfully loaded. The LoadCompleted event 
            // handler will enable them.
            EnablePlaybackControls(false);

            try
            {
                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = filepathTextbox.Text;

                // Load the .wav file.
                player.Load();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void loadAsyncButton_Click(System.Object sender,
            System.EventArgs e)
        {
            // Disable playback controls until the .wav is 
            // successfully loaded. The LoadCompleted event 
            // handler will enable them.
            EnablePlaybackControls(false);

            try
            {
                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = this.filepathTextbox.Text;

                // Load the .wav file.
                player.LoadAsync();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        // Synchronously plays the selected .wav file once.
        // If the file is large, UI response will be visibly 
        // affected.
        private void playOnceSyncButton_Click(object sender,
            System.EventArgs e)
        {
            ReportStatus("Playing .wav file synchronously.");
            player.PlaySync();
            ReportStatus("Finished playing .wav file synchronously.");
        }

        // Asynchronously plays the selected .wav file once.
        private void playOnceAsyncButton_Click(object sender,
            System.EventArgs e)
        {
            ReportStatus("Playing .wav file asynchronously.");
            player.Play();
        }

        // Asynchronously plays the selected .wav file until the user
        // clicks the Stop button.
        private void playLoopAsyncButton_Click(object sender,
            System.EventArgs e)
        {
            ReportStatus("Looping .wav file asynchronously.");
            player.PlayLooping();
        }

        // Stops the currently playing .wav file, if any.
        private void stopButton_Click(System.Object sender,
            System.EventArgs e)
        {
            player.Stop();
            ReportStatus("Stopped by user.");
        }

        // Handler for the LoadCompleted event.
        private void player_LoadCompleted(object sender,
            AsyncCompletedEventArgs e)
        {
            string message = String.Format("LoadCompleted: {0}",
                this.filepathTextbox.Text);
            ReportStatus(message);
            EnablePlaybackControls(true);
        }

        // Handler for the SoundLocationChanged event.
        private void player_LocationChanged(object sender, EventArgs e)
        {
            string message = String.Format("SoundLocationChanged: {0}",
                player.SoundLocation);
            ReportStatus(message);
        }

        private void playSoundFromResource(object sender, EventArgs e)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("<AssemblyName>.chimes.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }

    }
}
